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
    public partial class FormConViagem : Form
    {
        public FormConViagem()
        {
            InitializeComponent();
        }
        MySqlConnection conMySql = clsConexao.GetConexaoMySql();

        clsGlobal varGlob = new clsGlobal();

        private void FormConViagem_Load(object sender, EventArgs e)
        {
            GridProdutos();
        }

        private void gbServico_Enter(object sender, EventArgs e)
        {

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
                query = "Select viagem.ID,viagem.VIAGEM_ORIGEM,viagem.VIAGEM_DESTINO,viagem.VIAGEM_KM_CONSUMO_COMBUSTIVEL, pessoa.NOME as Nome ,veiculo.PLACA,servico.TOTAL_ESTACIONAMENTOS as Total_Estacionamento, " +
                        "servico.TOTAL_PEDAGIOS as Total_Pedagio from TB_NG_VIAGEM viagem " +
                        "INNER JOIN TB_CD_PESSOA pessoa on viagem.MOTORISTA_ID = pessoa.ID " +
                        "INNER JOIN TB_CD_VEICULO veiculo on viagem.VEICULO_ID = veiculo.ID " +
                        "INNER JOIN TB_NG_SERVICO servico on viagem.SERVICOS_ID = servico.ID;";
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
