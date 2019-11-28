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
    public class clsDalTipoPermissao : SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool TB_CD_TIPO_PERMISSAO(MySqlConnection conMySql, SqlConnection conServer, clsTipoPermissao objTipo)
        {
            string insertTipo = "insert into TB_CD_TIPO_PERMISSAO (ID,DESCRICAO) " +
                                  " values (" + objTipo.Id + ", " +
                                          "'" + objTipo.Descricao + "' " +
                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(insertTipo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(insertTipo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTipoPerm(MySqlConnection conMySql, SqlConnection conServer, clsTipoPermissao objTipo)
        {
            string atualizaTipo = "update TB_CD_TIPO_PERMISSAO set DESCRICAO = '" + objTipo.Descricao + " where id = " + objTipo.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizaTipo, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizaTipo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteStatus(MySqlConnection conMySql, SqlConnection conServer, clsTipoPermissao objTipo)
        {
            string deletarStatus = "delete from TB_CD_TIPO_PERMISSAO where ID = " + objTipo.Id + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarStatus, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarStatus, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsTipoPermissao SelectTipo(MySqlConnection conMySql, SqlConnection conServer, clsTipoPermissao objTipos)
        {
            string buscarTipo = "select * from TB_CD_TIPO_PERMISSAO where ID=" + objTipos.Id;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTipo, conServer);
                    dr.Read();
                    objTipos.Id = Convert.ToInt32(dr[0].ToString());
                    objTipos.Descricao = dr[1].ToString();

                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTipo, conMySql);
                    dr.Read();
                    objTipos.Id = Convert.ToInt32(dr[0].ToString());
                    objTipos.Descricao = dr[1].ToString();
                }
                return objTipos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*   public clsSeguro SelectSeguroDesc(MySqlConnection conMySql, SqlConnection conServer, clsSeguro objSeguro)
           {
               string buscarSeguroID = "select * from TB_SEGURO where SEGURO_DESC = '" + objSeguro.Desc_seguro + "'";

               try
               {
                   if (varGlob.BdConexao == "SqlServer")
                   {
                       SqlDataReader dr = RetornaDataReaderSqlServer(buscarSeguroID, conServer);
                       dr.Read();
                       objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                       objSeguro.Desc_seguro = dr[1].ToString();
                   }
                   else if (varGlob.BdConexao == "MySql")
                   {
                       MySqlDataReader dr = RetornaDataReaderMySql(buscarSeguroID, conMySql);
                       dr.Read();
                       objSeguro.Id_seguro = Convert.ToInt32(dr[0].ToString());
                       objSeguro.Desc_seguro = dr[1].ToString();
                   }

                   return objSeguro;
               }
               catch (Exception ex)
               {
                   throw ex;
               }
           } */
        public List<clsTipoPermissao> ListarTipos(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasPermissoes = "select * from TB_CD_TIPO_PERMISSAO";
            List<clsTipoPermissao> listaTipo = new List<clsTipoPermissao>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasPermissoes, conServer);
                    while (dr.Read())
                    {
                        clsTipoPermissao objTipos = new clsTipoPermissao();
                        objTipos.Id = Convert.ToInt32(dr[0].ToString());
                        objTipos.Descricao = dr[1].ToString();
                        listaTipo.Add(objTipos);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasPermissoes, conMySql);
                    while (dr.Read())
                    {
                        clsTipoPermissao objTipos = new clsTipoPermissao();
                        objTipos.Id = Convert.ToInt32(dr[0].ToString());
                        objTipos.Descricao = dr[1].ToString();
                        listaTipo.Add(objTipos);
                    }
                }

                return listaTipo;
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
