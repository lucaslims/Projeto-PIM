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
        clsGlobal varGlob = new clsGlobal();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
