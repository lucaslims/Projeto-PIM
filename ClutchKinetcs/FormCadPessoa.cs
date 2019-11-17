using Control;
using DAL;
using Model;
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

            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            clsPessoa pessoa = new clsPessoa();
            clsTipoPessoa tipopessoa = new clsTipoPessoa();
            clsEmail email = new clsEmail();
            clsEstado estado = new clsEstado();
            clsCidade cidade = new clsCidade();
            clsTelefone telefone = new clsTelefone();
            clsEndereco endereco = new clsEndereco();
            clsStatus status = new clsStatus();
            clsPais pais = new clsPais();

            status.Id = Convert.ToInt32(cBoxStatusClienteCadCli.selectedValue);

            tipopessoa.Id = Convert.ToInt32(cBoxTipoPessoa.selectedValue);

            pessoa.Nome = txtNomeCadCli.Text;
            pessoa.StatusPessoa = status; //status

            pais.Id = 1;

            estado.Pais = pais;
            estado.Descricao = txtUfCadCli.Text;

            cidade.Estado = estado;
            cidade.Descricao = txtCidadeCadCli.Text;

            endereco.Cep = txtCepCadCli.Text;
            endereco.Pessoa = pessoa;
            endereco.Logradouro = txtRuaCadCli.Text + " - ";
            endereco.Numero = Convert.ToInt32(txtNumCadCli.Text);
            endereco.Complemento = txtComplCadCli.Text;
            endereco.Bairro = txtBairroCadCli.Text;

            email.Email = txtEmailCadCli.Text;
            email.Pessoa = pessoa;

            telefone.Numero = Convert.ToInt32(txtNumCadCli.Text);
            telefone.Numero = Convert.ToInt32(txtNumCadCli.Text);

            varGlob.InsereLog();

            clsDalPessoa dalpessoa = new clsDalPessoa();
            clsDalTipoPessoa daltipopessoa = new clsDalTipoPessoa();
            clsDalEmail dalemail = new clsDalEmail();
            clsDalEstado dalestado = new clsDalEstado();
            clsDalCidade dalcidade = new clsDalCidade();
            clsDalTelefone daltelefone = new clsDalTelefone();
            clsDalEndereco dalendereco = new clsDalEndereco();
            clsDalStatusVeiculo dalstatus = new clsDalStatusVeiculo();
            clsDalPais dalpais = new clsDalPais();
            clsDalGeral lastid = new clsDalGeral();

            try
            {
                connMySql.Open();
                connSqlServer.Open();


                dalstatus.InsertStatus(connMySql, connSqlServer, status);

                dalpessoa.InsertPessoa(connMySql, connSqlServer, pessoa);

                pessoa = lastid.SelectUtimoIdPessoa(connMySql, connSqlServer, pessoa);

                dalestado.InsertEstado(connMySql, connSqlServer, estado);
                dalcidade.insertcidade(connMySql, connSqlServer, cidade);

                dalendereco.insertEndereco(connMySql, connSqlServer, endereco);

                dalemail.InsertEmail(connMySql, connSqlServer, email);

                daltelefone.insertTelefone(connMySql, connSqlServer, telefone); //celular
                daltelefone.insertTelefone(connMySql, connSqlServer, telefone);//telefone



                connMySql.Close();
                connSqlServer.Close();
            }

            catch (Exception ex) { MessageBox.Show("registro não encontrado! erro: " + ex.Message); throw ex; }
            finally { }

        }
    }
}
