using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClutchKinetcs
{
    public partial class FormMenuPessoa : Form
    {
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
        public FormMenuPessoa(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
        }

        private void BtnFecharMenuOpc_Click(object sender, EventArgs e)
        {
            menuPrincipal.floLayPnlMenSegundario.Controls.Clear();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            FormCadPessoa cadPessoa = new FormCadPessoa(menuPrincipal);
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnCadastrarLogin_Click(object sender, EventArgs e)
        {
            FormCadLogin cadLogin = new FormCadLogin();
            cadLogin.TopLevel = false;
            cadLogin.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadLogin);
            cadLogin.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarLogin_Click(object sender, EventArgs e)
        {
            FormConLogin conLogin = new FormConLogin();
            conLogin.TopLevel = false;
            conLogin.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(conLogin);
            conLogin.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletarLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
