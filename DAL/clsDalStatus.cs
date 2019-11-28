using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Control;

namespace DAL
{
    class clsDalStatus :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertStatus(MySqlConnection conMySql, SqlConnection conServer, clsStatusVeiculo objStatus)
        {
            string insertStatus = "insert into TB_CD_STATUS_VEICULO (ID,DESCRICAO) " +
                                  " values (" + objStatus.Id_statusveiculo + ", " +
                                          "'" + objStatus.Desc_statusveiculo + "' " +
                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(insertStatus, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(insertStatus, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateStatus(MySqlConnection conMySql, SqlConnection conServer, clsStatusVeiculo objStatus)
        {
            string atualizarStatus = "update TB_CD_STATUS_VEICULO set DESCRICAO = '" + objStatus.Desc_statusveiculo + " where id = " + objStatus.Id_statusveiculo + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarStatus, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarStatus, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteStatus(MySqlConnection conMySql, SqlConnection conServer, clsStatusVeiculo objStatus)
        {
            string deletarStatus = "delete from TB_CD_STATUS_VEICULO where ID = " + objStatus.Id_statusveiculo + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarStatus, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarStatus, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsStatusVeiculo SelectStatus(MySqlConnection conMySql, SqlConnection conServer, clsStatusVeiculo objStatus)
        {
            string buscarStatus = "select * from TB_CD_STATUS_VEICULO where ID=" + objStatus.Id_statusveiculo;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarStatus, conServer);
                    dr.Read();
                    objStatus.Id_statusveiculo = Convert.ToInt32(dr[0].ToString());
                    objStatus.Desc_statusveiculo = dr[1].ToString();

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarStatus, conMySql);
                    dr.Read();
                    objStatus.Id_statusveiculo = Convert.ToInt32(dr[0].ToString());
                    objStatus.Desc_statusveiculo = dr[1].ToString();
                }
                    return objStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     /*   public clsSeguro SelectSeguroDesc(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
        {
            string buscarSeguroID = "select * from TB_SEGURO where SEGURO_DESC = '" + objSeguro.Desc_seguro + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarSeguroID, conServer);
                    dr.Read();
                    objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                    objSeguro.Desc_seguro = dr[1].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarSeguroID, conMySql);
                    dr.Read();
                    objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                    objSeguro.Desc_seguro = dr[1].ToString();
                }

                return objSeguro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } */
        public List<clsStatusVeiculo> ListarStatus(MySqlConnection conMySql, SqlConnection conServer)
        {
            string BuscarTodosStatus = "select * from TB_CD_STATUS_VEICULO";
            List<clsStatusVeiculo> listaStatus = new List<clsStatusVeiculo>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(BuscarTodosStatus, conServer);
                    while (dr.Read())
                    {
                        clsStatusVeiculo objStatus = new clsStatusVeiculo();
                        objStatus.Id_statusveiculo = Convert.ToInt32(dr[0].ToString());
                        objStatus.Desc_statusveiculo = dr[1].ToString();
                        listaStatus.Add(objStatus);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(BuscarTodosStatus, conMySql);
                    while (dr.Read())
                    {
                        clsStatusVeiculo objStatus = new clsStatusVeiculo();
                        objStatus.Id_statusveiculo = Convert.ToInt32(dr[0].ToString());
                        objStatus.Desc_statusveiculo = dr[1].ToString();
                        listaStatus.Add(objStatus); ;
                    }
                }

                return listaStatus;
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
