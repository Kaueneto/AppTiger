namespace Apptiger
{
    partial class Incluir
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
            txtDescricao = new TextBox();
            groupBox1 = new GroupBox();
            rdPrevisao = new RadioButton();
            rdConfirmado = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtCodigoConta = new TextBox();
            label3 = new Label();
            cbConta = new ComboBox();
            button1 = new Button();
            txtValor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpVencimento = new DateTimePicker();
            cboFormaPag = new ComboBox();
            button2 = new Button();
            label6 = new Label();
            txtDoc = new TextBox();
            label7 = new Label();
            txtParcela = new TextBox();
            chkBoleto = new CheckBox();
            chkServico = new CheckBox();
            txtObs = new TextBox();
            label8 = new Label();
            btConfirmarLancamento = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Location = new Point(27, 80);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(608, 23);
            txtDescricao.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdPrevisao);
            groupBox1.Controls.Add(rdConfirmado);
            groupBox1.Location = new Point(27, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 58);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo lançamento";
            // 
            // rdPrevisao
            // 
            rdPrevisao.AutoSize = true;
            rdPrevisao.Location = new Point(113, 20);
            rdPrevisao.Name = "rdPrevisao";
            rdPrevisao.Size = new Size(69, 19);
            rdPrevisao.TabIndex = 1;
            rdPrevisao.TabStop = true;
            rdPrevisao.Text = "Previsão";
            rdPrevisao.UseVisualStyleBackColor = true;
            rdPrevisao.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdConfirmado
            // 
            rdConfirmado.AutoSize = true;
            rdConfirmado.Location = new Point(9, 22);
            rdConfirmado.Name = "rdConfirmado";
            rdConfirmado.Size = new Size(89, 19);
            rdConfirmado.TabIndex = 0;
            rdConfirmado.TabStop = true;
            rdConfirmado.Text = "Confirmado";
            rdConfirmado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSlateGray;
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(-25, -27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(973, 75);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 41);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 0;
            label2.Text = "Incluir lançamento ";
            // 
            // txtCodigoConta
            // 
            txtCodigoConta.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoConta.Location = new Point(27, 248);
            txtCodigoConta.Name = "txtCodigoConta";
            txtCodigoConta.Size = new Size(98, 23);
            txtCodigoConta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 230);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Conta";
            label3.Click += label3_Click;
            // 
            // cbConta
            // 
            cbConta.FormattingEnabled = true;
            cbConta.Location = new Point(160, 248);
            cbConta.Name = "cbConta";
            cbConta.Size = new Size(475, 23);
            cbConta.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(131, 248);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 7;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Location = new Point(233, 174);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(118, 23);
            txtValor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 156);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 156);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 10;
            label5.Text = "Data vencimento";
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.Location = new Point(357, 174);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(110, 23);
            dtpVencimento.TabIndex = 11;
            // 
            // cboFormaPag
            // 
            cboFormaPag.FormattingEnabled = true;
            cboFormaPag.Location = new Point(27, 304);
            cboFormaPag.Name = "cboFormaPag";
            cboFormaPag.Size = new Size(224, 23);
            cboFormaPag.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(257, 304);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 13;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 286);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 14;
            label6.Text = "Forma de pagamento";
            // 
            // txtDoc
            // 
            txtDoc.BorderStyle = BorderStyle.FixedSingle;
            txtDoc.Location = new Point(473, 174);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(118, 23);
            txtDoc.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 156);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 15;
            label7.Text = "DOC.";
            // 
            // txtParcela
            // 
            txtParcela.BorderStyle = BorderStyle.FixedSingle;
            txtParcela.Location = new Point(597, 174);
            txtParcela.Name = "txtParcela";
            txtParcela.Size = new Size(41, 23);
            txtParcela.TabIndex = 17;
            // 
            // chkBoleto
            // 
            chkBoleto.AutoSize = true;
            chkBoleto.Location = new Point(504, 54);
            chkBoleto.Name = "chkBoleto";
            chkBoleto.Size = new Size(60, 19);
            chkBoleto.TabIndex = 18;
            chkBoleto.Text = "Boleto";
            chkBoleto.UseVisualStyleBackColor = true;
            // 
            // chkServico
            // 
            chkServico.AutoSize = true;
            chkServico.Location = new Point(570, 54);
            chkServico.Name = "chkServico";
            chkServico.Size = new Size(64, 19);
            chkServico.TabIndex = 19;
            chkServico.Text = "Serviço";
            chkServico.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            txtObs.BorderStyle = BorderStyle.FixedSingle;
            txtObs.Location = new Point(27, 128);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(607, 23);
            txtObs.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 110);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 20;
            label8.Text = "Observações";
            // 
            // btConfirmarLancamento
            // 
            btConfirmarLancamento.Location = new Point(540, 374);
            btConfirmarLancamento.Name = "btConfirmarLancamento";
            btConfirmarLancamento.Size = new Size(94, 29);
            btConfirmarLancamento.TabIndex = 22;
            btConfirmarLancamento.Text = "Confirmar";
            btConfirmarLancamento.UseVisualStyleBackColor = true;
            btConfirmarLancamento.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(27, 374);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 23;
            button4.Text = "Fechar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(127, 374);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 24;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = true;
            // 
            // Incluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btConfirmarLancamento);
            Controls.Add(txtObs);
            Controls.Add(label8);
            Controls.Add(chkServico);
            Controls.Add(chkBoleto);
            Controls.Add(txtParcela);
            Controls.Add(txtDoc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(cboFormaPag);
            Controls.Add(dtpVencimento);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cbConta);
            Controls.Add(txtCodigoConta);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Name = "Incluir";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescricao;
        private GroupBox groupBox1;
        private RadioButton rdPrevisao;
        private RadioButton rdConfirmado;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtCodigoConta;
        private Label label3;
        private ComboBox cbConta;
        private Button button1;
        private TextBox txtValor;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpVencimento;
        private ComboBox cboFormaPag;
        private Button button2;
        private Label label6;
        private TextBox txtDoc;
        private Label label7;
        private TextBox txtParcela;
        private CheckBox chkBoleto;
        private CheckBox chkServico;
        private TextBox txtObs;
        private Label label8;
        private Button btConfirmarLancamento;
        private Button button4;
        private Button button5;
    }
}