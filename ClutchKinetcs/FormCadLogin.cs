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
        DataTable dt;
        clsGlobal varGlob = new clsGlobal();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormCadLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosServico = new List<string>();
            try
            {
                dadosServico.Add(cmbFunc.Text);
                dadosServico.Add(txtLogin.Text);
                dadosServico.Add(txtSenha.Text);
                dadosServico.Add(cmbTipoVeicu.Text);
               
             //   dadosServico.Add(txtTotalPed.Text);
               // dadosServico.Add(txtTotalEst.Text);
              




                varGlob.InsereLog();

                clsDalLogin dalservico = new clsDalLogin();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalservico.insertLoginProcedure(connMySql, connSqlServer, dadosServico);

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

        private void PreencherCombo(int _opc, ComboBox _comboBox)
        {
            try
            {
                string query = "";
                connMySql = clsConexao.GetConexaoMySql();
                connSqlServer = clsConexao.GetConexaoSqlServer();


                varGlob.AbrirConexaoMySql(connMySql);
                if (_opc == 1)
                {

                    query = "select DESCRICAO from TB_CD_TIPO_PERMISSAO ORDER BY DESCRICAO;";
                }
                if (_opc == 4)
                {

                    query = "select NOME from TB_CD_PESSOA ORDER BY NOME;";
                }



                dt = varGlob.RetornaDataTableMySql(query, connMySql);
                _comboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    if (_opc != 4)
                        _comboBox.Items.Add(row.Field<string>("DESCRICAO"));
                    else
                        _comboBox.Items.Add(row.Field<string>("NOME"));

                }

                if (_comboBox.Items.Count > 0)
                    _comboBox.SelectedIndex = 0;


            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(connMySql); }
        }

        private void FormCadModelo_Load(object sender, EventArgs e)
        {
            PreencherCombo(4, cmbFunc);
            PreencherCombo(1, cmbTipoVeicu);
           
          
        }
    }
}
