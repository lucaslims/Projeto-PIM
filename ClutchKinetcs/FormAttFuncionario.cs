using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using DAL;
using Model;
using Control;

namespace ClutchKinetcs
{
    public partial class FormAttFuncionario : Form
    {
        MySqlConnection conMySql = clsConexao.GetConexaoMySql();

        clsGlobal varGlob = new clsGlobal();
        

        public FormAttFuncionario()
        {
            InitializeComponent();
        }

        private void FormAttFuncionario_Load(object sender, EventArgs e)
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

                //Aqui vc vai botar a query de busca do banco trazendo todos os dados.
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
                query = "select * from TB_CD_FUNCIONARIO";
                //criado a query vc precisa
                dt = varGlob.RetornaDataTableMySql(query, conMySql);


                //esse foreach vc percorre as linhas do datatable q eu criei encima e add no gridview!!
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro", "Erro: " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(conMySql); }
        }










    }
}
