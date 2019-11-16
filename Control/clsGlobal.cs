using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class clsGlobal : SqlHelper
    {
        

        private string bdConexao;
        public string BdConexao { get => bdConexao; set => bdConexao = value; }


        /// <summary>
        ///  Metodos e Parametros a seguir para envio de log automatico
        /// </summary>
        private int idPessoa;
        private string nomePessoa;
        private string loginPessoa;
        private string senhaPessoa;
        private int idTipoPermissao;
        private string descTipoPermissao;
        
        protected void criaLogin(clsPessoa pessoa, clsLogin clsloginPessoa, clsTipoPermissao clsTipoPermissaoPessoa)
        {
            idPessoa = pessoa.Id;
            nomePessoa = pessoa.Nome;

            idTipoPermissao = clsTipoPermissaoPessoa.Id;
            descTipoPermissao = clsTipoPermissaoPessoa.Descricao;

            clsloginPessoa.Id_pessoa = pessoa;
            clsloginPessoa.Id_tipo_permissao = clsTipoPermissaoPessoa;
            loginPessoa = clsloginPessoa.Nome_login;
            senhaPessoa = clsloginPessoa.Senha_login;


        }

        public void InsereLog()
        {
            MySqlConnection connMySql;
            SqlConnection connSqlServer;

            connMySql = clsConexao.GetConexaoMySql();
            connSqlServer = clsConexao.GetConexaoSqlServer();

            try
            {
                if (BdConexao == "MySql")
                   AbrirConexaoMySql(connMySql);
                else if (BdConexao == "SqlServer")
                    AbrirConexaoSqlServer(connSqlServer);

                // Arrumar Envio de Log Automatico

            }
            catch (Exception ex) { throw ex; }
            finally { FecharConexaoMySql(connMySql); FecharConexaoSqlServer(connSqlServer); }
        }

    }
}
