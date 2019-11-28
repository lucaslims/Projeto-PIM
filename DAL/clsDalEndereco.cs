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
    public class clsDalEndereco : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool insertEndereco(MySqlConnection conMySql, SqlConnection conServer, clsEndereco objEnd)
        {
            string inserirEndereco = "insert into TB_CD_PESSOA_ENDERECO (ID,ID_PESSOA,ID_CIDADE,LOGRADOURO,NUMERO, COMPLEMENTO,BAIRRO, CEP) " +
                                  " values (" + objEnd.Id + ", " +
                                         " '" + objEnd.Pessoa + "'," +
                                         " '" + objEnd.Cidade + "'," +
                                          " " + objEnd.Logradouro + ", " +
                                          " " + objEnd.Numero + ", " +
                                           " " + objEnd.Complemento + ", " +
                                            " " + objEnd.Bairro + ", " +
                                          " " + objEnd.Complemento + ");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirEndereco, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirEndereco, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEndereco(MySqlConnection conMySql, SqlConnection conServer, clsEndereco objEnd)
        {
            string atualizaEndereco = "update TB_CD_PESSOA_ENDERECO set  ID_PESSOA= " + objEnd.Pessoa.Id + ", " +
                                                              "ID_CIDADE= " + objEnd.Cidade.Id + ", " +
                                                              "LOGRADOURO=' " + objEnd.Logradouro + "',  " +
                                                              "NUMERO= " + objEnd.Numero + ",  " +
                                                              "COMPLEMENTO= " + objEnd.Complemento + ",  " +
                                                              "BAIRRO= " + objEnd.Bairro + ",  " +
                                                              "CEP= " + objEnd.Cep + ",  " +
                                                              " where ID = " + objEnd.Id + ";  ";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizaEndereco, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizaEndereco, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteEndereco(MySqlConnection conMySql, SqlConnection conServer, clsEndereco objEnd)
        {
            string deletarEndereco = "delete from TB_CD_PESSOA_ENDERECO where ID_PESSOA = " + objEnd.Pessoa.Id + " ;"; //verificar se está certo
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarEndereco, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarEndereco, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsEndereco SelectEndereco(MySqlConnection conMySql, SqlConnection conServer, clsEndereco objEnd)
        {
            string buscarEndereco = "select * from TB_CD_PESSOA_ENDERECO where ID_PESSOA=" + objEnd.Pessoa.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEndereco, conServer);
                    dr.Read();
                    objEnd.Id = Convert.ToInt32(dr[0].ToString());
                    objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                    objEnd.Logradouro = dr[3].ToString();
                    objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                    objEnd.Complemento = dr[5].ToString();
                    objEnd.Bairro = dr[6].ToString();
                    objEnd.Cep = dr[7].ToString();


                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEndereco, conMySql);
                    dr.Read();

                    objEnd.Id = Convert.ToInt32(dr[0].ToString());
                    objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                    objEnd.Logradouro = dr[3].ToString();
                    objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                    objEnd.Complemento = dr[5].ToString();
                    objEnd.Bairro = dr[6].ToString();
                    objEnd.Cep = dr[7].ToString();
                }

                return objEnd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsEndereco SelectEnderecoId(MySqlConnection conMySql, SqlConnection conServer, clsEndereco objEnd)
        {
            string buscarEnderecoId = "select * from TB_CD_PESSOA_ENDERECO where ID = " + objEnd.Id + "";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEnderecoId, conServer);
                    dr.Read();
                    objEnd.Id = Convert.ToInt32(dr[0].ToString());
                    objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                    objEnd.Logradouro = dr[3].ToString();
                    objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                    objEnd.Complemento = dr[5].ToString();
                    objEnd.Bairro = dr[6].ToString();
                    objEnd.Cep = dr[7].ToString();
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEnderecoId, conMySql);
                    dr.Read();
                    objEnd.Id = Convert.ToInt32(dr[0].ToString());
                    objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                    objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                    objEnd.Logradouro = dr[3].ToString();
                    objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                    objEnd.Complemento = dr[5].ToString();
                    objEnd.Bairro = dr[6].ToString();
                    objEnd.Cep = dr[7].ToString();
                }

                return objEnd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsEndereco> ListarEndereco(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosEnderecos = "select * from TB_CD_PESSOA_ENDERECO";
            List<clsEndereco> listaEnderecos = new List<clsEndereco>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosEnderecos, conServer);
                    while (dr.Read())
                    {
                        clsEndereco objEnd = new clsEndereco();
                        objEnd.Id = Convert.ToInt32(dr[0].ToString());
                        objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                        objEnd.Logradouro = dr[3].ToString();
                        objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                        objEnd.Complemento = dr[5].ToString();
                        objEnd.Bairro = dr[6].ToString();
                        objEnd.Cep = dr[7].ToString();
                        listaEnderecos.Add(objEnd);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosEnderecos, conMySql);
                    while (dr.Read())
                    {
                        clsEndereco objEnd = new clsEndereco();
                        objEnd.Id = Convert.ToInt32(dr[0].ToString());
                        objEnd.Pessoa.Id = Convert.ToInt32(dr[1].ToString());
                        objEnd.Cidade.Id = Convert.ToInt32(dr[2].ToString());
                        objEnd.Logradouro = dr[3].ToString();
                        objEnd.Numero = Convert.ToInt32(dr[4].ToString());
                        objEnd.Complemento = dr[5].ToString();
                        objEnd.Bairro = dr[6].ToString();
                        objEnd.Cep = dr[7].ToString();
                        listaEnderecos.Add(objEnd);
                    }
                }

                return listaEnderecos;
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