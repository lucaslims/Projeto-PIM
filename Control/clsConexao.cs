using System;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Control
{
    public class clsConexao
    {
        //Atributo
        private static SqlConnection con;

        private static MySqlConnection conn;

         private static string caminhoSqlServer = @"Server=DESKTOP-U26BJ62\SQLEXPRESS;Database=CLUTCH_KINETCS;User Id= sa; Password=root";
       // private static string caminhoSqlServer = @"Data Source = PC-LUCAS; Initial catalog = CLUTCH_KINETCS; Integrated Security = True;Connect Timeout=5";
        
        private static string caminhoMySql = @"server=localhost; database=CLUTCH_KINETCS; uid=root; password=root;Connect Timeout=5";

        private static string caminhoMySqlOnline = @"server='mysqlconnectionaws.cfc2tcexvysf.sa-east-1.rds.amazonaws.com'; Port=3306; Database=clutch_Kinetics; uid='admin'; pwd='rootroot';Protocol=tcp;Connect Timeout=10";

        public static SqlConnection GetConexaoSqlServer()
        {
            try
            {
                con = new SqlConnection(caminhoSqlServer);
                return con;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static MySqlConnection GetConexaoMySql()
        {
            try
            {
                conn = new MySqlConnection(caminhoMySql);
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
