namespace JukasbankSenac
{
    partial class TelaLoginPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginPrincipal));
            caixaLogin = new TextBox();
            senhaLogin = new TextBox();
            BotaoEntrar = new Button();
            Login = new Label();
            Senha = new Label();
            Mensagem = new Label();
            criarCadastro = new Button();
            esquecerSenha = new Button();
            lblMsgLogin = new Label();
            SuspendLayout();
            // 
            // caixaLogin
            // 
            caixaLogin.BackColor = Color.White;
            caixaLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            caixaLogin.ForeColor = Color.Black;
            caixaLogin.Location = new Point(208, 104);
            caixaLogin.MaxLength = 11;
            caixaLogin.Name = "caixaLogin";
            caixaLogin.PlaceholderText = "000.000.000-00";
            caixaLogin.Size = new Size(195, 36);
            caixaLogin.TabIndex = 0;
            caixaLogin.TextAlign = HorizontalAlignment.Center;
            caixaLogin.TextChanged += caixaLogin_TextChanged;
            // 
            // senhaLogin
            // 
            senhaLogin.BackColor = Color.White;
            senhaLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLogin.Location = new Point(208, 163);
            senhaLogin.MaxLength = 6;
            senhaLogin.Name = "senhaLogin";
            senhaLogin.PlaceholderText = "Insira sua senha";
            senhaLogin.Size = new Size(195, 36);
            senhaLogin.TabIndex = 1;
            senhaLogin.TextAlign = HorizontalAlignment.Center;
            senhaLogin.UseSystemPasswordChar = true;
            // 
            // BotaoEntrar
            // 
            BotaoEntrar.BackColor = Color.White;
            BotaoEntrar.Cursor = Cursors.Hand;
            BotaoEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BotaoEntrar.ForeColor = Color.Black;
            BotaoEntrar.Location = new Point(259, 226);
            BotaoEntrar.Name = "BotaoEntrar";
            BotaoEntrar.Size = new Size(96, 34);
            BotaoEntrar.TabIndex = 2;
            BotaoEntrar.Text = "Entrar";
            BotaoEntrar.UseVisualStyleBackColor = false;
            BotaoEntrar.Click += BotaoEntrar_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = Color.Transparent;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(114, 107);
            Login.Name = "Login";
            Login.Size = new Size(70, 30);
            Login.TabIndex = 3;
            Login.Text = "Login";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.BackColor = Color.Transparent;
            Senha.FlatStyle = FlatStyle.Flat;
            Senha.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Senha.ForeColor = Color.White;
            Senha.Location = new Point(114, 169);
            Senha.Name = "Senha";
            Senha.Size = new Size(75, 30);
            Senha.TabIndex = 4;
            Senha.Text = "Senha";
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.FlatStyle = FlatStyle.Flat;
            Mensagem.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Mensagem.ForeColor = Color.Yellow;
            Mensagem.Location = new Point(301, 47);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(0, 30);
            Mensagem.TabIndex = 5;
            // 
            // criarCadastro
            // 
            criarCadastro.BackColor = Color.Crimson;
            criarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            criarCadastro.ForeColor = SystemColors.ControlLightLight;
            criarCadastro.Location = new Point(208, 286);
            criarCadastro.Name = "criarCadastro";
            criarCadastro.Size = new Size(195, 46);
            criarCadastro.TabIndex = 3;
            criarCadastro.Text = "Criar conta";
            criarCadastro.UseVisualStyleBackColor = false;
            criarCadastro.Click += criarCadastro_Click;
            // 
            // esquecerSenha
            // 
            esquecerSenha.BackColor = Color.Crimson;
            esquecerSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esquecerSenha.ForeColor = Color.White;
            esquecerSenha.Location = new Point(208, 348);
            esquecerSenha.Name = "esquecerSenha";
            esquecerSenha.Size = new Size(195, 44);
            esquecerSenha.TabIndex = 4;
            esquecerSenha.Text = "Esqueci minha senha";
            esquecerSenha.UseVisualStyleBackColor = false;
            // 
            // lblMsgLogin
            // 
            lblMsgLogin.AutoSize = true;
            lblMsgLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsgLogin.Location = new Point(244, 54);
            lblMsgLogin.Name = "lblMsgLogin";
            lblMsgLogin.Size = new Size(0, 37);
            lblMsgLogin.TabIndex = 9;
            lblMsgLogin.Click += label1_Click;
            // 
            // TelaLoginPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(631, 510);
            Controls.Add(lblMsgLogin);
            Controls.Add(esquecerSenha);
            Controls.Add(criarCadastro);
            Controls.Add(Mensagem);
            Controls.Add(Senha);
            Controls.Add(Login);
            Controls.Add(BotaoEntrar);
            Controls.Add(senhaLogin);
            Controls.Add(caixaLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "TelaLoginPrincipal";
            Text = "BanJucas";
            Load += TelaLoginPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox caixaLogin;
        private TextBox senhaLogin;
        private Button BotaoEntrar;
        private Label Login;
        private Label Senha;
        private Label Mensagem;
        private Button criarCadastro;
        private Button esquecerSenha;
        private Label lblMsgLogin;
    }
}