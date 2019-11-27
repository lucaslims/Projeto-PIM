using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using DAL;

namespace ClutchKinetcs
{
    public partial class FormLogin : Form
    {
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();
        int X = 0;
        int Y = 0;

        private void PnlOpcSW_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PnlOpcSW_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        public FormLogin(clsGlobal cls)
        {
            InitializeComponent();
            this.varGlob = cls;
            this.MouseDown += new MouseEventHandler(PnlOpcSW_MouseDown);
            this.MouseMove += new MouseEventHandler(PnlOpcSW_MouseMove);
        }

        private void BtnFecharSW_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizarSW_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //criar uma conexao
                connMySql = clsConexao.GetConexaoMySql();
                connSqlServer = clsConexao.GetConexaoSqlServer();

                string user, senha;
                user = txtUsuario.Text;
                senha = txtSenha.Text;

                clsPessoa pessoa = new clsPessoa();
                clsTipoPermissao tipoPermissao = new clsTipoPermissao();
                clsLogin login = new clsLogin();

                login.Id_pessoa = pessoa;
                login.Nome_login = user;
                login.Senha_login = senha;
                login.Id_tipo_permissao = tipoPermissao;

                varGlob.InsereLog();
                clsDalLogin dalLogin = new clsDalLogin();

                clsDalPessoa dalPessoa = new clsDalPessoa();

                try
                {
                    if (varGlob.BdConexao == "MySql")
                        dalLogin.AbrirConexaoMySql(connMySql);
                    else if (varGlob.BdConexao == "SqlServer")
                        dalLogin.AbrirConexaoSqlServer(connSqlServer);

                    login = dalLogin.SelectLoginUserSenha(connMySql, connSqlServer, login);
                }
                catch (Exception ex) { MessageBox.Show("Usuário não encontrado! Erro: " + ex.Message); throw ex; }
                finally { dalLogin.FecharConexaoMySql(connMySql); dalLogin.FecharConexaoSqlServer(connSqlServer); }

