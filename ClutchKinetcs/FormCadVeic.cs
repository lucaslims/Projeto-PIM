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
    public partial class FormCadVeic : Form
    {
        public FormCadVeic()
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
                dadosServico.Add(txtPlca.Text);
                dadosServico.Add(txtChassi.Text);
                dadosServico.Add(txtDesc.Text);
                dadosServico.Add(cmbCor.Text);
                dadosServico.Add(cmbModelo.Text);
                dadosServico.Add(cmbStatus.Text);
                dadosServico.Add(cmbEmp.Text);
               




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
        private void PreencherCombo(int _opc, ComboBox _comboBox)
        {
            try
            {
                string query ="";
                connMySql = clsConexao.GetConexaoMySql();
                connSqlServer = clsConexao.GetConexaoSqlServer();


                varGlob.AbrirConexaoMySql(connMySql);
                if (_opc == 1)
                {

                    query = "select ID, DESCRICAO from TB_CD_VEICULO_COR ORDER BY DESCRICAO;";
                }
                else if (_opc == 2)
                {
                    query = "select DESCRICAO from TB_CD_VEICULO_MODELO ORDER BY DESCRICAO";
                }
                else if (_opc== 3)
                {
                    query = "select DESCRICAO from TB_CD_VEICULO_MODELO ORDER BY DESCRICAO";

                }
                else if (_opc == 4)
                {
                    query = "select CNPJ from TB_CD_PESSOA_JURIDICA ORDER BY CNPJ";
                  
                }


                dt = varGlob.RetornaDataTableMySql(query, connMySql);
                _comboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    if(_opc != 4) 
                    _comboBox.Items.Add(row.Field<string>("DESCRICAO"));
                    else
                        _comboBox.Items.Add(row.Field<string>("CNPJ"));

                }

                if (_comboBox.Items.Count > 0)
                    _comboBox.SelectedIndex = 0;


            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(connMySql); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosVeiculo = new List<string>();
            try
            {
               
                dadosVeiculo.Add(txtPlca.Text);
                dadosVeiculo.Add(txtChassi.Text);
                dadosVeiculo.Add(txtDesc.Text);
                dadosVeiculo.Add(cmbCor.Text);
                dadosVeiculo.Add(cmbModelo.Text);
                dadosVeiculo.Add(cmbStatus.Text);
                dadosVeiculo.Add(cmbEmp.Text);

                



                varGlob.InsereLog();

                clsDalVeiculo dalveiculo = new clsDalVeiculo();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalveiculo.insertVeiculoProcedure(connMySql, connSqlServer, dadosVeiculo);

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

        }

        private void FormCadVeic_Load(object sender, EventArgs e)
        {
            PreencherCombo(1,cmbCor);
            PreencherCombo(2, cmbModelo);
            PreencherCombo(3, cmbStatus);
            PreencherCombo(4, cmbEmp);
        }
    }
}
