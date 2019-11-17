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
    public class clsDalTelefone : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool insertTelefone(MySqlConnection conMySql, SqlConnection conServer, clsTelefone objTel)
        {
            string inserirTerlefone = "insert into TB_CD_PESSOA_TELEFONE (ID,ID_PESSOA,DDI,DDD,NUMERO) " +
                                  " values (" + objTel.Id + ", " +
                                          "" + objTel.Pessoa.Id + " " +
                                           "'" + objTel.Ddi + "'" +
                                            "'" + objTel.Ddd + "' " +

                                             "'" + objTel.Numero + "' " +
                                               //ACRESCENTAR O ID DA PESSOA


                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(inserirTerlefone, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(inserirTerlefone, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTelefone(MySqlConnection conMySql, SqlConnection conServer, clsTelefone objTel)
        {
            string atualizarTelefone = "update TB_CD_PESSOA_TELEFONE set DDI = '" + objTel.Ddi + "', " + "DDD=' " + objTel.Ddd + "'" +
                "NUMERO='" + objTel.Numero + "' where ID_PESSOA = " + objTel.Pessoa.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarTelefone, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarTelefone, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteTelefone(MySqlConnection conMySql, SqlConnection conServer, clsTelefone objTel)
        {
            string deletarTelefone = "delete from TB_CD_PESSOA_TELEFONE where ID_PESSOA = " + objTel.Pessoa.Id + " ;"; //verificar se está certo
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarTelefone, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarTelefone, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsTelefone SelectTelefoneID(MySqlConnection conMySql, SqlConnection conServer, clsTelefone objTel)
        {
            string buscarPessoa = "select * from TB_CD_PESSOA_TELEFONE where ID_PESSOA=" + objTel.Pessoa.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPessoa, conServer);
                    dr.Read();
                    objTel.Id = Convert.ToInt32(dr[0].ToString());
                    objTel.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objTel.Ddi = Convert.ToInt32(dr[2].ToString());
                    objTel.Ddd = Convert.ToInt32(dr[3].ToString());

                    objTel.Numero = Convert.ToInt32(dr[3].ToString());

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPessoa, conMySql);
                    dr.Read();
                    objTel.Id = Convert.ToInt32(dr[0].ToString());
                    objTel.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objTel.Ddi = Convert.ToInt32(dr[2].ToString());
                    objTel.Ddd = Convert.ToInt32(dr[3].ToString());

                    objTel.Numero = Convert.ToInt32(dr[3].ToString());

                }

                return objTel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /* public clsPessoaJuridica SelectPessoaJuridica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
         {
             string buscarModeloID = "select * from TB_CD_PESSOA_JURIDICA where PESSOA_FISICA_ID = '" + objPessoaJuridica.Id_pessoa_juridica + "'";

             try
             {
                 if (varGlob.BdConexao == "SqlServer")
                 {
                     SqlDataReader dr = RetornaDataReaderSqlServer(buscarModeloID, conServer);
                     dr.Read();
                     objPessoaJuridica.Id_pessoa_juridica = Convert.ToInt32(dr[0].ToString());
                     objPessoaJuridica.Cnpj = Convert.ToInt32(dr[1].ToString());
                     objPessoaJuridica.Inscricao_municipal = dr[2].ToString();
                     objPessoaJuridica.Inscricao_estadual = dr[3].ToString();

                     objPessoaJuridica.Id_Pessoa.Id = Convert.ToInt32(dr[3].ToString());
                 }
                 else if (varGlob.BdConexao == "MySql")
                 {
                     MySqlDataReader dr = RetornaDataReaderMySql(buscarModeloID, conMySql);
                     dr.Read();
                     objPessoaJuridica.Id_pessoa_juridica = Convert.ToInt32(dr[0].ToString());
                     objPessoaJuridica.Cnpj = Convert.ToInt32(dr[1].ToString());
                     objPessoaJuridica.Inscricao_municipal = dr[2].ToString();
                     objPessoaJuridica.Inscricao_estadual = dr[3].ToString();

                     objPessoaJuridica.Id_Pessoa.Id = Convert.ToInt32(dr[3].ToString());
                 }

                 return objPessoaJuridica;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         } */
        public List<clsTelefone> ListarTelefone(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosTelefones = "select * from TB_CD_PESSOA_JURIDICA";
            List<clsTelefone> listaTelefone = new List<clsTelefone>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosTelefones, conServer);
                    while (dr.Read())
                    {
                        clsTelefone objTel = new clsTelefone();
                        objTel.Id = Convert.ToInt32(dr[0].ToString());
                        objTel.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objTel.Ddi = Convert.ToInt32(dr[2].ToString());
                        objTel.Ddd = Convert.ToInt32(dr[3].ToString());

                        objTel.Numero = Convert.ToInt32(dr[3].ToString());
                        listaTelefone.Add(objTel);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosTelefones, conMySql);
                    while (dr.Read())
                    {
                        clsTelefone objTel = new clsTelefone();
                        objTel.Id = Convert.ToInt32(dr[0].ToString());
                        objTel.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objTel.Ddi = Convert.ToInt32(dr[2].ToString());
                        objTel.Ddd = Convert.ToInt32(dr[3].ToString());

                        objTel.Numero = Convert.ToInt32(dr[3].ToString());
                        listaTelefone.Add(objTel);
                    }
                }

                return listaTelefone;
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