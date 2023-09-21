namespace JukasbankSenac
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            extratoLista = new ListBox();
            btConfig = new Button();
            depositar = new Button();
            sacar = new Button();
            sairMenu = new Button();
            lblOla = new Label();
            lblNomeUser = new Label();
            lblSaldo = new Label();
            lblSaldoVal = new Label();
            lblExtrato = new Label();
            lblOperacoes = new Label();
            SuspendLayout();
            // 
            // extratoLista
            // 
            extratoLista.BackColor = Color.White;
            extratoLista.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            extratoLista.FormattingEnabled = true;
            extratoLista.ItemHeight = 37;
            extratoLista.Items.AddRange(new object[] { "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )" });
            extratoLista.Location = new Point(45, 170);
            extratoLista.Name = "extratoLista";
            extratoLista.Size = new Size(393, 226);
            extratoLista.TabIndex = 0;
            extratoLista.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btConfig
            // 
            btConfig.BackColor = Color.Crimson;
            btConfig.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfig.ForeColor = SystemColors.ControlLightLight;
            btConfig.Location = new Point(47, 472);
            btConfig.Name = "btConfig";
            btConfig.Size = new Size(217, 51);
            btConfig.TabIndex = 1;
            btConfig.Text = "Configurações";
            btConfig.UseVisualStyleBackColor = false;
            // 
            // depositar
            // 
            depositar.BackColor = Color.Crimson;
            depositar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            depositar.ForeColor = SystemColors.ControlLightLight;
            depositar.Location = new Point(800, 219);
            depositar.Name = "depositar";
            depositar.Size = new Size(200, 74);
            depositar.TabIndex = 3;
            depositar.Text = "Depositar";
            depositar.UseVisualStyleBackColor = false;
            depositar.Click += depositar_Click;
            // 
            // sacar
            // 
            sacar.BackColor = Color.Crimson;
            sacar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sacar.ForeColor = SystemColors.ControlLightLight;
            sacar.Location = new Point(800, 321);
            sacar.Name = "sacar";
            sacar.Size = new Size(200, 75);
            sacar.TabIndex = 4;
            sacar.Text = "Sacar";
            sacar.UseVisualStyleBackColor = false;
            sacar.Click += sacar_Click;
            // 
            // sairMenu
            // 
            sairMenu.BackColor = Color.Crimson;
            sairMenu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sairMenu.ForeColor = SystemColors.ControlLightLight;
            sairMenu.Location = new Point(933, 472);
            sairMenu.Name = "sairMenu";
            sairMenu.Size = new Size(157, 51);
            sairMenu.TabIndex = 7;
            sairMenu.Text = "Sair";
            sairMenu.UseVisualStyleBackColor = false;
            sairMenu.Click += sairMenu_Click;
            // 
            // lblOla
            // 
            lblOla.AutoSize = true;
            lblOla.BackColor = Color.Transparent;
            lblOla.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOla.ForeColor = Color.White;
            lblOla.Location = new Point(86, 23);
            lblOla.Name = "lblOla";
            lblOla.Size = new Size(64, 37);
            lblOla.TabIndex = 8;
            lblOla.Text = "Olá,";
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.BackColor = Color.Transparent;
            lblNomeUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeUser.ForeColor = Color.White;
            lblNomeUser.Location = new Point(156, 23);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(108, 37);
            lblNomeUser.TabIndex = 9;
            lblNomeUser.Text = "Usuário";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(45, 30);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.BackColor = Color.Transparent;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.White;
            lblSaldoVal.Location = new Point(141, 30);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 11;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblExtrato
            // 
            lblExtrato.AutoSize = true;
            lblExtrato.BackColor = Color.Transparent;
            lblExtrato.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblExtrato.ForeColor = Color.White;
            lblExtrato.Location = new Point(45, 84);
            lblExtrato.Name = "lblExtrato";
            lblExtrato.Size = new Size(106, 37);
            lblExtrato.TabIndex = 12;
            lblExtrato.Text = "Extrato:";
            // 
            // lblOperacoes
            // 
            lblOperacoes.AutoSize = true;
            lblOperacoes.BackColor = Color.Transparent;
            lblOperacoes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacoes.ForeColor = Color.White;
            lblOperacoes.Location = new Point(800, 69);
            lblOperacoes.Name = "lblOperacoes";
            lblOperacoes.Size = new Size(149, 37);
            lblOperacoes.TabIndex = 13;
            lblOperacoes.Text = "Operações:";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1134, 535);
            Controls.Add(lblOperacoes);
            Controls.Add(lblExtrato);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblNomeUser);
            Controls.Add(lblOla);
            Controls.Add(sairMenu);
            Controls.Add(sacar);
            Controls.Add(depositar);
            Controls.Add(btConfig);
            Controls.Add(extratoLista);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox extratoLista;
        private Button btConfig;
        private Button depositar;
        private Button sacar;
        private Button sairMenu;
        private Label lblOla;
        private Label lblNomeUser;
        private Label lblSaldo;
        private Label lblSaldoVal;
        private Label lblExtrato;
        private Label lblOperacoes;
    }
}