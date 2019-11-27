using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Control;
using System.Data;

namespace DAL
{
    public class clsDalVeiculo : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();
        public bool InsertVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string inserirveiculo = "insert into TB_CD_VEICULO  (ID,PLACA,CHASSI,DESCRICAO,COR_ID,MARCA_ID,MODELO_ID,TIPO_ID,STATUS_ID) " +
                                  " values (" + objVeiculo.Id + ", " + //ver com o Lucas sobre o campo
                                          "'" + objVeiculo.Placa_vec + "', " +
                                          "'" + objVeiculo.Chassi_vec + "', " +
                                          "'" + objVeiculo.Descricao + "'," +
                                                objVeiculo.Corveiculo.Id_cor +","+
                                                objVeiculo.Marcaveiculo.Id_marca+"," +
                                                objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo + "," +
                                                objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo +","+
                                                objVeiculo.Statusveiculo.Id_statusveiculo +"); ";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirveiculo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirveiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool insertVeiculoProcedure(MySqlConnection conMySql, SqlConnection conServer, List<string> dadosVeiculo)
        {
            try
            {
               
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlCommand cmd = new SqlCommand("CADASTRAR_VEICULO", conServer);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Veic_placa", dadosVeiculo[0]);
                    cmd.Parameters.AddWithValue("@V_Veic_chassi", dadosVeiculo[1]);
                    cmd.Parameters.AddWithValue("@V_Veic_descricao", dadosVeiculo[2]);
                    cmd.Parameters.AddWithValue("@V_Cor_descricao", dadosVeiculo[3]);
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosVeiculo[4]);
                    cmd.Parameters.AddWithValue("@V_Status_descricao", dadosVeiculo[5]);
                    cmd.Parameters.AddWithValue("@v_Emp_cnpj", Convert.ToInt64(dadosVeiculo[6]));
                   

                    ExecutarComandoProcSqlServer(cmd);
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_VEICULO", conMySql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Veic_placa", dadosVeiculo[0]);
                    cmd.Parameters.AddWithValue("@V_Veic_chassi", dadosVeiculo[1]);
                    cmd.Parameters.AddWithValue("@V_Veic_descricao", dadosVeiculo[2]);
                    cmd.Parameters.AddWithValue("@V_Cor_descricao", dadosVeiculo[3]);
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosVeiculo[4]);
                    cmd.Parameters.AddWithValue("@V_Status_descricao", dadosVeiculo[5]);
                    cmd.Parameters.AddWithValue("@v_Emp_cnpj", Convert.ToInt64(dadosVeiculo[6]));


                    ExecutarComandoProcSqlMySql(cmd);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("CADASTRAR_VEICULO", conMySql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@V_Veic_placa", dadosVeiculo[0]);
                    cmd.Parameters.AddWithValue("@V_Veic_chassi", dadosVeiculo[1]);
                    cmd.Parameters.AddWithValue("@V_Veic_descricao", dadosVeiculo[2]);
                    cmd.Parameters.AddWithValue("@V_Cor_descricao", dadosVeiculo[3]);
                    cmd.Parameters.AddWithValue("@V_Model_descricao", dadosVeiculo[4]);
                    cmd.Parameters.AddWithValue("@V_Status_descricao", dadosVeiculo[5]);
                    cmd.Parameters.AddWithValue("@v_Emp_cnpj", Convert.ToInt64(dadosVeiculo[6]));
                    ExecutarComandoProcSqlMySql(cmd);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateVeic(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string atualizarVeiculo = "update TB_CD_VEICULO set PLACA = '" + objVeiculo.Placa_vec + "', " + //CONFEERIR METODO
                                                          " CHASSI = '" + objVeiculo.Chassi_vec + "', " +
                                                          " DESCRICAO = '" + objVeiculo.Descricao + "', " +
                                                          " COR_ID = " + objVeiculo.Corveiculo .Id_cor+ ", " +
                                                          " MARCA_ID = " + objVeiculo.Marcaveiculo.Id_marca + ", " +
                                                          " MODELO_ID = " + objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo + ", " +
                                                          " TIPO_ID = " + objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo + ", " +
                                                          " STATUS_ID = " + objVeiculo.Statusveiculo.Id_statusveiculo + ", " +
                                                          " where ID = " + objVeiculo.Id + " ;";//ver com o Lucas ID
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarVeiculo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string deletarVeiculo = "delete from TB_CD_VEICULO where ID = " + objVeiculo.Placa_vec + " ;"; //Placa
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarVeiculo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsVeiculo SelectVeiculoId(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string buscarEstadoId = "select * from TB_CD_VEICULO where PLACA=" + objVeiculo.Placa_vec; //ID%PLACA

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEstadoId, conServer);
                    dr.Read();
                    objVeiculo.Id = Convert.ToInt32(dr[0].ToString());
                    objVeiculo.Placa_vec = dr[1].ToString();
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                    objVeiculo.Descricao = dr[3].ToString();
                    objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                    objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                    objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                    objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                    objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEstadoId, conMySql);
                    dr.Read();
                    objVeiculo.Id = Convert.ToInt32(dr[0].ToString());
                    objVeiculo.Placa_vec = dr[1].ToString();
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                    objVeiculo.Descricao = dr[3].ToString();
                    objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                    objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                    objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                    objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                    objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                }

                return objVeiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsVeiculo> ListVeiculos(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosVeiculos = "select * from TB_CD_VEICULO";
            List<clsVeiculo> listaVeiculos = new List<clsVeiculo>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosVeiculos, conServer);
                    while (dr.Read())
                    {
                        clsVeiculo objVeiculo = new clsVeiculo();
                        objVeiculo.Id = Convert.ToInt32(dr[0].ToString());
                        objVeiculo.Placa_vec = dr[1].ToString();
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                        objVeiculo.Descricao = dr[3].ToString();
                        objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                        objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                        objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                        objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                        objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                        listaVeiculos.Add(objVeiculo);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosVeiculos, conMySql);
                    while (dr.Read())
                    {
                        clsVeiculo objVeiculo = new clsVeiculo();
                        objVeiculo.Id = Convert.ToInt32(dr[0].ToString());
                        objVeiculo.Placa_vec = dr[1].ToString();
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                        objVeiculo.Descricao = dr[3].ToString();
                        objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                        objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                        objVeiculo.Marcaveiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                        objVeiculo.Marcaveiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                        objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                        listaVeiculos.Add(objVeiculo);
                    }
                }

                return listaVeiculos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
