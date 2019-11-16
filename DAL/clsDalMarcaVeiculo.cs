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
    public class clsDalMarcaVeiculo :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertVeiculoMarca(MySqlConnection conMySql, SqlConnection conServer, clsMarcaVeiculo objMarca)
        {
            string insertMarca = "insert into TB_CD_VEICULO_MARCA (ID,DESCRICAO) " +
                                  " values (" + objMarca.Id_marca + ", " +
                                          "'" + objMarca.Desc_marca + "' " +                     
                                               " );";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(insertMarca, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(insertMarca, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateVeiculoMarca(MySqlConnection conMySql, SqlConnection conServer, clsMarcaVeiculo objMarca)
        {
            string atualizarMarca = "update TB_CD_VEICULO_MARCA set ID = '" + objMarca.Desc_marca +" where id = " + objMarca.Id_marca + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarMarca, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarMarca, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteMarca(MySqlConnection conMySql, SqlConnection conServer, clsMarcaVeiculo objMarca)
        {
            string deletarMarca = "delete from TB_CD_VEICULO_MARCA where ID = " + objMarca.Id_marca + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarMarca, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarMarca, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsMarcaVeiculo SelectMarcaID(MySqlConnection conMySql, SqlConnection conServer, clsMarcaVeiculo objMarca)
        {
            string buscarMarca = "select * from TB_CD_VEICULO_MARCA where ID=" + objMarca.Id_marca;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarMarca, conServer);
                    dr.Read();
                    objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                    objMarca.Desc_marca = dr[1].ToString();
          
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarMarca, conMySql);
                    dr.Read();
                    objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                    objMarca.Desc_marca = dr[1].ToString();
                }

                return objMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsMarcaVeiculo SelectMarDesc(MySqlConnection conMySql, SqlConnection conServer, clsMarcaVeiculo objMarca)
        {
            string buscarMarcaID = "select * from TB_CD_VEICULO_MARCA where desc = '" + objMarca.Desc_marca + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarMarcaID, conServer);
                    dr.Read();
                    objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                    objMarca.Desc_marca = dr[1].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarMarcaID, conMySql);
                    dr.Read();
                    objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                    objMarca.Desc_marca = dr[1].ToString();
                }

                return objMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsMarcaVeiculo> ListarMarca(MySqlConnection conMySql, SqlConnection conServer)
        {
            string BuscarTodasMarcas = "select * from TB_CD_VEICULO_MARCA";
            List<clsMarcaVeiculo> listaMarca = new List<clsMarcaVeiculo>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(BuscarTodasMarcas, conServer);
                    while (dr.Read())
                    {
                        clsMarcaVeiculo objMarca = new clsMarcaVeiculo();
                        objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                        objMarca.Desc_marca = dr[1].ToString();
                        listaMarca.Add(objMarca);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(BuscarTodasMarcas, conMySql);
                    while (dr.Read())
                    {
                        clsMarcaVeiculo objMarca = new clsMarcaVeiculo();
                        objMarca.Id_marca = Convert.ToInt32(dr[0].ToString());
                        objMarca.Desc_marca = dr[1].ToString();
                        listaMarca.Add(objMarca); ;
                    }
                }

                return listaMarca;
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
