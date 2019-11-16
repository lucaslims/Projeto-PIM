﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control;
using System.Data.SqlClient;

   public class clsDalPais :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();
    public bool InsertPais(MySqlConnection conMySql, SqlConnection conServer, clsPais objPais)
    {
        string inserirPais = "insert into TB_CD_PAIS  (id,descricao,ABREVIACAO) " +
                              " values (" + objPais.Id + ", " +
                                      "'" + objPais.Descricao + "', " +
                                      "'" + objPais.Abreviacao +");";

        try
        {
            if (varGlob.BdConexao == "SqlServer")
                ExecutarComandoSqlServer(inserirPais, conServer);
            else if (varGlob.BdConexao == "MySql")
                ExecutarComandoMySql(inserirPais, conMySql);

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public bool UpdatePais(MySqlConnection conMySql, SqlConnection conServer, clsPais objPais)
    {
        string atualizarPais = "update TB_CD_PAIS set ID = '" + objPais.Id + "' , " +
                                                      " DESCRICAO = '" + objPais.Descricao + "', " +
                                                      " ABREVIACAO = " + objPais.Abreviacao  + " ;";
        try
        {
            if (varGlob.BdConexao == "SqlServer")
                ExecutarComandoSqlServer(atualizarPais, conServer);
            else if (varGlob.BdConexao == "MySql")
                ExecutarComandoMySql(atualizarPais, conMySql);

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public bool DeletePais(MySqlConnection conMySql, SqlConnection conServer, clsPais objPais)
    {
        string deletarPais = "delete from TB_CD_PAIS where id = " + objPais.Id + " ;";
        try
        {
            if (varGlob.BdConexao == "SqlServer")
                ExecutarComandoSqlServer(deletarPais, conServer);
            else if (varGlob.BdConexao == "MySql")
                ExecutarComandoMySql(deletarPais, conMySql);

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public clsPais SelectPaisId(MySqlConnection conMySql, SqlConnection conServer, clsPais objPais)
    {
        string buscarPaisId = "select * from TB_CD_PAIS where id=" + objPais.Id;

        try
        {
            if (varGlob.BdConexao == "SqlServer")
            {
                SqlDataReader dr = RetornaDataReaderSqlServer(buscarPaisId, conServer);
                dr.Read();
                objPais.Id = Convert.ToInt32(dr[0].ToString());
                objPais.Descricao = dr[1].ToString();
                objPais.Abreviacao = dr[2].ToString();

            }
            else if (varGlob.BdConexao == "MySql")
            {
                MySqlDataReader dr = RetornaDataReaderMySql(buscarPaisId, conMySql);
                dr.Read();
                objPais.Id = Convert.ToInt32(dr[0].ToString());
                objPais.Descricao = dr[1].ToString();
                objPais.Abreviacao = dr[2].ToString();

            }

            return objPais;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public List<clsPais> ListarPais(MySqlConnection conMySql, SqlConnection conServer)
    {
        string buscarTodosPais = "select * from TB_CD_PAIS";
        List<clsPais> listaPais = new List<clsPais>();
        try
        {
            if (varGlob.BdConexao == "SqlServer")
            {
                SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosPais, conServer);
                while (dr.Read())
                {
                    clsPais objPais = new clsPais();
                    objPais.Id = Convert.ToInt32(dr[0].ToString());
                    objPais.Descricao = dr[1].ToString();
                    objPais.Abreviacao = dr[2].ToString();
                    listaPais.Add(objPais);
                }
            }
            else if (varGlob.BdConexao == "MySql")
            {
                MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosPais, conMySql);
                while (dr.Read())
                {
                    clsPais objPais = new clsPais();
                    objPais.Id = Convert.ToInt32(dr[0].ToString());
                    objPais.Descricao = dr[1].ToString();
                    objPais.Abreviacao = dr[2].ToString();
                    listaPais.Add(objPais);
                }
            }

            return listaPais;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
