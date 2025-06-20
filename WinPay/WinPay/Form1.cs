using System;
using System.Windows.Forms;

namespace WinPay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // abre a conexão uma única vez
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Db.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // fecha ao sair do app
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Db.Fechar();
        }

        // menus abrem forms modais, sem criar novas conexões
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new frmIncluir();
            frm.ShowDialog(this);
        }

        private void cadastrarContaDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new frmConta();
            frm.ShowDialog(this);
        }
    }
}
