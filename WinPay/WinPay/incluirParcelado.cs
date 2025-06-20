using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPay
{



    public partial class incluirParcelado : Form
    {
        private readonly DateTime _vencInicial;   // ← novo campo


        private readonly string _descricao;
        private readonly string _historico;
        private readonly decimal _totalValor;
        private readonly long _codConta;
        private readonly string _conta;
        private readonly string? _docBase;          // pode ser null
        private readonly string _tipoLanc;          // "C" ou "P"

        public incluirParcelado(string descricao, string historico,
                            decimal totalValor, long codConta, string conta,
                            string? docBase, string tipoLanc, DateTime vencInicial)
        {
            InitializeComponent();
            _descricao = descricao;
            _historico = historico;
            _totalValor = totalValor;
            _codConta = codConta;
            _conta = conta;
            _docBase = docBase;
            _tipoLanc = tipoLanc;
            _vencInicial = vencInicial;

            txtvalorparcela.Text = totalValor.ToString("N2");
            numUpQtde_ValueChanged(null, null);     // força cálculo
        }
        private void numUpQtde_ValueChanged(object sender, EventArgs e)
        {
            int q = (int)numUpQtde.Value;
            if (q == 0)
            {
                txtvalorparcela.Clear();
                return;                 // evita divisão por zero
            }

            decimal parcela = Math.Round(_totalValor / q, 2,
                                         MidpointRounding.AwayFromZero);
            txtvalorparcela.Text = parcela.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int qtd = (int)numUpQtde.Value;
            decimal valorParc = Math.Round(_totalValor / qtd, 2,
                                           MidpointRounding.AwayFromZero);
            long docNumero;
            if (!string.IsNullOrWhiteSpace(_docBase) &&
                long.TryParse(_docBase, out long parsed))
                docNumero = parsed;                       // usa o que veio da tela
            else
                docNumero = DateTime.Now.Ticks % 1_000_000_000_000L;

            var tabela = new DataTable();
            tabela.Columns.Add("descricao", typeof(string));
            tabela.Columns.Add("historico", typeof(string));

            tabela.Columns.Add("valor", typeof(decimal));
            tabela.Columns.Add("vencimento", typeof(DateTime));
            tabela.Columns.Add("doc", typeof(long));
            tabela.Columns.Add("parcela", typeof(int));
            tabela.Columns.Add("codigoconta", typeof(long));
            tabela.Columns.Add("conta", typeof(string));
            tabela.Columns.Add("tipolanc", typeof(string));







            DateTime venc = _vencInicial;   // ← começa pelo vencimento inicial
            for (int i = 1; i <= qtd; i++)
            {
                // calcula vencimento
                if (i == 1)
                {
                    // já definiu acima
                }
                else if (rbDiaFixo.Checked)
                {
                    // próximo mês, mesmo dia
                    int dia = (int)tdiafixo.Value;
                    venc = new DateTime(venc.Year, venc.Month, 1)
                           .AddMonths(1)
                           .AddDays(dia - 1);
                }
                else // rbPrazo
                {
                    int prazo = (int)tprazo.Value;
                    venc = venc.AddDays(prazo);
                }

                decimal valor = i == qtd      // última parcela → ajusta arredondamento
                    ? _totalValor - valorParc * (qtd - 1)
                    : valorParc;

                tabela.Rows.Add(_descricao, _historico, valor, venc, docNumero, i, _codConta, _conta, _tipoLanc);
            }

            dgvParcelas.DataSource = tabela;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.Rows.Count == 0)
            {
                MessageBox.Show("Gere as parcelas primeiro clicando em avançar.");
                return;
            }

            const string sql = @"
INSERT INTO titulos
    (datalancamento, descricao, observacoes, codigoconta, conta,
     datavencimento, valor, doc, parcela, formapagamento,
     boleto, servico, tipolancamento)
VALUES
    (NOW(), @descricao, @historico, @codigoconta, @conta,
     @venc, @valor, @doc, @parcela, '', 'Não', 'Não', @tipolanc);";

            var conn = Db.Conexao;
            if (conn.State != ConnectionState.Open)
                conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                using var cmd = new NpgsqlCommand(sql, conn, tran)
                { CommandTimeout = 60 };

                foreach (DataGridViewRow row in dgvParcelas.Rows)
                {
                    if (row.IsNewRow) continue;   // linha fantasma do DGV

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@descricao", row.Cells["descricao"].Value!);
                    cmd.Parameters.AddWithValue("@historico", row.Cells["historico"].Value!);
                    cmd.Parameters.AddWithValue("@codigoconta", (long)row.Cells["codigoconta"].Value!);
                    cmd.Parameters.AddWithValue("@conta", row.Cells["conta"].Value!);
                    cmd.Parameters.AddWithValue("@venc", (DateTime)row.Cells["vencimento"].Value!);
                    cmd.Parameters.AddWithValue("@valor", (decimal)row.Cells["valor"].Value!);
                    cmd.Parameters.AddWithValue("@doc", (long)row.Cells["doc"].Value);
                    cmd.Parameters.AddWithValue("@parcela", (int)row.Cells["parcela"].Value!);
                    cmd.Parameters.AddWithValue("@tipolanc", row.Cells["tipolanc"].Value!);

                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                MessageBox.Show("Parcelas lançadas com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show($"Erro ao gravar parcelas:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void incluirParcelado_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
