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
    public partial class FormConLogin : Form
    {
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();

        public FormConLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDalLogin dallogin = new clsDalLogin();

            



            dataGridView1.Rows.Clear();



            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Name = "codigo";
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Width = 40;

           dataGridView1.Columns[1].HeaderText = "Descrição";
           dataGridView1.Columns[1].Name = "descricaoTecnica";
           dataGridView1.Columns[1].Visible = true;
           
           dataGridView1.Columns[2].HeaderText = "Quantidade";
           dataGridView1.Columns[2].Name = "Qt_usuario";
           dataGridView1.Columns[2].Visible = true;
           dataGridView1.Columns[2].Width = 40;
           
           dataGridView1.Columns[3].HeaderText = "Valor";
           dataGridView1.Columns[3].Name = "custo_usuario";
           dataGridView1.Columns[3].Visible = true;
           dataGridView1.Columns[3].Width = 40;


            List<clsLogin> lista = new List<clsLogin>();

            for (int i = 0; i < lista.Count; i++)
            {

                dataGridView1.Rows.Add(new object[] { 
                            lista[i].Nome_login.ToString().Trim(),
                            lista[i].Senha_login.ToString().Trim(),
                            lista[i].Id_tipo_permissao.ToString().Trim(),
                           
                        });

            }

        }
    }
}
