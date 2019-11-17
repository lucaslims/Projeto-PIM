using Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClutchKinetcs
{
    public partial class FormCadPessoa : Form
    {
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();

        public FormCadPessoa(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Maximized;
        }

        private void FormCadPessoa_ParentChanged(object sender, EventArgs e)
        {
            if (menuPrincipal.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;

            if (menuPrincipal.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //connMySql = clsConexao.GetConexaoMySql();
            //connSqlServer = clsConexao.GetConexaoSqlServer();

            //string nome, cep, rua, numero, complemento, bairro, cidade, estado, email, celular, telefone, status, tipo;
            //nome = txtNomeCadCli.Text;
            //cep = txtCepCadCli.Text;
            //rua = txtRuaCadCli.Text;
            //complemento = txtComplCadCli.Text;
            //bairro = txtBairroCadCli.Text;
            //cidade = txtCidadeCadCli.Text;
            //numero = txtNumCadCli.Text;
            //estado = txtUfCadCli.Text;
            //email = txtEmailCadCli.Text;
            //celular = txtCelularCadCli.Text;
            //telefone = txtTelefoneCadCli.Text;
            //status = cmbStatus.selectedValue;
            //tipo = dplTipoPessoa.selectedValue;

            //clsPessoa pessoa = new clsPessoa();
            //clsTipoPessoa tipoPessoa = new clsTipoPessoa();
            //clsEmail Email = new clsEmail();
            //clsEstado Estado = new clsEstado();
            //clsCidade Cidade = new clsCidade();
            //clsTelefone Telefone = new clsTelefone();
            //clsEndereco Endereco = new clsEndereco();
            //clsStatus Status = new clsStatus();
            //clsPais Pais = new clsPais();

            //Status.id = cmbStatus.selectedValue;
            //tipoPessoa.Id_tipo = Convert.ToInt32(tipo);
            //pessoa.Nome = nome;
            //pessoa.StatusPessoa = status; //STATUS
            //Pais.Id = 1;
            //Estado.Pais = Pais;
            //Estado.Abreviacao = estado;
            //Cidade.Estado = Estado;
            //Cidade.Descricao = cidade;
            //Endereco.Cep = cep;
            //Endereco.Pessoa = pessoa;
            //Endereco.Logradouro = rua;
            //Endereco.Cmplemento = complemento;
            //Endereco.Bairro = bairro;
            //Email.Email = email;
            //Email.Pessoa = pessoa;
            //Telefone.Numero = Convert.ToInt32(numero);
            //Telefone.Numero = Convert.ToInt32(numero);




            //varGlob.InsereLog();


            //clsDalPessoa dalPessoa = new clsDalPessoa();
            //clsDalTipoPessoa daltipoPessoa = new clsDalTipoPessoa();
            //clsDalEmail dalEmail = new clsDalEmail();
            //clsDalEstado dalEstado = new clsDalEstado();
            //clsDalCidade dalCidade = new clsDalCidade();
            //clsDalTelefone dalTelefone = new clsDalTelefone();
            //clsDalEndereco dalEndereco = new clsDalEndereco();
            //clsDalStatus dalStatus = new clsDalStatus();
            //clsDalPais dalPais = new clsDalPais();
            //clsDalGeral lastId = new clsDalGeral();

            //try
            //{
            //    connMySql.Open();
            //    connSqlServer.Open();
            //    if (varGlob.BdConexao == "MySql")
            //        dalPessoa.AbrirConexaoMySql(connMySql);
            //    else if (varGlob.BdConexao == "SqlServer")
            //        dalPessoa.AbrirConexaoSqlServer(connSqlServer);
            //    dalStatus.InsertStatus(connMySql, connSqlServer, Status);
            //    daltipoPessoa.InsertTipo(connMySql, connSqlServer, tipo); //criar
            //    dalPessoa.InsertPessoa(connMySql, connSqlServer, pessoa);
            //    pessoa = lastId.SelectUtimoIdPessoa(connMySql, connSqlServer, pessoa);
            //    dalEstado.InsertEstado(connMySql, connSqlServer, Estado);
            //    dalCidade.InsertCidade(connMySql, connSqlServer, cidade);
            //    dalEndereco.insertEndereco(connMySql, connSqlServer, Endereco);
            //    dalEmail.InsertEmail(connMySql, connSqlServer, Email);
            //    dalTelefone.insertTelefone(connMySql, connSqlServer, Telefone); //celular
            //    dalTelefone.insertTelefone(connMySql, connSqlServer, Telefone);//telefone



            //    connMySql.Close();
            //    connSqlServer.Close();
            //}

            //catch (Exception ex) { MessageBox.Show("Registro não encontrado! Erro: " + ex.Message); throw ex; }
            //finally { dalPessoa.FecharConexaoMySql(connMySql); dalLogin.FecharConexaoSqlServer(connSqlServer); }

        }
    }
}
