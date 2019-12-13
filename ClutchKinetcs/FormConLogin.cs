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
        MySqlConnection conMySql = clsConexao.GetConexaoMySql();

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

        private void FormConLogin_Load(object sender, EventArgs e)
        {
            GridProdutos();
        }
        private void GridProdutos()
        {
            string query;

            DataTable dt;

            try
            {
                varGlob.AbrirConexaoMySql(conMySql);

                /*  //Aqui vc vai botar a query de busca do banco trazendo todos os dados.
                  query = "   SELECT   orca.id Id_Orcamento, obra.id idobra, Concat( obra.descricao,' - ', andar.descricao ) as obra, " +
                          "                pobr.id_produto_final, prod.descricao, prod.apelido, prodf.observacoes, prodf.quantidade   " +
                          "    FROM abtx_ng_orcamento orca                                                                            " +
                          "         INNER JOIN abtx_ngas_obra_orcamento_simples oos ON orca.id = oos.id_orcamento                     " +
                          "            INNER JOIN    abtx_ng_obra obra ON oos.id_obra = obra.id                                       " +
                          "            INNER JOIN    abtx_ngas_produto_obra_simples pobr ON pobr.id_obra = obra.id                    " +
                          "            INNER JOIN    abtx_cd_andar_obra andar ON andar.id = obra.id_andar                             " +
                          "            INNER JOIN    abtx_ng_produto_final prodf ON prodf.id = pobr.id_produto_final                  " +
                          "            INNER JOIN    abtx_cd_produto prod ON prod.id = prodf.id_produto_base                          " +
                          "    WHERE orca.id = ";//+ orcamento;/*Aqui é um parametro para a busca */

                // ele vai ignorar a query acima
                //coloca ae o nome da tabela q nao lembro
                query = "Select login.ID_PESSOA,pessoa.NOME,login.LOGIN,login.SENHA,tipo.DESCRICAO as PERMISSAO from TB_CD_LOGIN login " +
                        "INNER JOIN TB_CD_PESSOA pessoa on login.ID_PESSOA = pessoa.ID " +
                        "INNER JOIN TB_CD_TIPO_PERMISSAO tipo on login.ID_TIPO_PERMISSAO = tipo.ID;";
                //criado a query vc precisa
                dt = varGlob.RetornaDataTableMySql(query, conMySql);


                //esse foreach vc percorre as linhas do datatable q eu criei encima e add no gridview!!
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex) { MessageBox.Show("Erro" + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(conMySql); }
        }
    }
}
