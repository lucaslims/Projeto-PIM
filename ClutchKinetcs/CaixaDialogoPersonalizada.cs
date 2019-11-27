using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace ClutchKinetcs
{
    public partial class CaixaDialogoPersonalizada : Form
    {
        static clsGlobal global = new clsGlobal();
        public CaixaDialogoPersonalizada()
        {
            InitializeComponent();
        }


        private void NewFormLogin()
        {
            //abrindo o form menu principal
            FormLogin frmLogin = new FormLogin(global);
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

        private void btnSqlServer_Click(object sender, EventArgs e)
        {
            global.BdConexao = "SqlServer";
            NewFormLogin();
        }

        private void btnMySql_Click(object sender, EventArgs e)
        {
            global.BdConexao = "MySql";
            NewFormLogin();
        }
    }
}
