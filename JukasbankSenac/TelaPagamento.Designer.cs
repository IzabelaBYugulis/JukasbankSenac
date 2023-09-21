namespace JukasbankSenac
{
    partial class TelaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            txtIdentificacaoPag = new TextBox();
            txtNomeDestinoPag = new TextBox();
            txtNumContaPag = new TextBox();
            txtCodBarrasPag = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblPagamento = new Label();
            lblPagamentoConfirmado = new Label();
            btConfirmarPagamento = new Button();
            lblValorPagamento = new Label();
            txtValorPagamento = new TextBox();
            SuspendLayout();
            // 
            // txtIdentificacaoPag
            // 
            txtIdentificacaoPag.BackColor = Color.White;
            txtIdentificacaoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacaoPag.Location = new Point(74, 334);
            txtIdentificacaoPag.Name = "txtIdentificacaoPag";
            txtIdentificacaoPag.PlaceholderText = "Quem está depositando?";
            txtIdentificacaoPag.Size = new Size(379, 29);
            txtIdentificacaoPag.TabIndex = 4;
            txtIdentificacaoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestinoPag
            // 
            txtNomeDestinoPag.BackColor = Color.White;
            txtNomeDestinoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestinoPag.Location = new Point(74, 288);
            txtNomeDestinoPag.Name = "txtNomeDestinoPag";
            txtNomeDestinoPag.PlaceholderText = "Nome do beneficiário";
            txtNomeDestinoPag.Size = new Size(379, 29);
            txtNomeDestinoPag.TabIndex = 3;
            txtNomeDestinoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumContaPag
            // 
            txtNumContaPag.BackColor = Color.White;
            txtNumContaPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumContaPag.Location = new Point(74, 244);
            txtNumContaPag.Name = "txtNumContaPag";
            txtNumContaPag.PlaceholderText = "Número da conta destino";
            txtNumContaPag.Size = new Size(379, 29);
            txtNumContaPag.TabIndex = 2;
            txtNumContaPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarrasPag
            // 
            txtCodBarrasPag.BackColor = Color.White;
            txtCodBarrasPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarrasPag.Location = new Point(74, 193);
            txtCodBarrasPag.Name = "txtCodBarrasPag";
            txtCodBarrasPag.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarrasPag.Size = new Size(379, 29);
            txtCodBarrasPag.TabIndex = 1;
            txtCodBarrasPag.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.BackColor = Color.Transparent;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = SystemColors.ButtonHighlight;
            lblSaldoVal.Location = new Point(156, 104);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 21;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = SystemColors.ButtonHighlight;
            lblSaldo.Location = new Point(74, 104);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 20;
            lblSaldo.Text = "Saldo:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.BackColor = Color.Transparent;
            lblPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamento.ForeColor = SystemColors.ButtonHighlight;
            lblPagamento.Location = new Point(390, 9);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(163, 37);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamentos";
            // 
            // lblPagamentoConfirmado
            // 
            lblPagamentoConfirmado.AutoSize = true;
            lblPagamentoConfirmado.BackColor = Color.Transparent;
            lblPagamentoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamentoConfirmado.ForeColor = SystemColors.ButtonHighlight;
            lblPagamentoConfirmado.Location = new Point(589, 428);
            lblPagamentoConfirmado.Name = "lblPagamentoConfirmado";
            lblPagamentoConfirmado.Size = new Size(276, 37);
            lblPagamentoConfirmado.TabIndex = 30;
            lblPagamentoConfirmado.Text = "Pagamento realizado!";
            // 
            // btConfirmarPagamento
            // 
            btConfirmarPagamento.BackColor = Color.Crimson;
            btConfirmarPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarPagamento.ForeColor = Color.White;
            btConfirmarPagamento.Location = new Point(563, 334);
            btConfirmarPagamento.Name = "btConfirmarPagamento";
            btConfirmarPagamento.Size = new Size(300, 48);
            btConfirmarPagamento.TabIndex = 6;
            btConfirmarPagamento.Text = "Confirmar Pagamento";
            btConfirmarPagamento.UseVisualStyleBackColor = false;
            // 
            // lblValorPagamento
            // 
            lblValorPagamento.AutoSize = true;
            lblValorPagamento.BackColor = Color.Transparent;
            lblValorPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPagamento.ForeColor = SystemColors.ButtonHighlight;
            lblValorPagamento.Location = new Point(575, 104);
            lblValorPagamento.Name = "lblValorPagamento";
            lblValorPagamento.Size = new Size(272, 37);
            lblValorPagamento.TabIndex = 29;
            lblValorPagamento.Text = "Insira o valor a pagar:";
            // 
            // txtValorPagamento
            // 
            txtValorPagamento.BackColor = Color.White;
            txtValorPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPagamento.Location = new Point(565, 193);
            txtValorPagamento.Name = "txtValorPagamento";
            txtValorPagamento.PlaceholderText = "R$ 0,00";
            txtValorPagamento.Size = new Size(300, 43);
            txtValorPagamento.TabIndex = 5;
            txtValorPagamento.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(928, 559);
            Controls.Add(lblPagamentoConfirmado);
            Controls.Add(btConfirmarPagamento);
            Controls.Add(lblValorPagamento);
            Controls.Add(txtValorPagamento);
            Controls.Add(txtIdentificacaoPag);
            Controls.Add(txtNomeDestinoPag);
            Controls.Add(txtNumContaPag);
            Controls.Add(txtCodBarrasPag);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacaoPag;
        private TextBox txtNomeDestinoPag;
        private TextBox txtNumContaPag;
        private TextBox txtCodBarrasPag;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblPagamento;
        private Label lblPagamentoConfirmado;
        private Button btConfirmarPagamento;
        private Label lblValorPagamento;
        private TextBox txtValorPagamento;
    }
}