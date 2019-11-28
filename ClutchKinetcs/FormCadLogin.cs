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
    public partial class FormCadLogin : Form
    {
        public FormCadLogin()
        {
            InitializeComponent();
        }
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormCadLogin_Load(object sender, EventArgs e)
        {
            //teste
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosServico = new List<string>();
            try
            {
                dadosServico.Add(txtLogin.Text);
                dadosServico.Add(txtSenha.Text);
           //     dadosServico.Add(txtTotalEst.Text);
             //   dadosServico.Add(txtTotalPed.Text);
               // dadosServico.Add(txtTotalEst.Text);
              




                varGlob.InsereLog();

                clsDalServico dalservico = new clsDalServico();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalservico.insertProcedureServico(connMySql, connSqlServer, dadosServico);

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

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
