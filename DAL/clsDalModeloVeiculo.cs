
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class clsDalModeloVeiculo : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool inserirModeloVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsModeloVeiculo objModelo)
        {
            string insertModelo = "insert into TB_CD_VEICULO_MARCA (ID,DESCRICAO) " +
                                  " values (" + objModelo.Id_modelo + ", " +
                                          "'" + objModelo.Desc_modelo + "' " +
                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(insertModelo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(insertModelo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool inserModeloProcedure(MySqlConnection conMySql, SqlConnection conServer, List<string> dadosViagem)
        {
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlCommand cmd = new SqlCommand("CADASTRAR_MODELO", conServer);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Tipo_descricao", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Marca_descricao", dadosViagem[1]);


                    ExecutarComandoProcSqlServer(cmd);
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_MODELO", conMySql);
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Tipo_descricao", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Marca_descricao", dadosViagem[1]);

                    ExecutarComandoProcSqlMySql(cmd);
                }
                else 
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_MODELO", conMySql);
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@V_Tipo_descricao", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@V_Marca_descricao", dadosViagem[1]);

                    ExecutarComandoProcSqlMySql(cmd);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateModelo(MySqlConnection conMySql, SqlConnection conServer, clsModeloVeiculo objModelo)
        {
            string atualizarModelo = "update TB_CD_VEICULO_MODELO set DESCRICAO = '" + objModelo.Desc_modelo + " where id = " + objModelo.Id_modelo + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarModelo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarModelo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteMarca(MySqlConnection conMySql, SqlConnection conServer, clsModeloVeiculo objModelo)
        {
            string deletarMarca = "delete from TB_CD_VEICULO_MODELO where ID = " + objModelo.Id_modelo + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarMarca, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarMarca, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsModeloVeiculo SelectModeloID(MySqlConnection conMySql, SqlConnection conServer, clsModeloVeiculo objModelo)
        {
            string buscarMarca = "select * from TB_CD_VEICULO_MODELO where ID=" + objModelo.Id_modelo;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarMarca, conServer);
                    dr.Read();
                    objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                    objModelo.Desc_modelo = dr[1].ToString();

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarMarca, conMySql);
                    dr.Read();
                    objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                    objModelo.Desc_modelo = dr[1].ToString();
                }

                return objModelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsModeloVeiculo SelectModeloDesc(MySqlConnection conMySql, SqlConnection conServer, clsModeloVeiculo objModelo)
        {
            string buscarModeloID = "select * from TB_CD_VEICULO_MODELO where desc = '" + objModelo.Desc_modelo + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarModeloID, conServer);
                    dr.Read();
                    objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                    objModelo.Desc_modelo = dr[1].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarModeloID, conMySql);
                    dr.Read();
                    objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                    objModelo.Desc_modelo = dr[1].ToString();
                }

                return objModelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsModeloVeiculo> ListarModelo(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosModelos = "select * from TB_CD_VEICULO_MODELO";
            List<clsModeloVeiculo> listaModelo = new List<clsModeloVeiculo>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosModelos, conServer);
                    while (dr.Read())
                    {
                        clsModeloVeiculo objModelo = new clsModeloVeiculo();
                        objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                        objModelo.Desc_modelo = dr[1].ToString();
                        listaModelo.Add(objModelo);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosModelos, conMySql);
                    while (dr.Read())
                    {
                        clsModeloVeiculo objModelo = new clsModeloVeiculo();
                        objModelo.Id_modelo = Convert.ToInt32(dr[0].ToString());
                        objModelo.Desc_modelo = dr[1].ToString();
                        listaModelo.Add(objModelo);
                    }
                }

                return listaModelo;
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