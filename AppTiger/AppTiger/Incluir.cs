using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Apptiger
{
    public partial class Incluir : Form
    {
        public Incluir()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private static readonly string ConnStr =
            $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
            $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
            $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
            $"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
            $"Password={Environment.GetEnvironmentVariable("DB_PASS")};" +
            "Ssl Mode=Require;Trust Server Certificate=true;";

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(ConnStr))

                {
                    conn.Open();


                    const string sql = @"
INSERT INTO titulos
    (datalancamento, descricao, observacoes, codigoconta, conta, datavencimento,
     valor, doc, parcela, formapagamento, boleto, servico, tipolancamento)
VALUES
    (NOW(), @descricao, @observacoes, @codigoconta, @conta, @datavencimento,
     @valor, @doc, @parcela, @formapagamento, @boleto, @servico, @tipolancamento);";

                    using var cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("descricao", txtDescricao.Text.Trim());
                    cmd.Parameters.AddWithValue("observacoes", txtObs.Text.Trim());
                    cmd.Parameters.AddWithValue("codigoconta", long.Parse(txtCodigoConta.Text));
                    cmd.Parameters.AddWithValue("conta", cbConta.Text.Trim());
                    cmd.Parameters.AddWithValue("datavencimento", dtpVencimento.Value.Date);
                    cmd.Parameters.AddWithValue("valor", decimal.Parse(txtValor.Text));
                    cmd.Parameters.AddWithValue("doc", long.Parse(txtDoc.Text));
                    cmd.Parameters.AddWithValue("parcela", int.Parse(txtParcela.Text));
                    cmd.Parameters.AddWithValue("formapagamento", cboFormaPag.Text);
                    cmd.Parameters.AddWithValue("boleto", chkBoleto.Checked ? "Sim" : "Nao");
                    cmd.Parameters.AddWithValue("servico", chkServico.Checked ? "Sim" : "Nao");

                    string tipoLancamento = rdConfirmado.Checked ? "P" : "C";
                    cmd.Parameters.AddWithValue("tipolancamento", tipoLancamento);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lançamento incluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());   // mostra a mensagem + stack‑trace completo

            }
        }

    }
}
