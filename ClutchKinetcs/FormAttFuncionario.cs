using System;
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
    public partial class FormAttFuncionario : Form
    {
        public FormAttFuncionario()
        {
            InitializeComponent();
        }
        MySqlConnection conMySql = clsConexao.GetConexaoMySql();

        clsGlobal varGlob = new clsGlobal();
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
                query = "SELECT funcionario.ID_PESSOA,pessoa.NOME as Nome ,cargo.DESCRICAO as Cargo,depart.DESCRICAO  from TB_CD_FUNCIONARIO funcionario "+
                        "INNER JOIN TB_CD_DEPARTAMENTO depart on funcionario.ID_DEPARTAMENTO = depart.ID "+
                        "INNER JOIN TB_CD_CARGO cargo on funcionario.ID_CARGO = cargo.ID "+
                        "INNER JOIN TB_CD_PESSOA pessoa on funcionario.ID_PESSOA = pessoa.ID; ";
                //criado a query vc precisa
                dt = varGlob.RetornaDataTableMySql(query, conMySql);


                //esse foreach vc percorre as linhas do datatable q eu criei encima e add no gridview!!
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex) { MessageBox.Show("Erro" + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { varGlob.FecharConexaoMySql(conMySql); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
