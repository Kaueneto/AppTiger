namespace WinPay
{
    partial class incluirParcelado
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
            label1 = new Label();
            numUpQtde = new NumericUpDown();
            rbDiaFixo = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtvalorparcela = new TextBox();
            dgvParcelas = new DataGridView();
            button3 = new Button();
            tprazo = new NumericUpDown();
            tdiafixo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUpQtde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tprazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tdiafixo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de parcelas";
            // 
            // numUpQtde
            // 
            numUpQtde.Location = new Point(12, 27);
            numUpQtde.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpQtde.Name = "numUpQtde";
            numUpQtde.Size = new Size(98, 23);
            numUpQtde.TabIndex = 2;
            numUpQtde.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUpQtde.ValueChanged += numUpQtde_ValueChanged;
            // 
            // rbDiaFixo
            // 
            rbDiaFixo.AutoSize = true;
            rbDiaFixo.Location = new Point(288, 2);
            rbDiaFixo.Name = "rbDiaFixo";
            rbDiaFixo.Size = new Size(161, 19);
            rbDiaFixo.TabIndex = 3;
            rbDiaFixo.TabStop = true;
            rbDiaFixo.Text = "Vencimentos com dia fixo";
            rbDiaFixo.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(451, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(136, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Prazo de vencimento";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(593, 27);
            button1.Name = "button1";
            button1.Size = new Size(84, 29);
            button1.TabIndex = 6;
            button1.Text = "Avançar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 258);
            button2.Name = "button2";
            button2.Size = new Size(84, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 8;
            label2.Text = "Valor das parcelas";
            // 
            // txtvalorparcela
            // 
            txtvalorparcela.BorderStyle = BorderStyle.FixedSingle;
            txtvalorparcela.Location = new Point(127, 27);
            txtvalorparcela.Name = "txtvalorparcela";
            txtvalorparcela.Size = new Size(155, 23);
            txtvalorparcela.TabIndex = 9;
            // 
            // dgvParcelas
            // 
            dgvParcelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvParcelas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParcelas.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParcelas.Location = new Point(12, 102);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(665, 150);
            dgvParcelas.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(593, 258);
            button3.Name = "button3";
            button3.Size = new Size(84, 29);
            button3.TabIndex = 11;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tprazo
            // 
            tprazo.Location = new Point(451, 27);
            tprazo.Name = "tprazo";
            tprazo.Size = new Size(98, 23);
            tprazo.TabIndex = 12;
            // 
            // tdiafixo
            // 
            tdiafixo.Location = new Point(295, 27);
            tdiafixo.Name = "tdiafixo";
            tdiafixo.Size = new Size(98, 23);
            tdiafixo.TabIndex = 13;
            // 
            // incluirParcelado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(689, 299);
            Controls.Add(tdiafixo);
            Controls.Add(tprazo);
            Controls.Add(button3);
            Controls.Add(dgvParcelas);
            Controls.Add(txtvalorparcela);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(rbDiaFixo);
            Controls.Add(numUpQtde);
            Controls.Add(label1);
            Name = "incluirParcelado";
            Text = "Incluir Multiplas parcelas do lançamento";
            Load += incluirParcelado_Load;
            ((System.ComponentModel.ISupportInitialize)numUpQtde).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tprazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tdiafixo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numUpQtde;
        private RadioButton rbDiaFixo;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtvalorparcela;
        private DataGridView dgvParcelas;
        private Button button3;
        private NumericUpDown tprazo;
        private NumericUpDown tdiafixo;
    }
}