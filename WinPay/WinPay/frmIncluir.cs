using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;

namespace WinPay
{
    public partial class frmIncluir : Form
    {
        public frmIncluir() => InitializeComponent();

        private void cboxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxContas.SelectedIndex >= 0 && cboxContas.SelectedValue != null)
                txtcod.Text = cboxContas.SelectedValue.ToString();
            else
                txtcod.Clear();
        }

        private void CarregarComboContas()
        {
            try
            {
                const string sql = @"
                    SELECT codigo, descricao
                      FROM contas
                  ORDER BY codigo
                  LIMIT 200;";

                using var da = new NpgsqlDataAdapter(sql, Db.Conexao);
                da.SelectCommand.CommandTimeout = 60;

                var tabela = new DataTable();
                da.Fill(tabela);

                cboxContas.SelectedIndexChanged -= cboxContas_SelectedIndexChanged;

                cboxContas.DataSource = tabela;
                cboxContas.DisplayMember = "descricao";
                cboxContas.ValueMember = "codigo";
                cboxContas.SelectedIndex = -1;

                cboxContas.SelectedIndexChanged += cboxContas_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar contas:\n{ex}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal valor))
            {
                txtValor.Text = valor.ToString("N2", new CultureInfo("pt-BR"));

            }
            else
            {
                txtValor.Clear();
                txtdoc.Clear();
                txtParcela.Clear();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {



            if (cboxContas.SelectedIndex < 0 || cboxContas.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma conta válida.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxContas.Focus();
                return;
            }

            // Validar valor
            if (!decimal.TryParse(txtValor.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal valor))
            {
                MessageBox.Show("Informe um valor válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdoc.Text))
            {
                long docValue = (long)(valor * 100); // exemplo: 123,45 vira 12345
                txtdoc.Text = docValue.ToString();
            }

            // Se txtParcela estiver vazio, define como 1
            if (string.IsNullOrWhiteSpace(txtParcela.Text))
            {
                txtParcela.Text = "1";
            }

            // Confirmar inclusão
            var resp = MessageBox.Show("Deseja incluir título a pagar?",
                                       "Confirmação",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button2);
            if (resp != DialogResult.Yes) return;

            const string sql = @"
INSERT INTO titulos
    (datalancamento, descricao, observacoes, codigoconta, conta, datavencimento,
     valor, doc, parcela, formapagamento, boleto, servico, tipolancamento)
VALUES
    (NOW(), @descricao, @observacoes, @codigoconta, @conta, @datavencimento,
     @valor, @doc, @parcela, @formapagamento, @boleto, @servico, @tipolancamento);";

            try
            {
                using var cmd = new NpgsqlCommand(sql, Db.Conexao)
                {
                    CommandTimeout = 60
                };

                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text.Trim());
                cmd.Parameters.AddWithValue("@observacoes", txthistorico.Text.Trim());
                cmd.Parameters.AddWithValue("@codigoconta", Convert.ToInt64(cboxContas.SelectedValue));
                cmd.Parameters.AddWithValue("@conta", cboxContas.Text.Trim());
                cmd.Parameters.AddWithValue("@datavencimento", txtvencimento.Value.Date);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@doc", long.Parse(txtdoc.Text));
                cmd.Parameters.AddWithValue("@parcela", int.Parse(txtParcela.Text));
                cmd.Parameters.AddWithValue("@formapagamento", cboxformapagamento.Text.Trim());
                cmd.Parameters.AddWithValue("@boleto", checkboleto.Checked ? "Sim" : "Não");
                cmd.Parameters.AddWithValue("@servico", checkServico.Checked ? "Sim" : "Não");
                cmd.Parameters.AddWithValue("@tipolancamento", radioConfirmado.Checked ? "C" : "P");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lançamento incluído com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdescricao.Clear();
                txthistorico.Clear();
                txtValor.Clear();
                txtdoc.Clear();
                txtParcela.Clear();
                cboxContas.SelectedIndex = -1;
                cboxformapagamento.SelectedIndex = -1;
                checkboleto.Checked = false;
                checkServico.Checked = false;
                radioConfirmado.Checked = true;
                txtdescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao incluir:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIncluir_Load(object sender, EventArgs e)
        {
            CarregarComboContas();

            // Inicializar campos padrão
            txtParcela.Text = "1";
            radioConfirmado.Checked = true;
        }


        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtValor_Leave_(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtcod_Leave(object sender, EventArgs e)
        {
            // Saiu do campo sem digitar nada → limpa seleção
            if (string.IsNullOrWhiteSpace(txtcod.Text))
            {
                cboxContas.SelectedIndex = -1;
                return;
            }

            // Digitação só aceita número
            if (!long.TryParse(txtcod.Text, out long codigo))
            {
                MessageBox.Show("Código de conta inválido.",
                                "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcod.SelectAll();
                return;
            }

            // 2. Procura primeiro na tabela já carregada
            var tabela = cboxContas.DataSource as DataTable;
            DataRow encontrado = tabela?
                .AsEnumerable()
                .FirstOrDefault(r => r.Field<long>("codigo") == codigo);

            // 3a. Achou localmente → apenas seleciona
            if (encontrado != null)
            {
                cboxContas.SelectedValue = codigo;   // dispara SelectedIndexChanged
                return;
            }

            // 3b. Não achou → consulta banco
            const string sql = @"SELECT codigo, descricao
                           FROM contas
                          WHERE codigo = @codigo
                          LIMIT 1;";
            try
            {
                using var cmd = new NpgsqlCommand(sql, Db.Conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                using var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    long cod = dr.GetInt64(0);
                    string desc = dr.GetString(1);

                    // Adiciona na tabela em memória (mantém cache sempre atualizado)
                    DataRow nova = tabela.NewRow();
                    nova["codigo"] = cod;
                    nova["descricao"] = desc;
                    tabela.Rows.Add(nova);

                    cboxContas.SelectedValue = cod;  // agora existe na lista
                }
                else
                {
                    MessageBox.Show("Conta não encontrada.",
                                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcod.SelectAll();
                    cboxContas.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar conta:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDetalheContas_Click(object sender, EventArgs e)
        {
            using var frm = new frmConta();
            frm.ShowDialog(this);
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            cboxContas.SelectedIndex = -1;
            txtdescricao.Clear();
            txthistorico.Clear();
            txtValor.Clear();
            txtdoc.Clear();
            txtParcela.Clear();
            cboxformapagamento.SelectedIndex = -1;
            this.checkboleto.Checked = false;
            this.checkServico.Checked = false;

        }

        private void btnLancarParcelado_Click(object sender, EventArgs e)
        {
            DateTime vencInicial = txtvencimento.Value.Date;   // ← pega a data aqui

            // --- reaproveita as mesmas validações do btnIncluir -------------------
            if (cboxContas.SelectedIndex < 0 || cboxContas.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma conta válida.", "Validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxContas.Focus();
                return;
            }
            if (!decimal.TryParse(txtValor.Text, NumberStyles.Any,
                                  new CultureInfo("pt-BR"), out decimal totalValor))
            {
                MessageBox.Show("Informe um valor válido.", "Validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            using var f = new incluirParcelado(
       descricao: txtdescricao.Text.Trim(),
       historico: txthistorico.Text.Trim(),
       totalValor: totalValor,
       codConta: Convert.ToInt64(cboxContas.SelectedValue),
       conta: cboxContas.Text.Trim(),
       docBase: string.IsNullOrWhiteSpace(txtdoc.Text) ? null : txtdoc.Text,
       tipoLanc: radioConfirmado.Checked ? "C" : "P",
       vencInicial: vencInicial      // ← último argumento dentro dos parênteses
   );


            if (f.ShowDialog(this) == DialogResult.OK)
            {
                // se o frmParcelado deu OK, limpe o formulário principal
              //  LimparFormulario();                 // o método que já sugerimos
            }
        }
    }
    }

