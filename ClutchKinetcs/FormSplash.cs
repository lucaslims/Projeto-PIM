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

        public FormSplash()
        {
            InitializeComponent();


            bgWorkerIndeterminada.RunWorkerAsync();
            backgroundWorker1.RunWorkerAsync();

            //informa que a tarefa esta sendo executada.
            label1.Text = "Processando...";
            label3.Text = "Processando...";



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

        private void TarefaLonga2(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                Thread.Sleep(p);
                //label4.Text = "Tarefa: " + i.ToString() + " comcluída";
            }
        }

        private void ConexaoMySql()
        {
            DialogResult result = DialogResult.None;
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

        }

        private void ConexaoSqlServer()
        {
            DialogResult result = DialogResult.None;
            do
            {
                if (string.IsNullOrEmpty(varGlob.BdConexao))
                {
                    try
                    {
                        connSqlServer = clsConexao.GetConexaoSqlServer();
                        varGlob.AbrirConexaoSqlServer(connSqlServer);
                        MessageBox.Show("Conectado com SqlServer", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        varGlob.BdConexao = "SqlServer";
                    }
                    catch (SqlException) { result = MessageBox.Show("Sem conexao com o Sql Server \n\nTentar conectar-se novamente?", "ERRO DE CONEXÃO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
                    finally { varGlob.FecharConexaoSqlServer(connSqlServer); }
                }

            } while (result == DialogResult.Retry);
        }

        private void bgWorkerIndeterminada_DoWork(object sender, DoWorkEventArgs e)
        {
           
            //executa a tarefa a primeira vez
            //TarefaLonga(100);

            //Verifica se houve uma requisição para cancelar a operação.
            if (bgWorkerIndeterminada.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;
            }

            //executa a tarefa pela segunda vez
            //TarefaLonga(500);
            if (bgWorkerIndeterminada.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;
            }
        }

        private void bgWorkerIndeterminada_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            bunifuProgressBar1.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void bgWorkerIndeterminada_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Caso cancelado...
            if (e.Cancelled)
            {
                // reconfigura a progressbar para o padrao.
                //bunifuProgressBar1.MarqueeAnimationSpeed = 0;
                //bunifuProgressBar1.Style = ProgressBarStyle.Blocks;
                bunifuProgressBar1.Value = 0;

                //caso a operação seja cancelada, informa ao usuario.
                label2.Text = "Operação Cancelada pelo Usuário!";

                ////habilita o botao cancelar
                //btnCancelar.Enabled = true;
                //limpa a label
                label1.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                label2.Text = "Aconteceu um erro durante a execução do processo!";

                // reconfigura a progressbar para o padrao.
                //bunifuProgressBar1.MarqueeAnimationSpeed = 0;
                //bunifuProgressBar1.Style = ProgressBarStyle.Blocks;
                bunifuProgressBar1.Value = 0;
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                label2.Text = "Tarefa Concluida com sucesso!";

                //Carrega todo progressbar.
                //bunifuProgressBar1.MarqueeAnimationSpeed = 0;
                //bunifuProgressBar1.Style = ProgressBarStyle.Blocks;
                bunifuProgressBar1.Value = 100;
                label1.Text = bunifuProgressBar1.Value.ToString() + "%";
            }
        }








        /// <summary>
        /// //Aqui chamamos os nossos metodos com as tarefas demoradas.
        /// </summary>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)//representa uma tarefa com 100 processos.
            {
                //Executa o método longo 100 vezes.
                TarefaLonga2(20);
                //incrementa o progresso do backgroundWorker 
                //a cada passagem do loop.
                this.backgroundWorker1.ReportProgress(i);

                //Verifica se houve uma requisição para cancelar a operação.
                if (backgroundWorker1.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;

                    //zera o percentual de progresso do backgroundWorker1.
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            backgroundWorker1.ReportProgress(100);
        }

        /// <summary>
        /// Aqui implementamos o que desejamos fazer enquanto o progresso
        /// da tarefa é modificado,[incrementado].
        /// </summary>
        private void backgroundWorker1_ProgressChanged(object sender,
        ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            progressBar1.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            label3.Text = e.ProgressPercentage.ToString() + "%";
        }

        /// <summary>
        /// Após a tarefa ser concluida, esse metodo e chamado para
        /// implementar o que deve ser feito imediatamente após a conclusão da tarefa.
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender,
        RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                label2.Text = "Operação Cancelada pelo Usuário!";

                //limpa a label
                label3.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                label4.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                label4.Text = "Tarefa Concluida com sucesso!";
            }
        }

    }
}
