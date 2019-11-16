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
    public class clsDalServico :SqlHelper
    {
        clsGlobal varGlob = new clsGlobal();

        public bool InsertServico(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string insertServico = "insert into TB_NG_SERVICO (ID,TOTAL_ESTACIONAMENTOS,TOTAL_PEDAGIOS) " +
                                  " values (" + objServico.Id_servicos + ", " +
                                          "" + objServico.Total_estacionamento+ "," +
                                            "" + objServico.Total_pedagio + "" +
                                               " );";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(insertServico, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(insertServico, conMySql);
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateServico(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string atualizarServico = "update TB_NG_SERVICO set TOTAL_ESTACIONAMENTO = '" + objServico.Total_estacionamento +", TOTAL_PEDAGIO= "+ objServico.Total_pedagio+" where ID = " + objServico.Id_servicos + " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(atualizarServico, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(atualizarServico, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteSeguro(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string deletarServico = "delete from TB_NG_SERVICO where SERVICO_ID = " + objServico.Id_servicos+ " ;";
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                    ExecutarComandoSqlServer(deletarServico, conServer);
                else if (varGlob.BdConexao == "MySql")
                    ExecutarComandoMySql(deletarServico, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsServicos SelectServicoID(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string buscarMarca = "select * from TB_NG_SERVICO where SEGURO_ID=" + objServico.Id_servicos;

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarMarca, conServer);
                    dr.Read();

                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                    objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                    objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarMarca, conMySql);
                    dr.Read();
                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                    objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                    objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());

                }
                    return objServico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsServicos SelectServicoTotal(MySqlConnection conMySql, SqlConnection conServer, clsServicos objServico)
        {
            string buscarTotalID = "select * from TB_NG_SERVICO where TOTAL_ESTACIONAMENTOS = '" + objServico.Total_estacionamento + "'";

            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTotalID, conServer);
                    dr.Read();
                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                    objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                    objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTotalID, conMySql);
                    dr.Read();
                    objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                    objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                    objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());
                }

                return objServico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsServicos> listarServico(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosServicos = "select * from TB_NG_SERVICO";
            List<clsServicos> listaServico = new List<clsServicos>();
            try
            {
                if (varGlob.BdConexao == "SqlServer")
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosServicos, conServer);
                    while (dr.Read())
                    {
                        clsServicos objServico = new clsServicos();
                        objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                        objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                        objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());
                        listaServico.Add(objServico);
                    }
                }
                else if (varGlob.BdConexao == "MySql")
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosServicos, conMySql);
                    while (dr.Read())
                    {
                        clsServicos objServico = new clsServicos();
                        objServico.Id_servicos = Convert.ToInt32(dr[0].ToString());
                        objServico.Total_estacionamento = Convert.ToDouble(dr[1].ToString());
                        objServico.Total_pedagio = Convert.ToInt32(dr[0].ToString());
                        listaServico.Add(objServico);
                    }
                }

                return listaServico;
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

