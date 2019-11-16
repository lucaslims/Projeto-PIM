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
    public class clsDalPessoaJuridica :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool insertPessoaJuridica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
        {
            string inserirPessoa = "insert into TB_CD_PESSOA_JURIDICA (PESSOA_JURIDICA_ID,PESSOA_JURIDICA_CNPJ,PESSOA_JURIDICA_INCR_MUN,PESSOA_JURIDICA_INCR_EST,ID_PESSOA) " +
                                  " values (" + objPessoaJuridica.Id_pessoa_juridica + ", " +
                                          "" + objPessoaJuridica.Cnpj + " " +
                                           "" + objPessoaJuridica.Inscricao_municipal + "" +
                                            "" + objPessoaJuridica.Inscricao_estadual + " " +
                                           
                                             "" + objPessoaJuridica.Id_Pessoa.Id + " " +
                                               //ACRESCENTAR O ID DA PESSOA


                                               " );";

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
        public bool UpdatePessoaFisica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
        {
            string atualizarPessoaFisica = "update TB_CD_PESSOA_JURIDICA set  PESSOA_JURIDICA_CNPJ ='" + objPessoaJuridica.Cnpj + ", " + "PESSOA_JURIDICA_INCR_MUN=' " + objPessoaJuridica.Inscricao_municipal + "'" +
                "PESSOA_JURIDICA_INCR_EST='" + objPessoaJuridica.Inscricao_estadual +  "' where ID_PESSOA = " + objPessoaJuridica.Id_Pessoa.Id + " ;";
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
        public bool DeletePessoaJuridica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
        {
            string deletarPessoaJuridica = "delete from TB_CD_PESSOA_JURIDICA where ID_PESSOA = " + objPessoaJuridica.Id_Pessoa.Id + " ;"; //verificar se está certo
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarPessoaJuridica, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarPessoaJuridica, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPessoaJuridica SelectPessoaJuridicaId(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
        {
            string buscarPessoa = "select * from TB_CD_PESSOA_JURIDICA where ID_PESSOA=" + objPessoaJuridica.Id_Pessoa.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPessoa, conServer);
                    dr.Read();
                    objPessoaJuridica.Id_pessoa_juridica = Convert.ToInt32(dr[0].ToString());
                    objPessoaJuridica.Cnpj = Convert.ToInt32(dr[1].ToString());
                    objPessoaJuridica.Inscricao_municipal = dr[2].ToString();
                    objPessoaJuridica.Inscricao_estadual = dr[3].ToString();

                    objPessoaJuridica.Id_Pessoa.Id = Convert.ToInt32(dr[3].ToString());

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPessoa, conMySql);
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
        }
        public clsPessoaJuridica SelectPessoaJuridica(MySqlConnection conMySql, SqlConnection conServer, clsPessoaJuridica objPessoaJuridica)
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
        }
        public List<clsPessoaJuridica> ListarPessoaJuridica(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasPessoas = "select * from TB_CD_PESSOA_JURIDICA";
            List<clsPessoaJuridica> listaPessoa = new List<clsPessoaJuridica>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasPessoas, conServer);
                    while (dr.Read())
                    {
                        clsPessoaJuridica objPessoaJuridica = new clsPessoaJuridica();
                        objPessoaJuridica.Id_pessoa_juridica = Convert.ToInt32(dr[0].ToString());
                        objPessoaJuridica.Cnpj = Convert.ToInt32(dr[1].ToString());
                        objPessoaJuridica.Inscricao_municipal = dr[2].ToString();
                        objPessoaJuridica.Inscricao_estadual = dr[3].ToString();

                        objPessoaJuridica.Id_Pessoa.Id = Convert.ToInt32(dr[3].ToString());
                        listaPessoa.Add(objPessoaJuridica);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasPessoas, conMySql);
                    while (dr.Read())
                    {
                        clsPessoaJuridica objPessoaJuridica = new clsPessoaJuridica();
                        objPessoaJuridica.Id_pessoa_juridica = Convert.ToInt32(dr[0].ToString());
                        objPessoaJuridica.Cnpj = Convert.ToInt32(dr[1].ToString());
                        objPessoaJuridica.Inscricao_municipal = dr[2].ToString();
                        objPessoaJuridica.Inscricao_estadual = dr[3].ToString();

                        objPessoaJuridica.Id_Pessoa.Id = Convert.ToInt32(dr[3].ToString());
                        listaPessoa.Add(objPessoaJuridica);
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