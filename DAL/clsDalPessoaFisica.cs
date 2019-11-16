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
    public class clsDalPessoaFisica : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool insertPessoaFisica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaFisica objPessoaFisica)
        {
            string inserirPessoa = "insert into TB_CD_PESSOA_FISICA (PESSOA_FISICA_ID,PESSOA_FISICA_CPF,PESSOA_FISICA_RG,PESSOA_FISICA_DT_NASC,PESSOA_FISICA_CNH_ID,ID_PESSOA) " +
                                  " values (" + objPessoaFisica.Id +      " , " +
                                         "  " + objPessoaFisica.Cpf +     " , " +
                                         " '" + objPessoaFisica.Rg +      "', " +
                                         " '" + objPessoaFisica.Dt_nasc + "', " +
                                         " '" + objPessoaFisica.Cnh.Id_CNH +            "', " +
                                         "  " + objPessoaFisica.Id_pessoa.Id +          " );";

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
        public bool UpdatePessoaFisica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaFisica objPessoaFisica)
        {
            string atualizarPessoaFisica = "update TB_CD_PESSOA_FISICA set  PESSOA_FISICA_CPF= '" + objPessoaFisica.Cpf + ", " + "Pessoa_fisica_RG=' " + objPessoaFisica.Rg + "'" +
                "PESSOA_FISICA_DT_NASC='" + objPessoaFisica.Dt_nasc + "PESSOA_FISICA_CNH_ID='" + objPessoaFisica.Cnh.Id_CNH + "' where ID_PESSOA = " + objPessoaFisica.Id_pessoa.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarPessoaFisica, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarPessoaFisica, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeletePessoaFisica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaFisica objPessoaFisica)
        {
            string deletarPessoaFisica = "delete from TB_CD_PESSOA_FISICA where ID_PESSOA = " + objPessoaFisica.Id_pessoa.Id + " ;"; //verificar se está certo
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarPessoaFisica, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarPessoaFisica, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPessoaFisica SelectPessoaId(MySqlConnection conMySql, SqlConnection conServer, clsPessoaFisica objPessoaFisica)
        {
            string buscarPessoa = "select * from TB_CD_PESSOA_FISICA where ID_PESSOA=" + objPessoaFisica.Id_pessoa.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPessoa, conServer);
                    dr.Read();
                    objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                    objPessoaFisica.Cpf= Convert.ToInt32(dr[1].ToString());
                    objPessoaFisica.Rg= Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                    objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPessoa, conMySql);
                    dr.Read();
                    objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                    objPessoaFisica.Cpf = Convert.ToInt32(dr[1].ToString());
                    objPessoaFisica.Rg = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                    objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objPessoaFisica;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPessoaFisica SelectPessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoaFisica objPessoaFisica)
        {
            string buscarModeloID = "select * from TB_CD_PESSOA_FISICA where PESSOA_FISICA_ID = '" + objPessoaFisica.Id + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarModeloID, conServer);
                    dr.Read();
                    objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                    objPessoaFisica.Cpf = Convert.ToInt32(dr[1].ToString());
                    objPessoaFisica.Rg = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                    objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarModeloID, conMySql);
                    dr.Read();
                    objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                    objPessoaFisica.Cpf = Convert.ToInt32(dr[1].ToString());
                    objPessoaFisica.Rg = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                    objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                    objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objPessoaFisica;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsPessoaFisica> ListarPessoaFisica(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasPessoas = "select * from TB_CD_PESSOA_FISICA";
            List<clsPessoaFisica> listaPessoa = new List<clsPessoaFisica>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasPessoas, conServer);
                    while (dr.Read())
                    {
                        clsPessoaFisica objPessoaFisica = new clsPessoaFisica();
                        objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoaFisica.Cpf = Convert.ToInt32(dr[1].ToString());
                        objPessoaFisica.Rg = Convert.ToInt32(dr[2].ToString());
                        objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                        objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                        objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());
                        listaPessoa.Add(objPessoaFisica);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasPessoas, conMySql);
                    while (dr.Read())
                    {
                        clsPessoaFisica objPessoaFisica = new clsPessoaFisica();
                        objPessoaFisica.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoaFisica.Cpf = Convert.ToInt32(dr[1].ToString());
                        objPessoaFisica.Rg = Convert.ToInt32(dr[2].ToString());
                        objPessoaFisica.Dt_nasc = Convert.ToDateTime(dr[3].ToString());
                        objPessoaFisica.Cnh.Id_CNH = Convert.ToInt32(dr[2].ToString());
                        objPessoaFisica.Id_pessoa.Id = Convert.ToInt32(dr[3].ToString());
                        listaPessoa.Add(objPessoaFisica);
                    }
                }

                return listaPessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        public ComboBox PreencherComboBoxLogin(MySqlConnection conMySql, SqlConnection conServer, ComboBox _comboBox)
        {
            // Pesquisando Logins e guardando no Dataset
            DataTable dt = RetornaDataTable("Select * from tb_cd_login", conMySql, conServer);

            //Limpando a ComboBox
            _comboBox.Items.Clear();

            // For para selecionar linha no datatable e inserir na combobox definida pela função
            for (int r = 0; r < dt.Rows.Count; r++)
                // Comando para adicionar item na combobox definida pela função
                _comboBox.Items.Add(dt.Rows[r]["Nome_login"].ToString());

            // Caso retorne algum dado e seje adicionado na Combobox selecionar índice 0
            if (_comboBox.Items.Count > 0)
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;

            // Caso Não retorne nenhum dado adicionar um Item manualmente e selecionar índice 0
            else
            {
                // Comando para adicionar Item no combo
                _comboBox.Items.Add("Selecione um Login");
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;
            }

            return _comboBox;
        }
         */

    }
}