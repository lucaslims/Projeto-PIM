using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Control;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class clsDalLocalizacao : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertLocalizacao(MySqlConnection conMySql, SqlConnection conServer, clsLocalizacao objLocalizacao)
        {
            string inserirLocalizacao = "insert into TB_NG_LOCALIZACAO (LOCALIZACAO_ID,LOCALIZACAO_LOCAL,LOCALIZACAO_DESC, VEICULO_ID) " +
                                  " values (" + objLocalizacao.Id_loc + ", " +
                                          "'" + objLocalizacao.Local_loc + "', " +
                                          "'" + objLocalizacao.Desc_loc + "', " +
                                                objLocalizacao.Veiculo + " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirLocalizacao, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirLocalizacao, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateLocalizacao(MySqlConnection conMySql, SqlConnection conServer, clsLocalizacao objLocalizacao)
        {
            string atualizacaoLocalizacao = "update TB_NG_LOCALIZACAO set LOCALIZACAO_LOCAL = '" + objLocalizacao.Local_loc + "' , " +
                                                          " LOCALIZACAO_DESC = '" + objLocalizacao.Desc_loc + "', " +
                                                          " VEICULO_ID = " + objLocalizacao.Veiculo + " " + //CORRIGIR ERRO
                                                          " where LOCALIZACAO_ID = " + objLocalizacao.Id_loc + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizacaoLocalizacao, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizacaoLocalizacao, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteLocalizacao(MySqlConnection conMySql, SqlConnection conServer, clsLocalizacao objLocalizacao)
        {
            string deletarLocalizacao = "delete from TB_NG_LOCALIZACAO where LOCALIZACAO_ID = " + objLocalizacao.Id_loc + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarLocalizacao, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarLocalizacao, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsLocalizacao SelectLocalizacaoId(MySqlConnection conMySql, SqlConnection conServer, clsLocalizacao objLocalizacao)
        {
            string buscarLocalizacaoId = "select * from TB_NG_LOCALIZACAO where LOCALIZACAO_ID=" + objLocalizacao.Id_loc;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarLocalizacaoId, conServer);
                    dr.Read();
                    objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                    objLocalizacao.Local_loc = dr[1].ToString();
                    objLocalizacao.Desc_loc = dr[2].ToString();
                    objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString()); //IDVEICULO
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarLocalizacaoId, conMySql);
                    dr.Read();
                    objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                    objLocalizacao.Local_loc = dr[1].ToString();
                    objLocalizacao.Desc_loc = dr[2].ToString();
                    objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objLocalizacao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsLocalizacao SelectLoginLocalizacao(MySqlConnection conMySql, SqlConnection conServer, clsLocalizacao objLocalizacao)
        {
            string buscarLocalizacaoID = "select * from TB_NG_LOCALIZACAO where LOCALIZACAO_LOCAL = '" + objLocalizacao.Local_loc + "' and LOCALIZACAO_DESC = '" + objLocalizacao.Desc_loc + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarLocalizacaoID, conServer);
                    dr.Read();
                    objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                    objLocalizacao.Local_loc = dr[1].ToString();
                    objLocalizacao.Desc_loc = dr[2].ToString();
                    objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString());
                }
                
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarLocalizacaoID, conMySql);
                    dr.Read();
                    objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                    objLocalizacao.Local_loc = dr[1].ToString();
                    objLocalizacao.Desc_loc = dr[2].ToString();
                    objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objLocalizacao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsLocalizacao> ListarLocalizacao(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasLocalizacoes = "select * from TB_NG_LOCALIZACAO";
            List<clsLocalizacao> listaLocalizacao = new List<clsLocalizacao>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasLocalizacoes, conServer);
                    while (dr.Read())
                    {
                        clsLocalizacao objLocalizacao = new clsLocalizacao();
                        objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                        objLocalizacao.Local_loc = dr[1].ToString();
                        objLocalizacao.Desc_loc = dr[2].ToString();
                        objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString());
                        listaLocalizacao.Add(objLocalizacao);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasLocalizacoes, conMySql);
                    while (dr.Read())
                    {
                        clsLocalizacao objLocalizacao = new clsLocalizacao();
                        objLocalizacao.Id_loc = Convert.ToInt32(dr[0].ToString());
                        objLocalizacao.Local_loc = dr[1].ToString();
                        objLocalizacao.Desc_loc = dr[2].ToString();
                        objLocalizacao.Veiculo.Id = Convert.ToInt32(dr[3].ToString());
                        listaLocalizacao.Add(objLocalizacao);
                    }
                }

                return listaLocalizacao;
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

