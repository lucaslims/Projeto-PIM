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
    class clsDalEstacionamento :SqlHelper
    {
        public bool InsertEstacionamento(MySqlConnection conMySql, SqlConnection conServer, clsEstacionamento objEstacionamento)
        {
            string inserirEstacionamento = "insert into TB_NG_ESTACIONAMENTO  (ID,VALOR,QUANTIDADE,SERVICOS_ID) " +
                                  " values (" + objEstacionamento.Id + ", " +
                                          "" + objEstacionamento.Valor + ", " +
                                          " " + objEstacionamento.Quantidade + ", " +
                                                objEstacionamento.Servicos.Id_servicos+");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirEstacionamento, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirEstacionamento, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEstacionamento(MySqlConnection conMySql, SqlConnection conServer, clsEstacionamento objEstacionamento)
        {
            string atualizarLogin = "update TB_NG_ESTACIONAMENTO set ID = '" + objEstacionamento.Id + "' , " +
                                                          " VALOR = " + objEstacionamento.Valor + "', " +
                                                          " QUANTIDADE = " + objEstacionamento.Quantidade + ", " +
                                                          " SERVICO_ID = " + objEstacionamento.Servicos.Id_servicos +
                                                          " where ID = " + objEstacionamento.Servicos.Id_servicos + " ;"; //LUCAS
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarLogin, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarLogin, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteEstacionamento(MySqlConnection conMySql, SqlConnection conServer, clsEstacionamento objEstacionamento)
        {
            string deleteEstacionamento = "delete from TB_NG_ESTACIONAMENTO where ID = " + objEstacionamento.Servicos.Id_servicos + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deleteEstacionamento, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deleteEstacionamento, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsEstacionamento SelectEstacionamento(MySqlConnection conMySql, SqlConnection conServer, clsEstacionamento objEstacionamento)
        {
            string buscarEstacionamentoID = "select * from TB_NG_ESTACIONAMENTO where ID=" + objEstacionamento.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEstacionamentoID, conServer);
                    dr.Read();
                    objEstacionamento.Id = Convert.ToInt32(dr[0].ToString());
                    objEstacionamento.Valor =Convert.ToInt32( dr[1].ToString());
                    objEstacionamento.Quantidade=Convert.ToInt32( dr[2].ToString());
                    objEstacionamento.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                   
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEstacionamentoID, conMySql);
                    dr.Read();
                    objEstacionamento.Id = Convert.ToInt32(dr[0].ToString());
                    objEstacionamento.Valor = Convert.ToInt32(dr[1].ToString());
                    objEstacionamento.Quantidade = Convert.ToInt32(dr[2].ToString());
                    objEstacionamento.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                }

                return objEstacionamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsEstacionamento> ListEstacionamento(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosEstacionamento = "select * from TB_NG_ESTACIONAMENTO";
            List<clsEstacionamento> listaEstacionamento = new List<clsEstacionamento>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosEstacionamento, conServer);
                    while (dr.Read())
                    {
                        clsEstacionamento objEstacionamento = new clsEstacionamento();
                        objEstacionamento.Id = Convert.ToInt32(dr[0].ToString());
                        objEstacionamento.Valor = Convert.ToInt32(dr[1].ToString());
                        objEstacionamento.Quantidade = Convert.ToInt32(dr[2].ToString());
                        objEstacionamento.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaEstacionamento.Add(objEstacionamento);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosEstacionamento, conMySql);
                    while (dr.Read())
                    {
                        clsEstacionamento objEstacionamento = new clsEstacionamento();
                        objEstacionamento.Id = Convert.ToInt32(dr[0].ToString());
                        objEstacionamento.Valor = Convert.ToInt32(dr[1].ToString());
                        objEstacionamento.Quantidade = Convert.ToInt32(dr[2].ToString());
                        objEstacionamento.Servicos.Id_servicos = Convert.ToInt32(dr[3].ToString());
                        listaEstacionamento.Add(objEstacionamento);
                    }
                }

                return listaEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}