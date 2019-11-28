using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control;
using System.Data.SqlClient;
namespace DAL
{
    public class clsDalFuncionario:SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();
        public bool InsertFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string inserirFuncionario = "insert into TB_CD_FUNCIONARIO  (ID_PESSOA,DEPARTAMENTO,CARGO " +
                                  " values (" + objFunc.Pessoa.Id + ", " +
                                          "'" + objFunc.Departamento.Id + "', " +
                                          "'" + objFunc.Cargo.Id + ");";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirFuncionario, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }/*
        public bool insertProcedureFuncionario(MySqlConnection conMySql, SqlConnection conServer, List<string> dadosViagem)
        {
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlCommand cmd = new SqlCommand("CADASTRAR_PESSOA_PF", conServer);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@P_nome", dadosViagem[0]);
                    cmd.Parameters.AddWithValue("@P_status", dadosViagem[1]);
                    cmd.Parameters.AddWithValue("@P_End_cep", dadosViagem[2]);
                    cmd.Parameters.AddWithValue("@P_End_logra", dadosViagem[3]);
                    cmd.Parameters.AddWithValue("@P_End_numero", dadosViagem[4]);
                    cmd.Parameters.AddWithValue("@P_End_compl", dadosViagem[5]);
                    cmd.Parameters.AddWithValue("@P_End_bairro", dadosViagem[6]);
                    cmd.Parameters.AddWithValue("@P_End_cidade", dadosViagem[7]);
                    cmd.Parameters.AddWithValue("@P_Ema_email", dadosViagem[8]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddi", dadosViagem[9]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddd", dadosViagem[10]);
                    cmd.Parameters.AddWithValue("@P_Tel_numero", dadosViagem[11]);
                    cmd.Parameters.AddWithValue("@P_PFi_cpf", dadosViagem[12]);
                    cmd.Parameters.AddWithValue("@P_PFi_rg", dadosViagem[13]);
                    cmd.Parameters.AddWithValue("@P_PFi_dt_nasc", Convert.ToDateTime(dadosViagem[14]).ToString("yyyy-MM-dd"));

                    ExecutarComandoProcSqlServer(cmd);
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_PESSOA_PF", conMySql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@P_nome", dadosPessoa[0]);
                    cmd.Parameters.AddWithValue("@P_status", dadosPessoa[1]);
                    cmd.Parameters.AddWithValue("@P_End_cep", dadosPessoa[2]);
                    cmd.Parameters.AddWithValue("@P_End_logra", dadosPessoa[3]);
                    cmd.Parameters.AddWithValue("@P_End_numero", dadosPessoa[4]);
                    cmd.Parameters.AddWithValue("@P_End_compl", dadosPessoa[5]);
                    cmd.Parameters.AddWithValue("@P_End_bairro", dadosPessoa[6]);
                    cmd.Parameters.AddWithValue("@P_End_cidade", dadosPessoa[7]);
                    cmd.Parameters.AddWithValue("@P_Ema_email", dadosPessoa[8]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddi", dadosPessoa[9]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddd", dadosPessoa[10]);
                    cmd.Parameters.AddWithValue("@P_Tel_numero", dadosPessoa[11]);
                    cmd.Parameters.AddWithValue("@P_PFi_cpf", dadosPessoa[12]);
                    cmd.Parameters.AddWithValue("@P_PFi_rg", dadosPessoa[13].ToString());
                    cmd.Parameters.AddWithValue("@P_PFi_dt_nasc", Convert.ToDateTime(dadosPessoa[14]).ToString("yyyy-MM-dd"));

                    ExecutarComandoProcSqlMySql(cmd);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
        public bool UpdateFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string atualizarFuncionario = "update TB_CD_FUNCIONARIO set ID_PESSOA = '" + objFunc.Pessoa.Id + "' , " +
                                                          " DEPARTAMENTO = '" + objFunc.Departamento.Id + "', " +
                                                          " CARGO = " + objFunc.Cargo.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarFuncionario, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string deletarFuncionario = "delete from TB_CD_FUNCIONARIO where ID_PESSOA = " + objFunc.Pessoa.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarFuncionario, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsFuncionario SelectFuncId(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFun)
        {
            string buscarFuncionarioId = "select * from TB_CD_FUNCIONARIO where ID_PESSOA=" + objFun.Pessoa.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarFuncionarioId, conServer);
                    dr.Read();
                    objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                    objFun.Cargo.Id =Convert.ToInt32(dr[2].ToString());

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarFuncionarioId, conMySql);
                    dr.Read();
                    objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                    objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());

                }

                return objFun;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsFuncionario> ListFuncionario(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosFuncionarios = "select * from TB_CD_FUNCIONARIO";
            List<clsFuncionario> ListaFuncionario = new List<clsFuncionario>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosFuncionarios, conServer);
                    while (dr.Read())
                    {
                        clsFuncionario objFun = new clsFuncionario();
                        objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                        objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
                        ListaFuncionario.Add(objFun);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosFuncionarios, conMySql);
                    while (dr.Read())
                    {
                        clsFuncionario objFun = new clsFuncionario();
                        objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                        objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
                        ListaFuncionario.Add(objFun);
                    }
                }

                return ListaFuncionario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
