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
    public class clsDalSeguro : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertSeguroVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
        {
            string insertSeguro = "insert into TB_SEGURO (SEGURO_ID,SEGURO_DESC) " +
                                  " values (" + objSeguro.Id_seguro + ", " +
                                          "'" + objSeguro.Desc_seguro + "' " +
                                               " );";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(insertSeguro, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(insertSeguro, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateSeguro(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
        {
            string atualizarSeguro = "update TB_SEGURO set SEGURO_DESC = '" + objSeguro.Desc_seguro + " where id = " + objSeguro.Id_seguro + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarSeguro, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarSeguro, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteSeguro(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
        {
            string deletarSeguro = "delete from TB_SEGURO where SEGURO_ID = " + objSeguro.Id_seguro + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarSeguro, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarSeguro, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsSeguro SelectSeguroID(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
        {
            string buscarMarca = "select * from TB_SEGURO where SEGURO_ID=" + objSeguro.Id_seguro;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarMarca, conServer);
                    dr.Read();
                    objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                    objSeguro.Desc_seguro = dr[1].ToString();

                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarMarca, conMySql);
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
        }
        public clsSeguro SelectSeguroDesc(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
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
        }
        public List<clsSeguro> ListarSeguro(MySqlConnection conMySql, SqlConnection conServer)
        {
            string BuscarTodasMarcas = "select * from TB_SEGURO";
            List<clsSeguro> listaSeguro = new List<clsSeguro>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(BuscarTodasMarcas, conServer);
                    while (dr.Read())
                    {
                        clsSeguro objSeguro = new clsSeguro();
                        objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                        objSeguro.Desc_seguro = dr[1].ToString();
                        listaSeguro.Add(objSeguro);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(BuscarTodasMarcas, conMySql);
                    while (dr.Read())
                    {
                        clsSeguro objSeguro = new clsSeguro();
                        objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                        objSeguro.Desc_seguro = dr[1].ToString();
                        listaSeguro.Add(objSeguro);
                    }
                }

                return listaSeguro;
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
