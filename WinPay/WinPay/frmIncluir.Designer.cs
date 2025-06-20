namespace WinPay
{
    partial class frmIncluir
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
            txtdescricao = new TextBox();
            txthistorico = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtvencimento = new DateTimePicker();
            txtdoc = new TextBox();
            label5 = new Label();
            txtParcela = new TextBox();
            radioConfirmado = new RadioButton();
            radioPrevisao = new RadioButton();
            label6 = new Label();
            cboxformapagamento = new ComboBox();
            txtcod = new TextBox();
            txtcodconta = new Label();
            btDetalheContas = new Button();
            cboxContas = new ComboBox();
            btnIncluir = new Button();
            checkboleto = new CheckBox();
            checkServico = new CheckBox();
            btclose = new Button();
            button1 = new Button();
            btnLancarParcelado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 6;
            label1.Text = "Descricao lançamento";
            // 
            // txtdescricao
            // 
            txtdescricao.BorderStyle = BorderStyle.FixedSingle;
            txtdescricao.Location = new Point(12, 55);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(495, 23);
            txtdescricao.TabIndex = 1;
            // 
            // txthistorico
            // 
            txthistorico.BorderStyle = BorderStyle.FixedSingle;
            txthistorico.Location = new Point(12, 212);
            txthistorico.Name = "txthistorico";
            txthistorico.Size = new Size(495, 23);
            txthistorico.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Historico";
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Location = new Point(12, 107);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(134, 23);
            txtValor.TabIndex = 2;
            txtValor.TextChanged += txtValor_TextChanged;
            txtValor.Leave += txtValor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 89);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Vencimento";
            // 
            // txtvencimento
            // 
            txtvencimento.Format = DateTimePickerFormat.Short;
            txtvencimento.Location = new Point(157, 107);
            txtvencimento.Name = "txtvencimento";
            txtvencimento.Size = new Size(109, 23);
            txtvencimento.TabIndex = 3;
            // 
            // txtdoc
            // 
            txtdoc.BorderStyle = BorderStyle.FixedSingle;
            txtdoc.Location = new Point(272, 107);
            txtdoc.Name = "txtdoc";
            txtdoc.Size = new Size(134, 23);
            txtdoc.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 89);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Doc.";
            // 
            // txtParcela
            // 
            txtParcela.BorderStyle = BorderStyle.FixedSingle;
            txtParcela.Location = new Point(412, 107);
            txtParcela.Name = "txtParcela";
            txtParcela.Size = new Size(39, 23);
            txtParcela.TabIndex = 9;
            // 
            // radioConfirmado
            // 
            radioConfirmado.AutoSize = true;
            radioConfirmado.Location = new Point(343, 12);
            radioConfirmado.Name = "radioConfirmado";
            radioConfirmado.Size = new Size(89, 19);
            radioConfirmado.TabIndex = 11;
            radioConfirmado.TabStop = true;
            radioConfirmado.Text = "Confirmado";
            radioConfirmado.UseVisualStyleBackColor = true;
            // 
            // radioPrevisao
            // 
            radioPrevisao.AutoSize = true;
            radioPrevisao.Location = new Point(438, 12);
            radioPrevisao.Name = "radioPrevisao";
            radioPrevisao.Size = new Size(69, 19);
            radioPrevisao.TabIndex = 12;
            radioPrevisao.TabStop = true;
            radioPrevisao.Text = "Previsão";
            radioPrevisao.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 248);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 13;
            label6.Text = "Forma de pagamento";
            // 
            // cboxformapagamento
            // 
            cboxformapagamento.FormattingEnabled = true;
            cboxformapagamento.Location = new Point(15, 266);
            cboxformapagamento.Name = "cboxformapagamento";
            cboxformapagamento.Size = new Size(157, 23);
            cboxformapagamento.TabIndex = 7;
            // 
            // txtcod
            // 
            txtcod.BorderStyle = BorderStyle.FixedSingle;
            txtcod.Location = new Point(12, 167);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(81, 23);
            txtcod.TabIndex = 4;
            txtcod.Leave += txtcod_Leave;
            // 
            // txtcodconta
            // 
            txtcodconta.AutoSize = true;
            txtcodconta.Location = new Point(12, 149);
            txtcodconta.Name = "txtcodconta";
            txtcodconta.Size = new Size(39, 15);
            txtcodconta.TabIndex = 15;
            txtcodconta.Text = "Conta";
            // 
            // btDetalheContas
            // 
            btDetalheContas.Location = new Point(97, 166);
            btDetalheContas.Name = "btDetalheContas";
            btDetalheContas.Size = new Size(36, 23);
            btDetalheContas.TabIndex = 17;
            btDetalheContas.Text = "...";
            btDetalheContas.UseVisualStyleBackColor = true;
            btDetalheContas.Click += btDetalheContas_Click;
            // 
            // cboxContas
            // 
            cboxContas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxContas.FormattingEnabled = true;
            cboxContas.Location = new Point(139, 166);
            cboxContas.Name = "cboxContas";
            cboxContas.Size = new Size(368, 23);
            cboxContas.TabIndex = 5;
            cboxContas.SelectedIndexChanged += cboxContas_SelectedIndexChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(416, 321);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(91, 26);
            btnIncluir.TabIndex = 10;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // checkboleto
            // 
            checkboleto.AutoSize = true;
            checkboleto.Location = new Point(206, 13);
            checkboleto.Name = "checkboleto";
            checkboleto.Size = new Size(60, 19);
            checkboleto.TabIndex = 20;
            checkboleto.Text = "boleto";
            checkboleto.UseVisualStyleBackColor = true;
            // 
            // checkServico
            // 
            checkServico.AutoSize = true;
            checkServico.Location = new Point(272, 13);
            checkServico.Name = "checkServico";
            checkServico.Size = new Size(64, 19);
            checkServico.TabIndex = 21;
            checkServico.Text = "Serviço";
            checkServico.UseVisualStyleBackColor = true;
            // 
            // btclose
            // 
            btclose.Location = new Point(15, 321);
            btclose.Name = "btclose";
            btclose.Size = new Size(91, 26);
            btclose.TabIndex = 22;
            btclose.Text = "Fechar";
            btclose.UseVisualStyleBackColor = true;
            btclose.Click += btclose_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 321);
            button1.Name = "button1";
            button1.Size = new Size(91, 26);
            button1.TabIndex = 23;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLancarParcelado
            // 
            btnLancarParcelado.Location = new Point(272, 321);
            btnLancarParcelado.Name = "btnLancarParcelado";
            btnLancarParcelado.Size = new Size(134, 26);
            btnLancarParcelado.TabIndex = 24;
            btnLancarParcelado.Text = "Incluir parcelado";
            btnLancarParcelado.UseVisualStyleBackColor = true;
            btnLancarParcelado.Click += btnLancarParcelado_Click;
            // 
            // frmIncluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 359);
            Controls.Add(btnLancarParcelado);
            Controls.Add(button1);
            Controls.Add(btclose);
            Controls.Add(checkServico);
            Controls.Add(checkboleto);
            Controls.Add(btnIncluir);
            Controls.Add(cboxContas);
            Controls.Add(btDetalheContas);
            Controls.Add(txtcod);
            Controls.Add(txtcodconta);
            Controls.Add(cboxformapagamento);
            Controls.Add(label6);
            Controls.Add(radioPrevisao);
            Controls.Add(radioConfirmado);
            Controls.Add(txtParcela);
            Controls.Add(txtdoc);
            Controls.Add(label5);
            Controls.Add(txtvencimento);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txthistorico);
            Controls.Add(label2);
            Controls.Add(txtdescricao);
            Controls.Add(label1);
            Name = "frmIncluir";
            Text = "frmIncluir";
            Load += frmIncluir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtdescricao;
        private TextBox txthistorico;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private Label label4;
        private DateTimePicker txtvencimento;
        private TextBox txtdoc;
        private Label label5;
        private TextBox txtParcela;
        private RadioButton radioConfirmado;
        private RadioButton radioPrevisao;
        private Label label6;
        private ComboBox cboxformapagamento;
        private TextBox txtcod;
        private Label txtcodconta;
        private Button btDetalheContas;
        private ComboBox cboxContas;
        private Button btnIncluir;
        private CheckBox checkboleto;
        private CheckBox checkServico;
        private Button btclose;
        private Button button1;
        private Button btnLancarParcelado;
    }
}