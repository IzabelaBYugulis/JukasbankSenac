using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using DTO;
using JukasbankSenac.Classes;

namespace JukasbankSenac
{
    public partial class TelaLoginPrincipal : Form
    {
        public TelaLoginPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //Criando uma conex�o
            SqlConnection conexao =
        new SqlConnection(ConfigurationManager.ConnectionStrings["JukasbankSenac.Properties.Settings.strConexao"].ToString());
            SqlDataReader leitor; //declarando uma vari�vel do tipo leitor de dados

            //Criando um comando
            SqlCommand cmd = new SqlCommand();

            //criando texto do comando, tipo e conex�o que ser� usada
            cmd.CommandText = "ps_ValidarAcesso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //passando os par�metros necess�rios
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", caixaLogin.Text);
            cmd.Parameters.AddWithValue("senhaLogin", senhaLogin.Text);

            conexao.Open(); //abrindo a conex�o

            //igualando o leitor ao resultado trazido do BD
            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();

                UsuarioLogado.IdCliente = leitor.GetInt32(0);
                UsuarioLogado.Nome = leitor.GetString(1);
                UsuarioLogado.Cpf = leitor.GetString(2);
                if (!leitor.IsDBNull(3))
                {
                    UsuarioLogado.Rg = leitor.GetString(3);
                }
                UsuarioLogado.Celular = leitor.GetString(4);
                UsuarioLogado.Email = leitor.GetString(5);
                UsuarioLogado.Logradouro = leitor.GetString(6);
                UsuarioLogado.NumeroLogradouro = leitor.GetString(7);
                UsuarioLogado.Cep = leitor.GetString(8);
                UsuarioLogado.Cidade = leitor.GetString(9);
                UsuarioLogado.Estado = leitor.GetString(10);
                UsuarioLogado.Genero = leitor.GetString(11);
                UsuarioLogado.DataNasc = leitor.GetDateTime(12);
                UsuarioLogado.Renda = leitor.GetDecimal(13);
                UsuarioLogado.SenhaLogin = leitor.GetString(14);
                //fechando leitor
                leitor.Close();

                //criando texto do comando, tipo e conex�o que ser� usada
                cmd.CommandText = "ps_BuscaContasId";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //passando os par�metros necess�rios
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idcliente", UsuarioLogado.IdCliente);

                //ler novamente o leitor
                leitor = cmd.ExecuteReader();

                //verificar se h� linhas retornadas do leitor
                if (leitor.HasRows)
                {
                    //repete a leitura e enquanto h� linhas segue na estrutura
                    //de repeti��o
                    while (leitor.Read())
                    {
                        //cria uma conta na mem�ria
                        Conta conta = new Conta();
                        //passa os dados do leitor para a conta na mem�ria - objeto conta
                        conta.IdConta = leitor.GetInt32(0);
                        conta.IdCliente = leitor.GetInt32(1);
                        conta.Saldo = leitor.GetDecimal(2);
                        conta.Limite = leitor.GetDecimal(3);
                        conta.TipoConta = leitor.GetString(4);
                        conta.StatusConta = leitor.GetString(5);
                        conta.AberturaConta = leitor.GetDateTime(6);
                        if (!leitor.IsDBNull(7))
                        {
                            conta.EncerramentoConta = leitor.GetDateTime(7);
                        }
                        conta.SenhaConta = leitor.GetString(8);

                        //adiciona a conta rec�m criada na mem�ria para a colection de contas
                        UsuarioLogado.Contas.Add(conta);
                    }
                }



                leitor.Close(); //fecha leitor
                conexao.Close(); //fecha conexao com BD

                Form telaLogin = Application.OpenForms["TelaLogin"];
                //acessando o formul�rio aberto atrav�s da vari�vel janelaPrincipal
                MenuStrip menuPrincipal = (MenuStrip)telaLogin.Controls[0];
                menuPrincipal.Items[0].Text = "Logout";
                menuPrincipal.Items[1].Visible = false;
                menuPrincipal.Items[2].Visible = true;

                menuPrincipal.Items[7].Visible = true;
                menuPrincipal.Items[8].Visible = true;
                menuPrincipal.Items[8].Text = UsuarioLogado.Nome;
                menuPrincipal.Items[9].Visible = true;
                if (UsuarioLogado.Contas.Count == 0)
                {
                    menuPrincipal.Items[9].Text = "n�o h� contas";
                    MessageBox.Show($"Ol�, {UsuarioLogado.Nome}");
                    menuPrincipal.Items[3].Visible = false;
                    menuPrincipal.Items[4].Visible = false;
                    menuPrincipal.Items[5].Visible = false;
                    menuPrincipal.Items[6].Visible = false;
                }
                else
                {
                    menuPrincipal.Items[3].Visible = true;
                    menuPrincipal.Items[4].Visible = true;
                    menuPrincipal.Items[5].Visible = true;
                    menuPrincipal.Items[6].Visible = true;
                    UsuarioLogado.ContaLogada = UsuarioLogado.Contas[0].IdConta;
                    menuPrincipal.Items[9].Text = $"Conta: {UsuarioLogado.Contas[0].IdCliente.ToString()}";

                    MessageBox.Show($"Ol�,{UsuarioLogado.Nome}!\n" +
                        $"Voc� foi logado na conta {UsuarioLogado.Contas[0].IdCliente.ToString()}\n" +
                        $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                }


                //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                this.Close();


















                //MessageBox.Show("Seja Bem Vindo!");
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha incorretos.");
            }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
















            //c�digo quando o bot�o ENTRAR for clicado

            /*if (caixaLogin.Text == String.Empty || senhaLogin.Text == String.Empty)
            {
                lblMsgLogin.Text = "Dados n�o informados!";
                caixaLogin.Focus();

            }

            else if (caixaLogin.Text == "12345678900" && senhaLogin.Text == "123456")
            {
                TelaLoginPrincipal telaLogin = new TelaLoginPrincipal();

                // instanciei a classe / criei o objeto
                MenuPrincipal TelaMenu = new MenuPrincipal();

                //usando metodo show
                TelaMenu.Show();
            }

            else if (caixaLogin.TextLength < 11 || senhaLogin.TextLength < 6)
            {
                lblMsgLogin.Text = "Preencha os dados corretamente";

            }

            Conta MinhaConta = new Conta();

            MinhaConta.Status = "ATIVA";

            MessageBox.Show(MinhaConta.Status);*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void criarCadastro_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaCadastro TelaLogin = new TelaCadastro();

            //usando metodo show
            TelaLogin.Show();

        }

        private void caixaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLoginPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}