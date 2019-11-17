using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Control;

namespace DAL
{
    public class clsDalCargo : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();
        public bool InsertCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string InserirCargo = "insert into TB_CD_CARGO  (ID,DESCRICAO " +
                                  " values (" + objCargo.Id + ", " +
                                          "'" + objCargo.Descricao + ");";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(InserirCargo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(InserirCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string atualizarCargo = "update TB_CD_CARGO set ID = '" + objCargo.Id + "' , " +
                                                          " DESCRICAO = '" + objCargo.Descricao + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarCargo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string deletarCargo = "delete from TB_CD_CARGO where ID = " + objCargo.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarCargo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsCargo SelectCargoId(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string buscarCargoPeloId = "select * from TB_CD_CARGO where ID=" + objCargo.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarCargoPeloId, conServer);
                    dr.Read();
                    objCargo.Id = Convert.ToInt32(dr[0].ToString());
                    objCargo.Descricao = dr[1].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarCargoPeloId, conMySql);
                    dr.Read();
                    objCargo.Id = Convert.ToInt32(dr[0].ToString());
                    objCargo.Descricao = dr[1].ToString();
                }

                return objCargo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsCargo> ListCargosId(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosCargos = "select * from TB_CD_FUNCIONARIO";
            List<clsCargo> ListaCargo = new List<clsCargo>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosCargos, conServer);
                    while (dr.Read())
                    {
                        clsCargo objCargo = new clsCargo();
                        objCargo.Id = Convert.ToInt32(dr[0].ToString());
                        objCargo.Descricao = dr[1].ToString();
                        ListaCargo.Add(objCargo);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosCargos, conMySql);
                    while (dr.Read())
                    {
                        clsCargo objCargo = new clsCargo();
                        objCargo.Id = Convert.ToInt32(dr[0].ToString());
                        objCargo.Descricao = dr[1].ToString();
                        ListaCargo.Add(objCargo);
                    }
                }


                return ListaCargo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
