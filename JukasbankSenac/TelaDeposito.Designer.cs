namespace JukasbankSenac
{
    partial class TelaDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeposito));
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblDeposito = new Label();
            txtIdentificacao = new TextBox();
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            txtAgencia = new TextBox();
            lblDepositoConfirmado = new Label();
            lblValorDeposito = new Label();
            btConfirmarDeposito = new Button();
            txtValorDeposito = new TextBox();
            SuspendLayout();
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.BackColor = Color.Transparent;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.White;
            lblSaldoVal.Location = new Point(187, 92);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 14;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(91, 92);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 13;
            lblSaldo.Text = "Saldo:";
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.BackColor = Color.Transparent;
            lblDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposito.ForeColor = Color.White;
            lblDeposito.Location = new Point(447, 9);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(125, 37);
            lblDeposito.TabIndex = 12;
            lblDeposito.Text = "Depósito";
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.BackColor = Color.White;
            txtIdentificacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacao.Location = new Point(145, 380);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.PlaceholderText = "Quem está depositando?";
            txtIdentificacao.Size = new Size(300, 29);
            txtIdentificacao.TabIndex = 4;
            txtIdentificacao.TextAlign = HorizontalAlignment.Center;
            txtIdentificacao.Visible = false;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(145, 307);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "Nome do beneficiário";
            txtNomeDestino.Size = new Size(300, 29);
            txtNomeDestino.TabIndex = 3;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            txtNomeDestino.Visible = false;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(145, 234);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Número da conta destino";
            txtNumConta.Size = new Size(300, 29);
            txtNumConta.TabIndex = 2;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            txtNumConta.Visible = false;
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = Color.White;
            txtAgencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgencia.Location = new Point(145, 162);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.PlaceholderText = "Digite a agência de destino";
            txtAgencia.Size = new Size(300, 29);
            txtAgencia.TabIndex = 1;
            txtAgencia.TextAlign = HorizontalAlignment.Center;
            txtAgencia.Visible = false;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.BackColor = Color.Transparent;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.White;
            lblDepositoConfirmado.Location = new Point(654, 452);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(249, 37);
            lblDepositoConfirmado.TabIndex = 24;
            lblDepositoConfirmado.Text = "Depósito realizado!";
            lblDepositoConfirmado.Click += lblDepositoConfirmado_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.BackColor = Color.Transparent;
            lblValorDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.White;
            lblValorDeposito.Location = new Point(617, 96);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(315, 37);
            lblValorDeposito.TabIndex = 21;
            lblValorDeposito.Text = "Insira o valor a depositar:";
            lblValorDeposito.Click += lblValorDeposito_Click;
            // 
            // btConfirmarDeposito
            // 
            btConfirmarDeposito.BackColor = Color.Crimson;
            btConfirmarDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarDeposito.ForeColor = Color.White;
            btConfirmarDeposito.Location = new Point(632, 401);
            btConfirmarDeposito.Name = "btConfirmarDeposito";
            btConfirmarDeposito.Size = new Size(300, 48);
            btConfirmarDeposito.TabIndex = 6;
            btConfirmarDeposito.Text = "Confirmar depósito";
            btConfirmarDeposito.UseVisualStyleBackColor = false;
            btConfirmarDeposito.Click += btConfirmarDeposito_Click;
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.White;
            txtValorDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.Location = new Point(632, 162);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "R$ 0,00";
            txtValorDeposito.Size = new Size(300, 43);
            txtValorDeposito.TabIndex = 5;
            txtValorDeposito.TextAlign = HorizontalAlignment.Center;
            txtValorDeposito.TextChanged += txtValorDeposito_TextChanged;
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1043, 526);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(btConfirmarDeposito);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(txtIdentificacao);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(txtAgencia);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblDeposito);
            Name = "TelaDeposito";
            Text = "TelaDeposito";
            Load += Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblDeposito;
        private TextBox txtIdentificacao;
        private TextBox txtNomeDestino;
        private TextBox txtNumConta;
        private TextBox txtAgencia;
        private Label lblDepositoConfirmado;
        private Label lblValorDeposito;
        private Button btConfirmarDeposito;
        private TextBox txtValorDeposito;
    }
}