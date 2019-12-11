using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Control;
using System.Data;

namespace DAL
{
    public class clsDalViagem :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool insertViagem(MySqlConnection conMySql, SqlConnection conServer, clsViagem objViagem)
        {
            string inserirViagem = "insert into TB_NG_VIAGEM (ID,VIAGEM_ORIGEM,VIAGEM_DESTINO,VIAGEM_KM_CONSUMO_COMBUSTIVEL,VEICULO_ID,SERVICOS_ID) " +
                                  " values (" + objViagem.Id_viagem +           ", " +
                                         " '" + objViagem.Origem_viagem +       "'," +
                                         " '" + objViagem.Destino_viagem +      "'," +
                                          " " + objViagem.Abastecimento.Id+     ", " +
                                          " " + objViagem.Veiculo.Id  +         ", " +
                                          " " + objViagem.Servico.Id_servicos + ");" ;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirViagem, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirViagem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool insertViagemProcedure(MySqlConnection conMySql, SqlConnection conServer, List<string> dadosViagem)
        {
            try
            {

                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlCommand cmd = new SqlCommand("CADASTRAR_VIAGEM", conServer);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Viag_origem", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Viag_destino", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Viag_km", dadosViagem[2]);
                    cmd.Parameters.AddWithValue("@V_Mot_nome", dadosViagem[3]);
                    cmd.Parameters.AddWithValue("@V_Veic_desc", Convert.ToInt32(dadosViagem[4]));
                    cmd.Parameters.AddWithValue("@V_Serv_descricao", dadosViagem[5]);
                    ExecutarComandoProcSqlServer(cmd);
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_VIAGEM", conMySql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Viag_origem", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Viag_destino", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Viag_km", dadosViagem[2]);
                    cmd.Parameters.AddWithValue("@V_Mot_nome", dadosViagem[3]);
                    cmd.Parameters.AddWithValue("@V_Veic_desc", Convert.ToInt32(dadosViagem[4]));
                    cmd.Parameters.AddWithValue("@V_Serv_descricao", dadosViagem[5]);
              


                    ExecutarComandoProcSqlMySql(cmd);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_VIAGEM", conMySql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Viag_origem", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Viag_destino", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Viag_km", dadosViagem[2]);
                    cmd.Parameters.AddWithValue("@V_Mot_nome", dadosViagem[3]);
                    cmd.Parameters.AddWithValue("@V_Veic_desc", Convert.ToInt32(dadosViagem[4]));
                    cmd.Parameters.AddWithValue("@V_Serv_descricao", dadosViagem[5]);
                    ExecutarComandoProcSqlMySql(cmd);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateViagem(MySqlConnection conMySql, SqlConnection conServer, clsViagem objViagem)
        {
            string atualizarViagem = "update TB_NG_VIAGEM set  VIAGEM_ORIGEM= '" + objViagem.Origem_viagem +                   "', " + 
                                                              "VIAGEM_DESTINO= '" + objViagem.Destino_viagem +                 "', " + 
                                                              "VIAGEM_KM_CONSUMO_COMBUSTIVEL= " + objViagem.Abastecimento.Id + ",  " +
                                                              " where VEICULO_ID = " + objViagem.Veiculo.Id+                   ";  ";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarViagem, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarViagem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteViagem(MySqlConnection conMySql, SqlConnection conServer, clsViagem objViagem)
        {
            string deletarViagem = "delete from TB_NG_VIAGEM where VEICULO_ID = " + objViagem.Veiculo.Id + " ;"; //verificar se está certo
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarViagem, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarViagem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsViagem SelectViagemId(MySqlConnection conMySql, SqlConnection conServer, clsViagem objViagem)
        {
            string buscarViagem = "select * from TB_NG_VIAGEM where ID=" + objViagem.Veiculo;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarViagem, conServer);
                    dr.Read();
                    objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                    objViagem.Origem_viagem = dr[1].ToString();
                    objViagem.Destino_viagem = dr[2].ToString();
                    objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                    objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                    objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarViagem, conMySql);
                    dr.Read();
                   
                    objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                    objViagem.Origem_viagem = dr[1].ToString();
                    objViagem.Destino_viagem = dr[2].ToString();
                    objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                    objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                    objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }

                return objViagem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsViagem SelectVeiculoViagem(MySqlConnection conMySql, SqlConnection conServer, clsViagem objViagem)
        {
            string buscarVeiculoID = "select * from TB_NG_VIAGEM where VEICULO_ID = " + objViagem.Veiculo.Id + "";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarVeiculoID, conServer);
                    dr.Read();
                    objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                    objViagem.Origem_viagem = dr[1].ToString();
                    objViagem.Destino_viagem = dr[2].ToString();
                    objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                    objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                    objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarVeiculoID, conMySql);
                    dr.Read();
                    objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                    objViagem.Origem_viagem = dr[1].ToString();
                    objViagem.Destino_viagem = dr[2].ToString();
                    objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                    objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                    objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }

                return objViagem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsViagem> ListarViagens(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasViagens = "select * from TB_NG_VIAGEM";
            List<clsViagem> listaViagens = new List<clsViagem>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasViagens, conServer);
                    while (dr.Read())
                    {
                        clsViagem objViagem = new clsViagem();
                        objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                        objViagem.Origem_viagem = dr[1].ToString();
                        objViagem.Destino_viagem = dr[2].ToString();
                        objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                        objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                        objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaViagens.Add(objViagem);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasViagens, conMySql);
                    while (dr.Read())
                    {
                        clsViagem objViagem = new clsViagem();
                        objViagem.Id_viagem = Convert.ToInt32(dr[0].ToString());
                        objViagem.Origem_viagem = dr[1].ToString();
                        objViagem.Destino_viagem = dr[2].ToString();
                        objViagem.Abastecimento.Id = Convert.ToInt32(dr[3].ToString());
                        objViagem.Veiculo.Id = Convert.ToInt32(dr[2].ToString());
                        objViagem.Servico.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaViagens.Add(objViagem);
                    }
                }

                return listaViagens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        public ComboBox PreencherComboBoxLogin(MySqlConnection conMySql, SqlConnection conServer, ComboBox _comboBox)
        {
            // Pesquisando Logins e guardando no Dataset
            DataTable dt = RetornaDataTable("Select * from tb_cd_login", conMySql, conServer);

            //Limpando a ComboBox
            _comboBox.Items.Clear();

            // For para selecionar linha no datatable e inserir na combobox definida pela função
            for (int r = 0; r < dt.Rows.Count; r++)
                // Comando para adicionar item na combobox definida pela função
                _comboBox.Items.Add(dt.Rows[r]["Nome_login"].ToString());

            // Caso retorne algum dado e seje adicionado na Combobox selecionar índice 0
            if (_comboBox.Items.Count > 0)
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;

            // Caso Não retorne nenhum dado adicionar um Item manualmente e selecionar índice 0
            else
            {
                // Comando para adicionar Item no combo
                _comboBox.Items.Add("Selecione um Login");
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;
            }

            return _comboBox;
        }
         */

    }
}