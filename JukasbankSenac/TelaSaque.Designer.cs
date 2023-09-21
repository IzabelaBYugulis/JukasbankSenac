namespace JukasbankSenac
{
    partial class TelaSaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSaque));
            lblSaqueConfirmado = new Label();
            btConfirmarSaque = new Button();
            lblValorSaque = new Label();
            txtValorSaque = new TextBox();
            txtCelularSaque = new TextBox();
            txtEmailSaque = new TextBox();
            txtCpfSaque = new TextBox();
            txtNomeSaque = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblSaque = new Label();
            SuspendLayout();
            // 
            // lblSaqueConfirmado
            // 
            lblSaqueConfirmado.AutoSize = true;
            lblSaqueConfirmado.BackColor = Color.Transparent;
            lblSaqueConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaqueConfirmado.ForeColor = Color.White;
            lblSaqueConfirmado.Location = new Point(518, 407);
            lblSaqueConfirmado.Name = "lblSaqueConfirmado";
            lblSaqueConfirmado.Size = new Size(214, 37);
            lblSaqueConfirmado.TabIndex = 37;
            lblSaqueConfirmado.Text = "Saque realizado!";
            // 
            // btConfirmarSaque
            // 
            btConfirmarSaque.BackColor = Color.Crimson;
            btConfirmarSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarSaque.ForeColor = Color.White;
            btConfirmarSaque.Location = new Point(492, 313);
            btConfirmarSaque.Name = "btConfirmarSaque";
            btConfirmarSaque.Size = new Size(300, 48);
            btConfirmarSaque.TabIndex = 5;
            btConfirmarSaque.Text = "Confirmar saque";
            btConfirmarSaque.UseVisualStyleBackColor = false;
            btConfirmarSaque.Click += btConfirmarSaque_Click;
            // 
            // lblValorSaque
            // 
            lblValorSaque.AutoSize = true;
            lblValorSaque.BackColor = Color.Transparent;
            lblValorSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorSaque.ForeColor = Color.White;
            lblValorSaque.Location = new Point(474, 94);
            lblValorSaque.Name = "lblValorSaque";
            lblValorSaque.Size = new Size(327, 37);
            lblValorSaque.TabIndex = 34;
            lblValorSaque.Text = "Insira o valor a ser sacado:";
            // 
            // txtValorSaque
            // 
            txtValorSaque.BackColor = Color.White;
            txtValorSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorSaque.Location = new Point(492, 209);
            txtValorSaque.Name = "txtValorSaque";
            txtValorSaque.PlaceholderText = "R$ 0,00";
            txtValorSaque.Size = new Size(300, 43);
            txtValorSaque.TabIndex = 4;
            txtValorSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelularSaque
            // 
            txtCelularSaque.BackColor = Color.White;
            txtCelularSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelularSaque.Location = new Point(49, 378);
            txtCelularSaque.Name = "txtCelularSaque";
            txtCelularSaque.PlaceholderText = "(00) 00000-0000";
            txtCelularSaque.Size = new Size(300, 29);
            txtCelularSaque.TabIndex = 3;
            txtCelularSaque.TextAlign = HorizontalAlignment.Center;
            txtCelularSaque.Visible = false;
            // 
            // txtEmailSaque
            // 
            txtEmailSaque.BackColor = Color.White;
            txtEmailSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailSaque.Location = new Point(49, 305);
            txtEmailSaque.Name = "txtEmailSaque";
            txtEmailSaque.PlaceholderText = "Confirme seu e-mail";
            txtEmailSaque.Size = new Size(300, 29);
            txtEmailSaque.TabIndex = 2;
            txtEmailSaque.TextAlign = HorizontalAlignment.Center;
            txtEmailSaque.Visible = false;
            // 
            // txtCpfSaque
            // 
            txtCpfSaque.BackColor = Color.White;
            txtCpfSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfSaque.Location = new Point(49, 232);
            txtCpfSaque.Name = "txtCpfSaque";
            txtCpfSaque.PlaceholderText = "Confirme seu CPF";
            txtCpfSaque.Size = new Size(300, 29);
            txtCpfSaque.TabIndex = 1;
            txtCpfSaque.TextAlign = HorizontalAlignment.Center;
            txtCpfSaque.Visible = false;
            // 
            // txtNomeSaque
            // 
            txtNomeSaque.BackColor = Color.White;
            txtNomeSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeSaque.Location = new Point(49, 160);
            txtNomeSaque.Name = "txtNomeSaque";
            txtNomeSaque.PlaceholderText = "Nome Usuário";
            txtNomeSaque.Size = new Size(300, 29);
            txtNomeSaque.TabIndex = 0;
            txtNomeSaque.TextAlign = HorizontalAlignment.Center;
            txtNomeSaque.Visible = false;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.BackColor = Color.Transparent;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.White;
            lblSaldoVal.Location = new Point(161, 94);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 27;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(65, 94);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 26;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaque
            // 
            lblSaque.AutoSize = true;
            lblSaque.BackColor = Color.Transparent;
            lblSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaque.ForeColor = Color.White;
            lblSaque.Location = new Point(397, 9);
            lblSaque.Name = "lblSaque";
            lblSaque.Size = new Size(90, 37);
            lblSaque.TabIndex = 25;
            lblSaque.Text = "Saque";
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(846, 510);
            Controls.Add(lblSaqueConfirmado);
            Controls.Add(btConfirmarSaque);
            Controls.Add(lblValorSaque);
            Controls.Add(txtValorSaque);
            Controls.Add(txtCelularSaque);
            Controls.Add(txtEmailSaque);
            Controls.Add(txtCpfSaque);
            Controls.Add(txtNomeSaque);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblSaque);
            Name = "TelaSaque";
            Text = "TelaSaque";
            Load += TelaSaque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaqueConfirmado;
        private Button btConfirmarSaque;
        private Label lblValorSaque;
        private TextBox txtValorSaque;
        private TextBox txtCelularSaque;
        private TextBox txtEmailSaque;
        private TextBox txtCpfSaque;
        private TextBox txtNomeSaque;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblSaque;
    }
}