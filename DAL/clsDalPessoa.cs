using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control;
using System.Data;

namespace DAL
{
    public class clsDalPessoa : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        //Métodos -- executam os comandos SQL
        public bool InsertPessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string inserirPessoa = "insert into tb_cd_pessoa (nome,id_status) " +
                                        "values ('" + objPessoa.Nome + "' , " + objPessoa.StatusPessoa + " );";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirPessoa, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertPessoaPFProcedure(MySqlConnection conMySql, SqlConnection conServer, List<string> dadosPessoa)
        {
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlCommand cmd = new SqlCommand("CADASTRAR_PESSOA_PF", conServer);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@P_nome", dadosPessoa[0]);
                    cmd.Parameters.AddWithValue("@P_status", dadosPessoa[1]);
                    cmd.Parameters.AddWithValue("@P_PFi_cpf", dadosPessoa[2]);
                    cmd.Parameters.AddWithValue("@P_PFi_rg", dadosPessoa[3]);
                    cmd.Parameters.AddWithValue("@P_PFi_dt_nasc", "1999-12-12");
                    // cmd.Parameters.AddWithValue("@P_PFi_dt_nasc", Convert.ToDateTime(dadosPessoa[14]).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@P_End_cep", dadosPessoa[5]);
                    cmd.Parameters.AddWithValue("@P_End_logra", dadosPessoa[6]);
                    cmd.Parameters.AddWithValue("@P_End_numero", dadosPessoa[7]);
                    cmd.Parameters.AddWithValue("@P_End_compl", dadosPessoa[8]);
                    cmd.Parameters.AddWithValue("@P_End_bairro", dadosPessoa[9]);
                    cmd.Parameters.AddWithValue("@P_End_cidade", dadosPessoa[10]);
                    cmd.Parameters.AddWithValue("@P_Ema_email", dadosPessoa[11]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddi", dadosPessoa[12]);
                    cmd.Parameters.AddWithValue("@P_Tel_ddd", dadosPessoa[13]);
                    cmd.Parameters.AddWithValue("@P_Tel_numero", dadosPessoa[14]);
                    cmd.Parameters.AddWithValue("@P_Cel_ddi", dadosPessoa[15]);
                    cmd.Parameters.AddWithValue("@P_Cel_ddd", dadosPessoa[16]);
                    cmd.Parameters.AddWithValue("@P_Cel_numero", dadosPessoa[17]);

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
                else
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string alterarPessoa = " update tb_cd_pessoa set " +
                                        "     nome = " + objPessoa.Nome +
                                        "     id_status = " + objPessoa.StatusPessoa;
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(alterarPessoa, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(alterarPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeletePessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string deletarPessoa = "delete from tb_cd_pessoa where id = " + objPessoa.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarPessoa, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPessoa SelectPessoaId(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string buscarPessoaID = "select * from tb_cd_pessoa where id = " + objPessoa.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPessoaID, conServer);
                    dr.Read();
                    objPessoa.Nome = dr[1].ToString();
                    objPessoa.StatusPessoa.Id = Convert.ToInt32(dr[2].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPessoaID, conMySql);
                    dr.Read();
                    objPessoa.Nome = dr[1].ToString();
                    objPessoa.StatusPessoa.Id = Convert.ToInt32(dr[2].ToString());
                }

                return objPessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsPessoa> ListarPessoa(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasPessoas = "select * from tb_cd_pessoa";
            List<clsPessoa> listaPessoas = new List<clsPessoa>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasPessoas, conServer);
                    while (dr.Read())
                    {
                        clsPessoa objPessoa = new clsPessoa();
                        objPessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoa.Nome = dr[1].ToString();
                        objPessoa.StatusPessoa.Id = Convert.ToInt32(dr[2].ToString());
                        listaPessoas.Add(objPessoa);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasPessoas, conMySql);
                    while (dr.Read())
                    {
                        clsPessoa objPessoa = new clsPessoa();
                        objPessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoa.Nome = dr[1].ToString();
                        objPessoa.StatusPessoa.Id = Convert.ToInt32(dr[2].ToString());
                        listaPessoas.Add(objPessoa);
                    }
                }

                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
