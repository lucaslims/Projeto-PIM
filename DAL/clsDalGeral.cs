using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;

namespace DAL
{
    class clsDalGeral : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public clsPessoa SelectUtimoIdPessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string buscarUtimoDadoInserido = "SELECT LAST_INSERT_ID() AS id;";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarUtimoDadoInserido, conServer);
                    dr.Read();
                    objPessoa.Id = Convert.ToInt32(dr[0].ToString());


                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarUtimoDadoInserido, conMySql);
                    dr.Read();
                    objPessoa.Id = Convert.ToInt32(dr[0].ToString());

                }

                return objPessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsServicos SelectUtimoIdServico(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string buscarUtimoDadoInserido = "SELECT LAST_INSERT_ID() AS id;";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarUtimoDadoInserido, conServer);
                    dr.Read();
                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());


                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarUtimoDadoInserido, conMySql);
                    dr.Read();
                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());

                }

                return objServico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
