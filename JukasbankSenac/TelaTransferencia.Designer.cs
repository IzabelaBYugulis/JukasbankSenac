namespace JukasbankSenac
{
    partial class TelaTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTransferencia));
            lblTransferencia = new Label();
            lblSaldoValTransf = new Label();
            lblSaldoTransf = new Label();
            txtValorTransf = new TextBox();
            txtDestinoTransf = new TextBox();
            lblTransfConfirmada = new Label();
            lblValorTransf = new Label();
            btConfirmarTransf = new Button();
            lblDestinoTransf = new Label();
            SuspendLayout();
            // 
            // lblTransferencia
            // 
            lblTransferencia.AutoSize = true;
            lblTransferencia.BackColor = Color.Transparent;
            lblTransferencia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransferencia.ForeColor = Color.Black;
            lblTransferencia.Location = new Point(231, 9);
            lblTransferencia.Name = "lblTransferencia";
            lblTransferencia.Size = new Size(171, 37);
            lblTransferencia.TabIndex = 13;
            lblTransferencia.Text = "Transferência";
            // 
            // lblSaldoValTransf
            // 
            lblSaldoValTransf.AutoSize = true;
            lblSaldoValTransf.BackColor = Color.Transparent;
            lblSaldoValTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoValTransf.ForeColor = Color.Black;
            lblSaldoValTransf.Location = new Point(316, 65);
            lblSaldoValTransf.Name = "lblSaldoValTransf";
            lblSaldoValTransf.Size = new Size(121, 37);
            lblSaldoValTransf.TabIndex = 16;
            lblSaldoValTransf.Text = "R$ 50,33";
            // 
            // lblSaldoTransf
            // 
            lblSaldoTransf.AutoSize = true;
            lblSaldoTransf.BackColor = Color.Transparent;
            lblSaldoTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoTransf.ForeColor = Color.Black;
            lblSaldoTransf.Location = new Point(220, 65);
            lblSaldoTransf.Name = "lblSaldoTransf";
            lblSaldoTransf.Size = new Size(90, 37);
            lblSaldoTransf.TabIndex = 15;
            lblSaldoTransf.Text = "Saldo:";
            // 
            // txtValorTransf
            // 
            txtValorTransf.BackColor = Color.White;
            txtValorTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTransf.Location = new Point(168, 310);
            txtValorTransf.Name = "txtValorTransf";
            txtValorTransf.PlaceholderText = "0,00";
            txtValorTransf.Size = new Size(312, 35);
            txtValorTransf.TabIndex = 2;
            txtValorTransf.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDestinoTransf
            // 
            txtDestinoTransf.BackColor = Color.White;
            txtDestinoTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestinoTransf.Location = new Point(168, 174);
            txtDestinoTransf.Name = "txtDestinoTransf";
            txtDestinoTransf.PlaceholderText = "000.000.000-00";
            txtDestinoTransf.Size = new Size(315, 35);
            txtDestinoTransf.TabIndex = 1;
            txtDestinoTransf.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTransfConfirmada
            // 
            lblTransfConfirmada.AutoSize = true;
            lblTransfConfirmada.BackColor = Color.Transparent;
            lblTransfConfirmada.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransfConfirmada.ForeColor = Color.White;
            lblTransfConfirmada.Location = new Point(178, 455);
            lblTransfConfirmada.Name = "lblTransfConfirmada";
            lblTransfConfirmada.Size = new Size(293, 37);
            lblTransfConfirmada.TabIndex = 25;
            lblTransfConfirmada.Text = "Transferência realizada!";
            // 
            // lblValorTransf
            // 
            lblValorTransf.AutoSize = true;
            lblValorTransf.BackColor = Color.Transparent;
            lblValorTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTransf.ForeColor = Color.Black;
            lblValorTransf.Location = new Point(168, 267);
            lblValorTransf.Name = "lblValorTransf";
            lblValorTransf.Size = new Size(308, 37);
            lblValorTransf.TabIndex = 29;
            lblValorTransf.Text = "Insira o valor a transferir:";
            lblValorTransf.Click += lblValorDeposito_Click;
            // 
            // btConfirmarTransf
            // 
            btConfirmarTransf.BackColor = Color.Crimson;
            btConfirmarTransf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarTransf.ForeColor = Color.White;
            btConfirmarTransf.Location = new Point(168, 364);
            btConfirmarTransf.Name = "btConfirmarTransf";
            btConfirmarTransf.Size = new Size(315, 48);
            btConfirmarTransf.TabIndex = 3;
            btConfirmarTransf.Text = "Confirmar transferência";
            btConfirmarTransf.UseVisualStyleBackColor = false;
            // 
            // lblDestinoTransf
            // 
            lblDestinoTransf.AutoSize = true;
            lblDestinoTransf.BackColor = Color.Transparent;
            lblDestinoTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestinoTransf.ForeColor = Color.Black;
            lblDestinoTransf.Location = new Point(168, 133);
            lblDestinoTransf.Name = "lblDestinoTransf";
            lblDestinoTransf.Size = new Size(278, 37);
            lblDestinoTransf.TabIndex = 30;
            lblDestinoTransf.Text = "CPF da Conta destino:";
            // 
            // TelaTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(655, 515);
            Controls.Add(lblDestinoTransf);
            Controls.Add(btConfirmarTransf);
            Controls.Add(lblValorTransf);
            Controls.Add(lblTransfConfirmada);
            Controls.Add(txtValorTransf);
            Controls.Add(txtDestinoTransf);
            Controls.Add(lblSaldoValTransf);
            Controls.Add(lblSaldoTransf);
            Controls.Add(lblTransferencia);
            Name = "TelaTransferencia";
            Text = "TelaTransferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransferencia;
        private Label lblSaldoValTransf;
        private Label lblSaldoTransf;
        private TextBox txtNomeDestino;
        private TextBox txtValorTransf;
        private TextBox txtDestinoTransf;
        private Label lblTransfConfirmada;
        private Label lblValorTransf;
        private Button btConfirmarTransf;
        private Label lblDestinoTransf;
    }
}