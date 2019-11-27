using Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClutchKinetcs
{
    public partial class FormSplash : Form
    {
        MySqlConnection connMySql;
        SqlConnection connSqlServer;
        clsGlobal varGlob = new clsGlobal();
        bool teste = true;

        public FormSplash()
        {
            InitializeComponent();
            bckGroudWrkSplash.RunWorkerAsync();

            //informa que a tarefa esta sendo executada.
            label1.Text = "Processando...";
        }

        /// <summary>
        /// Simula uma tarefa que levará muito tempo para ser executada.
        /// </summary>
        /// <param name="tempo"> Um inteiro que representa o tempo a ser esperado.</param>
        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                Thread.Sleep(p);
                //label2.Text = "Tarefa: " + i.ToString() + " comcluída";
            }
        }

        private bool ConexaoMySql()
        {
            DialogResult result = DialogResult.OK;
            do
            {
                try
                {
                    connMySql = clsConexao.GetConexaoMySql();
                    varGlob.AbrirConexaoMySql(connMySql);
                    MessageBox.Show("Conectado com Mysql", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    varGlob.BdConexao = "MySql";
                }
                catch (MySqlException) { result = MessageBox.Show("Sem conexao com o: MySql\n\nTentar conectar-se novamente?", "ERRO DE CONEXÃO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
                finally { varGlob.FecharConexaoMySql(connMySql); }

            } while (result == DialogResult.Retry);

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        private bool ConexaoSqlServer()
        {
            DialogResult result = DialogResult.OK;
            do
            {
                try
                {
                    connSqlServer = clsConexao.GetConexaoSqlServer();
                    varGlob.AbrirConexaoSqlServer(connSqlServer);
                    result = MessageBox.Show("Conectado com SqlServer", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    varGlob.BdConexao = "SqlServer";
                }
                catch (SqlException) { result = MessageBox.Show("Sem conexao com o Sql Server \n\nTentar conectar-se novamente?", "ERRO DE CONEXÃO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
                finally { varGlob.FecharConexaoSqlServer(connSqlServer); }


            } while (result == DialogResult.Retry);

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        /// <summary>
        /// //Aqui chamamos os nossos metodos com as tarefas demoradas.
        /// </summary>
        private void bckGroudWrkSplash_DoWork(object sender, DoWorkEventArgs e)
        {
            bool connMy = true, connServer = true;

            for (int i = 0; i < 100; i++)//representa uma tarefa com 100 processos.
            {
                //Executa o método longo 100 vezes.
                TarefaLonga(7);
                //incrementa o progresso do backgroundWorker 
                //a cada passagem do loop.
                if (i == 48)
                    connMy = ConexaoMySql();
                if (i == 97)
                    connServer = ConexaoSqlServer();

                if (!connMy && !connServer)
                {
                    var result = MessageBox.Show("Não há nenhuma conexão com a base de dados disponiveis \n\nTentar novamente?", "ERRO DE CONEXÃO", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    if (result == DialogResult.Abort)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else if (result == DialogResult.Retry)
                    {
                        bckGroudWrkSplash.ReportProgress(100);
                        bckGroudWrkSplash_DoWork(sender, e);
                        i = 100;
                    }
                    else if (result == DialogResult.Ignore)
                    {
                        MessageBox.Show("Programa será iniciado sem conexão com as bases de dados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bckGroudWrkSplash.ReportProgress(100);
                        i = 100;
                    }
                }
                else if (connMy && connServer && i == 99)
                    teste = false;

                this.bckGroudWrkSplash.ReportProgress(i);
            }

            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            bckGroudWrkSplash.ReportProgress(100);
        }

        /// <summary>
        /// Aqui implementamos o que desejamos fazer enquanto o progresso
        /// da tarefa é modificado,[incrementado].
        /// </summary>
        private void bckGroudWrkSplash_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.

            bunifuProgressBar1.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        /// <summary>
        /// Após a tarefa ser concluida, esse metodo e chamado para
        /// implementar o que deve ser feito imediatamente após a conclusão da tarefa.
        /// </summary>
        private void bckGroudWrkSplash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                MessageBox.Show("Operação Cancelada pelo Usuário!");
                Close();
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Aconteceu um erro durante a execução do processo!");
            }
            else
            {
                if (teste)
                    NewFormLogin();
                else
                {
                    CaixaDialogoPersonalizada caixaDialogo = new CaixaDialogoPersonalizada();
                    caixaDialogo.Show();
                    this.Hide();
                }
            }
        }

        private void NewFormLogin()
        {
            //abrindo o form menu principal
            FormLogin frmLogin = new FormLogin(varGlob);
            //Ocuta o form
            this.Hide();
            //Muda a Opacidade do form menu principal para 0
            frmLogin.Opacity = 0;
            //Abre o form menu principal
            frmLogin.Show(this);
            //For para aumentar gradativamente a opacidade do form menu principal
            for (double i = 0; i <= 1; i += 0.1)
            {
                //Acrescenta em 0.1 a opacidade do form
                frmLogin.Opacity = i;
                //Atualizao form menu principal
                frmLogin.Refresh();
                //Limitador da velocidade que o form seguinte irá aparecer
                System.Threading.Thread.Sleep(70);
            }
        }
    }
}
