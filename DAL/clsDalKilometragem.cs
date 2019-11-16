using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DAL
{
    public class clsDalKilometragem :SqlHelper
    {
        public bool InsertKilometragem(MySqlConnection conMySql, SqlConnection conServer, clsKilometragem objKilo)
        {
            string inserirKilometragem = "insert into TB_NG_KILOMETRAGEM  (ID,TOTAL,VIAGEM_ID " +
                                  " values (" + objKilo.Id + ", " +
                                          "" + objKilo.Total + ", " +
                                          "" + objKilo.Viagem.Id_viagem + ");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirKilometragem, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirKilometragem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateKilometragem(MySqlConnection conMySql, SqlConnection conServer, clsKilometragem objKilo)
        {
            string atualizarKilometragem = "update TB_NG_KILOMETRAGEM set ID = '" + objKilo.Id + "' , " +
                                                          " TOTAL = '" + objKilo.Total + "', " +
                                                          " VIAGEM = " + objKilo.Viagem + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarKilometragem, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarKilometragem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteKilometragem(MySqlConnection conMySql, SqlConnection conServer, clsKilometragem objKilo)
        {
            string deletarKilometragem = "delete from TB_NG_KILOMETRAGEM where ID = " + objKilo.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarKilometragem, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarKilometragem, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public clsKilometragem SelectFuncId(MySqlConnection conMySql, SqlConnection conServer, clsKilometragem objKilo)
        //{
        //    string buscarFuncionarioId = "select * from TB_CD_FUNCIONARIO where ID_PESSOA=" + objFun.Pessoa.Id;

        //    try
        //    {
        //        if (conMySql is null)
        //        {
        //            SqlDataReader dr = RetornaDataReaderSqlServer(buscarFuncionarioId, conServer);
        //            dr.Read();
        //            objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
        //            objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
        //            objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());

        //        }
        //        else if (conServer is null)
        //        {
        //            MySqlDataReader dr = RetornaDataReaderMySql(buscarFuncionarioId, conMySql);
        //            dr.Read();
        //            objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
        //            objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
        //            objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());

        //        }

        //        return objFun;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public List<clsKilometragem> ListFuncionario(MySqlConnection conMySql, SqlConnection conServer)
        //{
        //    string buscarTodosFuncionarios = "select * from TB_CD_FUNCIONARIO";
        //    List<clsKilometragem> ListaFuncionario = new List<clsKilometragem>();
        //    try
        //    {
        //        if (conMySql is null)
        //        {
        //            SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosFuncionarios, conServer);
        //            while (dr.Read())
        //            {
        //                clsFuncionario objFun = new clsFuncionario();
        //                objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
        //                objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
        //                objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
        //                ListaFuncionario.Add(objFun);
        //            }
        //        }
        //        else if (conServer is null)
        //        {
        //            MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosFuncionarios, conMySql);
        //            while (dr.Read())
        //            {
        //                clsFuncionario objFun = new clsFuncionario();
        //                objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
        //                objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
        //                objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
        //                ListaFuncionario.Add(objFun);
        //            }
        //        }

        //        return ListaFuncionario;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}

