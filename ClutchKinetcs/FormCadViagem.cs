using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using Control;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ClutchKinetcs
{
    public partial class FormCadViagem : Form
    {
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        DataTable dt;
        clsGlobal varGlob = new clsGlobal();
        clsConexao clsConn = new clsConexao();


        public FormCadViagem()
        {
            InitializeComponent();
        }

        private void FormCadViagem_Load(object sender, EventArgs e)
        {
            clsDalViagem dalviagem = new clsDalViagem();
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

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
                    query = "select PLACA from TB_CD_VEICULO ORDER BY PLACA";
                }
              


                dt = varGlob.RetornaDataTableMySql(query, connMySql);
                _comboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    if (_opc != 4)
                        _comboBox.Items.Add(row.Field<string>("PLACA"));
                    else
                        _comboBox.Items.Add(row.Field<string>("NOME"));

                }

                if (_comboBox.Items.Count > 0)
                    _comboBox.SelectedIndex = 0;


            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(connMySql); }
            }
       
    
        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosViagem = new List<string>();
            try
            {

                dadosViagem.Add(txtOrigemVia.Text);
                dadosViagem.Add(txtDestino.Text);
                dadosViagem.Add(txtCombustivel.Text);
                dadosViagem.Add(cmbMotorista.Text);
                dadosViagem.Add(cmbPlaca.Text);
                dadosViagem.Add("1");





                varGlob.InsereLog();

                clsDalViagem dalviagem = new clsDalViagem();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalviagem.insertViagemProcedure(connMySql, connSqlServer, dadosViagem);

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

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            PreencherCombo(4, cmbMotorista);
            PreencherCombo(2, cmbPlaca);
     
        }
    }
}
