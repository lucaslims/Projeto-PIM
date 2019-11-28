using System;
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
using Control;
using DAL;
using Model;
using MySql.Data.MySqlClient;

namespace ClutchKinetcs
{
    public partial class FormCadFuncionario : Form
    {
        public FormCadFuncionario()
        {
            InitializeComponent();
        }
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        DataTable dt;
        clsGlobal varGlob = new clsGlobal();
        clsConexao clsConn = new clsConexao();
        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosServico = new List<string>();
            try
            {
                dadosServico.Add(cmbNome.Text);
                dadosServico.Add(cmbDepartamento.Text);
                dadosServico.Add(cmbCargo.Text);
               




                varGlob.InsereLog();

                clsDalFuncionario dalservico = new clsDalFuncionario();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalservico.inserModeloProcedure(connMySql, connSqlServer, dadosServico);

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
                if (_opc == 4)
                {

                    query = "select NOME from TB_CD_PESSOA ORDER BY NOME;";
                }
                else if (_opc == 2)
                {
                    query = "select DESCRICAO from TB_CD_DEPARTAMENTO ORDER BY DESCRICAO";
                }
                else if (_opc == 3)
                {
                    query = "select DESCRICAO from TB_CD_CARGO ORDER BY DESCRICAO";
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

        private void FormCadFuncionario_Load(object sender, EventArgs e)
        {
            PreencherCombo(4,cmbNome);
            PreencherCombo(2,cmbDepartamento);
            PreencherCombo(3, cmbCargo);
        }
    }
}
