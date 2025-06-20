namespace WinPay
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
            menuStrip1 = new MenuStrip();
            lançamentosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarContaDébitoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lançamentosToolStripMenuItem, cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(657, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lançamentosToolStripMenuItem
            // 
            lançamentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, gerenciarToolStripMenuItem });
            lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            lançamentosToolStripMenuItem.Size = new Size(90, 20);
            lançamentosToolStripMenuItem.Text = "Lançamentos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(124, 22);
            incluirToolStripMenuItem.Text = "Incluir";
            incluirToolStripMenuItem.Click += incluirToolStripMenuItem_Click;
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(124, 22);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarContaDébitoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarContaDébitoToolStripMenuItem
            // 
            cadastrarContaDébitoToolStripMenuItem.Name = "cadastrarContaDébitoToolStripMenuItem";
            cadastrarContaDébitoToolStripMenuItem.Size = new Size(194, 22);
            cadastrarContaDébitoToolStripMenuItem.Text = "Cadastrar conta débito";
            cadastrarContaDébitoToolStripMenuItem.Click += cadastrarContaDébitoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 298);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lançamentosToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarContaDébitoToolStripMenuItem;
    }
}
