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
    public class clsDalLogAcesso : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertLog(MySqlConnection conMySql, SqlConnection conServer, clsLogAcessos objLog)
        {
            string inserirLogin = "insert into TB_NG_LOG_ACESSO (ID,ID_PESSOA,HORA,USUARIO) " +
                                  " values (" + objLog.Id + ", " +
                                          "" + objLog.Id_pessoa.Id + ", " +
                                          "" + objLog.Datahora + ", " +
                                               objLog.Usuario + " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirLogin, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirLogin, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateLogAcesso(MySqlConnection conMySql, SqlConnection conServer, clsLogAcessos objLog)
        {
            string atualizarLogAcesso = "update TB_NG_LOG_ACESSO set ID_PESSOA = " + objLog.Id_pessoa.Id + " , " +
                                                          " HORA = " + objLog.Datahora + ", " + //Hora
                                                          " Usuario = " + objLog.Usuario + " " +
                                                          " where ID = " + objLog.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarLogAcesso, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarLogAcesso, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteLog(MySqlConnection conMySql, SqlConnection conServer, clsLogAcessos objLog)
        {
            string deletarLog = "delete from TB_NG_LOG_ACESSO where ID = " + objLog.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarLog, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarLog, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsLogAcessos SelectLogId(MySqlConnection conMySql, SqlConnection conServer, clsLogAcessos objLog)
        {
            string buscarLogID = "select * from TB_NG_LOG_ACESSO where ID=" + objLog.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarLogID, conServer);
                    dr.Read();
                    objLog.Id = Convert.ToInt32(dr[0].ToString());
                    objLog.Id_pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objLog.Datahora = Convert.ToDateTime(dr[2].ToString());
                    objLog.Usuario =dr[3].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarLogID, conMySql);
                    dr.Read();
                    objLog.Id = Convert.ToInt32(dr[0].ToString());
                    objLog.Id_pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objLog.Datahora = Convert.ToDateTime(dr[2].ToString());
                    objLog.Usuario = dr[3].ToString();
                }

                return objLog;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsLogAcessos> ListarLogAcesso(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosOsLog = "select * from TB_NG_LOG_ACESSO";
            List<clsLogAcessos> listarLog = new List<clsLogAcessos>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosOsLog, conServer);
                    while (dr.Read())
                    {
                        clsLogAcessos objLog = new clsLogAcessos();
                        objLog.Id = Convert.ToInt32(dr[0].ToString());
                        objLog.Id_pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objLog.Datahora = Convert.ToDateTime(dr[2].ToString());
                        objLog.Usuario = dr[3].ToString();
                        listarLog.Add(objLog);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosOsLog, conMySql);
                    while (dr.Read())
                    {
                        clsLogAcessos objLog = new clsLogAcessos();
                        objLog.Id = Convert.ToInt32(dr[0].ToString());
                        objLog.Id_pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objLog.Datahora = Convert.ToDateTime(dr[2].ToString());
                        objLog.Usuario = dr[3].ToString();
                        listarLog.Add(objLog);
                    }
                }

                return listarLog;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
