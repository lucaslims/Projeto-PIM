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
    public class clsDalPedagio :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool inserirPedagio(MySqlConnection conMySql, SqlConnection conServer, clsPedagio objPedagio)
        {
            string insertPedagio = "insert into TB_NG_PEDAGIO (ID,VALOR,QUANTIDADE,SEVICOS_ID) " +
                                  " values (" + objPedagio.Id + ", " +
                                          "" + objPedagio.Valor + " " +
                                           "" + objPedagio.Quantidade + " " +
                                            "'" + objPedagio.Servicos.Id_servicos + "' " +
                                             
                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(insertPedagio, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(insertPedagio, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePedagio(MySqlConnection conMySql, SqlConnection conServer, clsPedagio objPedagio)
        {
            string atualizarPedagio = "update TB_NG_PEDAGIO set VALOR = '" + objPedagio.Valor +", "+ "QUANTIDADE=' "+objPedagio.Quantidade+"'"+
                "SERVICOS_ID='"+objPedagio.Servicos.Id_servicos+"' where id = " + objPedagio.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarPedagio, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarPedagio, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeletePedagio(MySqlConnection conMySql, SqlConnection conServer, clsPedagio objPedagio)
        {
            string deletarPedagio = "delete from TB_NG_PEDAGIO where ID = " + objPedagio.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarPedagio, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarPedagio, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPedagio SelectPedagioID(MySqlConnection conMySql, SqlConnection conServer, clsPedagio objPedagio)
        {
            string buscarPedagio = "select * from TB_NG_PEDAGIO where ID=" + objPedagio.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPedagio, conServer);
                    dr.Read();
                    objPedagio.Id= Convert.ToInt32(dr[0].ToString());
                    objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                    objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                    objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                    

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPedagio, conMySql);
                    dr.Read();
                    objPedagio.Id = Convert.ToInt32(dr[0].ToString());
                    objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                    objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                    objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }

                return objPedagio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPedagio SelectValorPedagio (MySqlConnection conMySql, SqlConnection conServer, clsPedagio objPedagio)
        {
            string buscarModeloID = "select * from TB_NG_PEDAGIO where desc = '" + objPedagio.Id + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarModeloID, conServer);
                    dr.Read();
                    objPedagio.Id = Convert.ToInt32(dr[0].ToString());
                    objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                    objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                    objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarModeloID, conMySql);
                    dr.Read();
                    objPedagio.Id = Convert.ToInt32(dr[0].ToString());
                    objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                    objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                    objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }

                return objPedagio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsPedagio> ListarModelo(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosPedagios = "select * from TB_NB_PEDAGIO";
            List<clsPedagio> listaPedagio = new List<clsPedagio>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosPedagios, conServer);
                    while (dr.Read())
                    {
                        clsPedagio objPedagio = new clsPedagio();
                        objPedagio.Id = Convert.ToInt32(dr[0].ToString());
                        objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                        objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                        objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaPedagio.Add(objPedagio);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosPedagios, conMySql);
                    while (dr.Read())
                    {
                        clsPedagio objPedagio = new clsPedagio();
                        objPedagio.Id = Convert.ToInt32(dr[0].ToString());
                        objPedagio.Valor = Convert.ToDouble(dr[1].ToString());
                        objPedagio.Quantidade = Convert.ToInt32(dr[2].ToString());
                        objPedagio.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaPedagio.Add(objPedagio);
                    }
                }

                return listaPedagio;
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