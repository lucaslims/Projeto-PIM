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

            List<string> dadosPessoa = new List<string>();
            try
            {
                dadosPessoa.Add(txtNomeCadCli.Text);
                //dadosPessoa.Add(cBoxStatusClienteCadCli.selectedValue.ToString()); //arrumar
                dadosPessoa.Add("1"); // apenas para teste tirar depois
                dadosPessoa.Add(txtCpfPessFisCadCli.Text);
                dadosPessoa.Add(txtRgPessFisCadCli.Text);
                dadosPessoa.Add(txtDtNascPessFisCadCli.Text);
                dadosPessoa.Add(txtCepCadCli.Text);
                dadosPessoa.Add(txtRuaCadCli.Text);
                dadosPessoa.Add(txtNumCadCli.Text);
                dadosPessoa.Add(txtComplCadCli.Text);
                dadosPessoa.Add(txtCidadeCadCli.Text); //tem q passar id cidade arrumar
                dadosPessoa.Add(txtEmailCadCli.Text);
                dadosPessoa.Add("55");//ddi
                dadosPessoa.Add(txtTelefoneCadCli.Text.Substring(0, 2));//ddd telefone- colocar mascara no campo
                dadosPessoa.Add(txtTelefoneCadCli.Text.Substring(2));//numero de telefone- colocar mascara no campo
                dadosPessoa.Add("55");//ddi
                dadosPessoa.Add(txtCelularCadCli.Text.Substring(0, 2));// ddd celular- colocar mascara no campo
                dadosPessoa.Add(txtCelularCadCli.Text.Substring(2));//numero de celular- colocar mascara no campo

                varGlob.InsereLog();

                clsDalPessoa dalpessoa = new clsDalPessoa();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalpessoa.InsertPessoaPFProcedure(connMySql, connSqlServer, dadosPessoa);

                    connMySql.Close();
                    connSqlServer.Close();
                    MessageBox.Show("Cadastro realizado com sucesso!!");
                }

                catch (Exception ex) { MessageBox.Show("registro não encontrado! erro: " + ex.Message); }
                finally
                {
                    connMySql.Close();
                    connSqlServer.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("registro não encontrado! erro: " + ex.Message); }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
