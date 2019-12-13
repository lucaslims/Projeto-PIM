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
    public partial class FormCadServico : Form
    {
        public FormCadServico()
        {
            InitializeComponent();
        }
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();
            double quantidadestacional, total, total2, estacionamento,valped,quantped;
            quantidadestacional = Convert.ToDouble(txtQuantEst.Text);
            estacionamento = Convert.ToDouble(txtEstVal.Text);

            total = quantidadestacional * estacionamento;
            txtTotalEst.Text = Convert.ToString(total);

            valped = Convert.ToDouble(txtValorPed.Text);
            quantped = Convert.ToDouble(txtQuantPed.Text);

            total2 = valped * quantped;

            txtTotalPed.Text = Convert.ToString(total2);
            List<string> dadosServico = new List<string>();
            try
            {
                dadosServico.Add(txtTotalEst.Text);
                dadosServico.Add(txtTotalPed.Text);

              

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

        private void FormCadServico_Load(object sender, EventArgs e)
        {

        }
    }
}
