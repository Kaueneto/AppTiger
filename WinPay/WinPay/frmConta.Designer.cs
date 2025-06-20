namespace WinPay
{
    partial class frmConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvcontas = new DataGridView();
            btdelete = new Button();
            btpesquisa = new Button();
            txtDescricaoconta = new TextBox();
            label2 = new Label();
            txtodigoconta = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvdois = new DataGridView();
            btexcluir = new Button();
            btcadastro = new Button();
            txtdesc = new TextBox();
            label3 = new Label();
            txtcod = new TextBox();
            label4 = new Label();
            btclose = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcontas).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdois).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvcontas);
            tabPage1.Controls.Add(btdelete);
            tabPage1.Controls.Add(btpesquisa);
            tabPage1.Controls.Add(txtDescricaoconta);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtodigoconta);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(376, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvcontas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvcontas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvcontas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvcontas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvcontas.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvcontas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcontas.Location = new Point(16, 133);
            dgvcontas.Name = "dgvcontas";
            dgvcontas.Size = new Size(342, 118);
            dgvcontas.TabIndex = 7;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(6, 257);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(75, 29);
            btdelete.TabIndex = 6;
            btdelete.Text = "Excluir";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // btpesquisa
            // 
            btpesquisa.Location = new Point(283, 94);
            btpesquisa.Name = "btpesquisa";
            btpesquisa.Size = new Size(75, 29);
            btpesquisa.TabIndex = 4;
            btpesquisa.Text = "Pesquisar";
            btpesquisa.UseVisualStyleBackColor = true;
            btpesquisa.Click += btpesquisa_Click;
            // 
            // txtDescricaoconta
            // 
            txtDescricaoconta.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoconta.Location = new Point(16, 65);
            txtDescricaoconta.Name = "txtDescricaoconta";
            txtDescricaoconta.Size = new Size(342, 23);
            txtDescricaoconta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // txtodigoconta
            // 
            txtodigoconta.BorderStyle = BorderStyle.FixedSingle;
            txtodigoconta.Location = new Point(16, 21);
            txtodigoconta.Name = "txtodigoconta";
            txtodigoconta.Size = new Size(95, 23);
            txtodigoconta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 3);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvdois);
            tabPage2.Controls.Add(btexcluir);
            tabPage2.Controls.Add(btcadastro);
            tabPage2.Controls.Add(txtdesc);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtcod);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(376, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdois
            // 
            dgvdois.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdois.Location = new Point(17, 129);
            dgvdois.Name = "dgvdois";
            dgvdois.Size = new Size(342, 118);
            dgvdois.TabIndex = 11;
            // 
            // btexcluir
            // 
            btexcluir.Location = new Point(7, 253);
            btexcluir.Name = "btexcluir";
            btexcluir.Size = new Size(75, 29);
            btexcluir.TabIndex = 10;
            btexcluir.Text = "Excluir";
            btexcluir.UseVisualStyleBackColor = true;
            btexcluir.Click += btexcluir_Click;
            // 
            // btcadastro
            // 
            btcadastro.Location = new Point(284, 94);
            btcadastro.Name = "btcadastro";
            btcadastro.Size = new Size(75, 29);
            btcadastro.TabIndex = 9;
            btcadastro.Text = "Cadastrar";
            btcadastro.UseVisualStyleBackColor = true;
            btcadastro.Click += btcadastro_Click;
            // 
            // txtdesc
            // 
            txtdesc.BorderStyle = BorderStyle.FixedSingle;
            txtdesc.Location = new Point(17, 65);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(342, 23);
            txtdesc.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 47);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Descrição";
            // 
            // txtcod
            // 
            txtcod.BorderStyle = BorderStyle.FixedSingle;
            txtcod.Location = new Point(17, 21);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(95, 23);
            txtcod.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 3);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Código";
            // 
            // btclose
            // 
            btclose.Location = new Point(317, 334);
            btclose.Name = "btclose";
            btclose.Size = new Size(75, 29);
            btclose.TabIndex = 5;
            btclose.Text = "Fechar";
            btclose.UseVisualStyleBackColor = true;
            btclose.Click += btclose_Click;
            // 
            // frmConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 370);
            Controls.Add(btclose);
            Controls.Add(tabControl1);
            Name = "frmConta";
            Text = "Cadastrar conta débito";
            Load += frmConta_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcontas).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdois).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvcontas;
        private Button btdelete;
        private Button btpesquisa;
        private TextBox txtDescricaoconta;
        private Label label2;
        private TextBox txtodigoconta;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dgvdois;
        private Button btexcluir;
        private Button btcadastro;
        private TextBox txtdesc;
        private Label label3;
        private TextBox txtcod;
        private Label label4;
        private Button btclose;
    }
}