                try
                {
                    if (varGlob.BdConexao == "MySql")
                        dalLogin.AbrirConexaoMySql(connMySql);
                    else if (varGlob.BdConexao == "SqlServer")
                        dalLogin.AbrirConexaoSqlServer(connSqlServer);

                    dalPessoa.SelectPessoaId(connMySql, connSqlServer, pessoa);

                    //abrindo o form menu principal
                    FormMenuPrincipal frmMenupcp = new FormMenuPrincipal(this, pessoa);
                    //Ocuta o form
                    this.Hide();
                    //Muda a Opacidade do form menu principal para 0
                    frmMenupcp.Opacity = 0;
                    //Abre o form menu principal
                    frmMenupcp.Show(this);
                    //For para aumentar gradativamente a opacidade do form menu principal
                    for (double i = 0; i <= 1; i += 0.1)
                    {
                        //Acrescenta em 0.1 a opacidade do form
                        frmMenupcp.Opacity = i;
                        //Atualizao form menu principal
                        frmMenupcp.Refresh();
                        //Limitador da velocidade que o form seguinte irá aparecer
                        System.Threading.Thread.Sleep(70);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Usuário não encontrado! Erro: " + ex.Message); throw ex; }
                finally { dalLogin.FecharConexaoMySql(connMySql); dalLogin.FecharConexaoSqlServer(connSqlServer); }
            }
            catch
            {
                MessageBox.Show("Erro de conexão ao utilizar metodo Orientado a Objeto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {


                    //string de Conexão
                    string connString = Properties.Settings.Default.conexaoBD;
                    //Metodo de conexao 
                    MySqlConnection conn = new MySqlConnection(connString);
                    //Metodo para executar comando
                    MySqlCommand command = conn.CreateCommand();
                    //Leitor de dados
                    MySqlDataReader dr;
                    int total = 0, permissao = 999;

                    try
                    {
                        //abrindo conexao
                        conn.Open();
                        {
                            //comando de pesquisa de usuário
                            command.CommandText = "SELECT count(0) as total FROM tb_login WHERE USER_LOGIN = '" + txtUsuario.Text + "' and SENHA_LOGIN = '" + txtSenha.Text + "' ;";
                            //execuxao do comando
                            dr = command.ExecuteReader();
                            //abrindo leitura de dados retornada pelo comando
                            while (dr.Read())
                            {
                                //Pegando o total de usuarios retornados pela consulta
                                total += Convert.ToInt32(dr.GetString("total"));
                            }
                            //fechando leitura de dados
                            dr.Close();
                        }
                        //fechando conexao
                        conn.Close();

                        //abrindo conexao
                        conn.Open();
                        {
                            //comando de pesquisa de permissão
                            command.CommandText = "SELECT TIPO_FUNC as permissao FROM tb_login WHERE USER_LOGIN = '" + txtUsuario.Text + "' and SENHA_LOGIN = '" + txtSenha.Text + "' ;";
                            //execuxao do comando
                            dr = command.ExecuteReader();
                            //abrindo leitura de dados retornada pelo comando
                            while (dr.Read())
                            {
                                //Pegando a permissão do usuario retornado pela consulta
                                permissao = Convert.ToInt32(dr.GetString("permissao"));
                            }
                            //fechando leitura de dados
                            dr.Close();
                        }
                        //fechando conexao
                        conn.Close();

                    }
                    catch (MySqlException ex)
                    {
                        //fechando conexao caso apresente erro
                        conn.Close();
                        //Mensagem de erro caso não conectar ao banco de dados
                        MessageBox.Show("Erro: " + ex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("erro:" + ex);
                    }
                    catch (Exception ex)
                    {
                        //Mensagem de erro diverso
                        MessageBox.Show("Erro: " + ex);
                    }
                    finally
                    {
                        try
                        {
                            //verificando se a consulta retornou algum usuario cadastrado
                            if (total == 1)
                            {
                                //abrindo conexao
                                conn.Open();
                                {
                                    //comando de pesquisa de  id de usuário
                                    command.CommandText = "SELECT ID_LOGIN FROM tb_login WHERE USER_LOGIN = '" + txtUsuario.Text + "' and SENHA_LOGIN = '" + txtSenha.Text + "' ;";
                                    //execuxao do comando
                                    dr = command.ExecuteReader();
                                    //abrindo leitura de dados retornada pelo comando
                                    while (dr.Read())
                                    {
                                        //Pegando o id do usuario retornado pela consulta
                                        //ClsGlobal.IdLogin = Convert.ToInt32(dr.GetString("ID_LOGIN"));
                                    }
                                    //fechando leitura de dados
                                    dr.Close();
                                }
                                //fechando conexao
                                conn.Close();

                                //abrindo o form menu principal
                                FormMenuPrincipal frmMenupcp = new FormMenuPrincipal(this);
                                //Ocuta o form
                                this.Hide();
                                //Muda a Opacidade do form menu principal para 0
                                frmMenupcp.Opacity = 0;
                                //Abre o form menu principal
                                frmMenupcp.Show(this);
                                //For para aumentar gradativamente a opacidade do form menu principal
                                for (double i = 0; i <= 1; i += 0.1)
                                {
                                    //Acrescenta em 0.1 a opacidade do form
                                    frmMenupcp.Opacity = i;
                                    //Atualizao form menu principal
                                    frmMenupcp.Refresh();
                                    //Limitador da velocidade que o form seguinte irá aparecer
                                    System.Threading.Thread.Sleep(70);
                                }
                            }
                            else
                                MessageBox.Show("Usuário ou senha invalidos!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (MySqlException ex)
                        {
                            //fechando conexao caso apresente erro
                            conn.Close();
                            //Mensagem de erro caso não conectar ao banco de dados
                            MessageBox.Show("Erro ao conectar com o banco de dados");
                            Console.WriteLine("Erro: " + ex);
                        }
                        catch (Exception ex)
                        {
                            //Mensagem de erro diverso
                            MessageBox.Show("Erro: " + ex);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Erro de conexão ao utilizar metodo Antigo!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Entrar com a tecla enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                BtnLogin_Click(sender, e);
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtSenha.Focus();
        }
    }
}
