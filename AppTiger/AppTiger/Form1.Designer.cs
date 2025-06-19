namespace AppTiger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lançamentosToolStripMenuItem = new ToolStripMenuItem();
            incluirTituloAPagarToolStripMenuItem = new ToolStripMenuItem();
            gerenciarContasAPagarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            lançamentosToolStripMenuItem1 = new ToolStripMenuItem();
            incluirLançamentoContasAPagarToolStripMenuItem = new ToolStripMenuItem();
            consultarAlterarContasAPagarToolStripMenuItem = new ToolStripMenuItem();
            pagamentosRealizadosToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarContaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFormaDePagametnopagamentoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCarteiraToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { lançamentosToolStripMenuItem, incluirTituloAPagarToolStripMenuItem, gerenciarContasAPagarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(205, 70);
            // 
            // lançamentosToolStripMenuItem
            // 
            lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            lançamentosToolStripMenuItem.Size = new Size(204, 22);
            lançamentosToolStripMenuItem.Text = "Lançamentos";
            // 
            // incluirTituloAPagarToolStripMenuItem
            // 
            incluirTituloAPagarToolStripMenuItem.Name = "incluirTituloAPagarToolStripMenuItem";
            incluirTituloAPagarToolStripMenuItem.Size = new Size(204, 22);
            incluirTituloAPagarToolStripMenuItem.Text = "Incluir Titulo a pagar";
            // 
            // gerenciarContasAPagarToolStripMenuItem
            // 
            gerenciarContasAPagarToolStripMenuItem.Name = "gerenciarContasAPagarToolStripMenuItem";
            gerenciarContasAPagarToolStripMenuItem.Size = new Size(204, 22);
            gerenciarContasAPagarToolStripMenuItem.Text = "Gerenciar contas a pagar";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lançamentosToolStripMenuItem1, cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // lançamentosToolStripMenuItem1
            // 
            lançamentosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { incluirLançamentoContasAPagarToolStripMenuItem, consultarAlterarContasAPagarToolStripMenuItem, pagamentosRealizadosToolStripMenuItem });
            lançamentosToolStripMenuItem1.Name = "lançamentosToolStripMenuItem1";
            lançamentosToolStripMenuItem1.Size = new Size(90, 20);
            lançamentosToolStripMenuItem1.Text = "Lançamentos";
            // 
            // incluirLançamentoContasAPagarToolStripMenuItem
            // 
            incluirLançamentoContasAPagarToolStripMenuItem.Name = "incluirLançamentoContasAPagarToolStripMenuItem";
            incluirLançamentoContasAPagarToolStripMenuItem.Size = new Size(253, 22);
            incluirLançamentoContasAPagarToolStripMenuItem.Text = "Incluir lançamento contas a pagar";
            incluirLançamentoContasAPagarToolStripMenuItem.Click += incluirLançamentoContasAPagarToolStripMenuItem_Click;
            // 
            // consultarAlterarContasAPagarToolStripMenuItem
            // 
            consultarAlterarContasAPagarToolStripMenuItem.Name = "consultarAlterarContasAPagarToolStripMenuItem";
            consultarAlterarContasAPagarToolStripMenuItem.Size = new Size(253, 22);
            consultarAlterarContasAPagarToolStripMenuItem.Text = "Gerenciar/Consultar";
            consultarAlterarContasAPagarToolStripMenuItem.Click += consultarAlterarContasAPagarToolStripMenuItem_Click;
            // 
            // pagamentosRealizadosToolStripMenuItem
            // 
            pagamentosRealizadosToolStripMenuItem.Name = "pagamentosRealizadosToolStripMenuItem";
            pagamentosRealizadosToolStripMenuItem.Size = new Size(253, 22);
            pagamentosRealizadosToolStripMenuItem.Text = "Pagamentos realizados";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarContaToolStripMenuItem, cadastrarFormaDePagametnopagamentoToolStripMenuItem, cadastrarCarteiraToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarContaToolStripMenuItem
            // 
            cadastrarContaToolStripMenuItem.Name = "cadastrarContaToolStripMenuItem";
            cadastrarContaToolStripMenuItem.Size = new Size(239, 22);
            cadastrarContaToolStripMenuItem.Text = "Cadastrar conta";
            // 
            // cadastrarFormaDePagametnopagamentoToolStripMenuItem
            // 
            cadastrarFormaDePagametnopagamentoToolStripMenuItem.Name = "cadastrarFormaDePagametnopagamentoToolStripMenuItem";
            cadastrarFormaDePagametnopagamentoToolStripMenuItem.Size = new Size(239, 22);
            cadastrarFormaDePagametnopagamentoToolStripMenuItem.Text = "Cadastrar forma de pagamento";
            cadastrarFormaDePagametnopagamentoToolStripMenuItem.Click += cadastrarFormaDePagametnopagamentoToolStripMenuItem_Click;
            // 
            // cadastrarCarteiraToolStripMenuItem
            // 
            cadastrarCarteiraToolStripMenuItem.Name = "cadastrarCarteiraToolStripMenuItem";
            cadastrarCarteiraToolStripMenuItem.Size = new Size(239, 22);
            cadastrarCarteiraToolStripMenuItem.Text = "Carteiras/Bancos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem lançamentosToolStripMenuItem;
        private ToolStripMenuItem incluirTituloAPagarToolStripMenuItem;
        private ToolStripMenuItem gerenciarContasAPagarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lançamentosToolStripMenuItem1;
        private ToolStripMenuItem incluirLançamentoContasAPagarToolStripMenuItem;
        private ToolStripMenuItem consultarAlterarContasAPagarToolStripMenuItem;
        private ToolStripMenuItem pagamentosRealizadosToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarContaToolStripMenuItem;
        private ToolStripMenuItem cadastrarFormaDePagametnopagamentoToolStripMenuItem;
        private ToolStripMenuItem cadastrarCarteiraToolStripMenuItem;
    }
}
