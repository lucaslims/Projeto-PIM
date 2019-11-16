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
    public class clsDalDepartamento :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();
        public bool InsertDepartamento(MySqlConnection conMySql, SqlConnection conServer, clsDepartamento objDepertamento)
        {
            string InserirDepartamento = "insert into TB_CD_DEPARTAMENTO  (ID,DESCRICAO " +
                                  " values (" + objDepertamento.Id + ", " +
                                          "'" + objDepertamento.Descricao + "');";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(InserirDepartamento, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(InserirDepartamento, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateDepartamento(MySqlConnection conMySql, SqlConnection conServer, clsDepartamento objDepertamento)
        {
            string atualizarDepartamento = "update TB_CD_DEPARTAMENTO set ID = '" + objDepertamento.Id + "' , " +
                                                          " DESCRICAO = '" + objDepertamento.Descricao + " ';";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarDepartamento, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarDepartamento, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteDepartamento(MySqlConnection conMySql, SqlConnection conServer, clsDepartamento objDepertamento)
        {
            string deletarDepartamento = "delete from TB_CD_DEPARTAMENTO where ID = " + objDepertamento.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarDepartamento, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarDepartamento, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsDepartamento SelectDeparmentoID(MySqlConnection conMySql, SqlConnection conServer, clsDepartamento objDepertamento)
        {
            string BuscarDepartamentoId = "select * from TB_CD_DEPARTAMENTO where ID=" + objDepertamento.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(BuscarDepartamentoId, conServer);
                    dr.Read();
                    objDepertamento.Id = Convert.ToInt32(dr[0].ToString());
                    objDepertamento.Descricao = dr[1].ToString();


                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(BuscarDepartamentoId, conMySql);
                    dr.Read();
                    objDepertamento.Id = Convert.ToInt32(dr[0].ToString());
                    objDepertamento.Descricao = dr[1].ToString();

                }

                return objDepertamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsDepartamento> ListDepartamentoId(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosDepartamentos = "select * from TB_CD_DEPARTAMENTO";
            List<clsDepartamento> ListDepartamento = new List<clsDepartamento>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosDepartamentos, conServer);
                    while (dr.Read())
                    {
                        clsDepartamento objDepartamento = new clsDepartamento();
                        objDepartamento.Id = Convert.ToInt32(dr[0].ToString());
                        objDepartamento.Descricao = dr[1].ToString();
                        ListDepartamento.Add(objDepartamento);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosDepartamentos, conMySql);
                    while (dr.Read())
                    {
                        clsDepartamento objDepartamento = new clsDepartamento();
                        objDepartamento.Id = Convert.ToInt32(dr[0].ToString());
                        objDepartamento.Descricao = dr[1].ToString();
                        ListDepartamento.Add(objDepartamento);
                    }
                }



                return ListDepartamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

