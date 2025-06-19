namespace Apptiger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void consultarAlterarContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarFormaDePagametnopagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void incluirLançamentoContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o form "Incluir" de modo modal
            using (var f = new Incluir())
            {
                var result = f.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    // aqui virá a lógica de pós‑gravação
                }
            }
        }
    }   //  fecha a classe Form1
}      
