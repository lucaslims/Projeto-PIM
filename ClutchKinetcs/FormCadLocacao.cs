using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClutchKinetcs
{
    public partial class FormCadLocacao : Form
    {
        public FormCadLocacao()
        {
            InitializeComponent();
        }

        private void gbClienteLoc_Enter(object sender, EventArgs e)
        {

        }

        private void gbGeralCadLoc_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            List<string> dadosServico = new List<string>();
            try
            {
                dadosServico.Add(txtDataLoc.Text);
                dadosServico.Add(txtTempLoc.Text);
                dadosServico.Add(txtCusto.Text);
                dadosServico.Add(txtTaxaExtra.Text);
                dadosServico.Add(cmbVeiculo.Text);
                dadosServico.Add(cmbPessoa.Text);
                 dadosServico.Add(cmbSeguro.Text);




                varGlob.InsereLog();

                clsDalLocacao dalservico = new clsDalLocacao();

                connMySql.Open();
                connSqlServer.Open();
                try
                {

                    dalservico.inserTLocacaoProcedure(connMySql, connSqlServer, dadosServico);

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

                    query = "select PLACA from TB_CD_VEICULO ORDER BY PLACA;";
                }
                else if (_opc == 2)
                {
                    query = "select NOME from TB_CD_PESSOA ORDER BY NOME;";
                }
                else 
                {
                    query = "select DESCRICAO from TB_SEGURO ORDER BY DESCRICAO;";
                }

                dt = varGlob.RetornaDataTableMySql(query, connMySql);
                _comboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    if (_opc == 1)
                    {
                        _comboBox.Items.Add(row.Field<string>("PLACA"));
                    }
                    else if (_opc == 2)
                    {
                        _comboBox.Items.Add(row.Field<string>("NOME"));
                    }
                    else 
                    {
                        _comboBox.Items.Add(row.Field<string>("DESCRICAO"));
                    }

                }

                if (_comboBox.Items.Count > 0)
                    _comboBox.SelectedIndex = 0;


            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(connMySql); }
        }

        private void FormCadModelo_Load(object sender, EventArgs e)
        {
            PreencherCombo(1, cmbVeiculo);
            PreencherCombo(2, cmbPessoa);
            PreencherCombo(3, cmbSeguro);
           
        }
    }
}
