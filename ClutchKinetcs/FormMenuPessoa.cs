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
            menuPrincipal.pnlPrincipal.Controls.Clear();
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

        private void BtnCadastrarTipo_Click(object sender, EventArgs e)
        {

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
            //FormCo consPessoa = new FormDelPessoa();
            //consPessoa.TopLevel = false;
            //consPessoa.FormBorderStyle = FormBorderStyle.None;
            //menuPrincipal.pnlPrincipal.Controls.Clear();
            //menuPrincipal.pnlPrincipal.Controls.Add(consPessoa);
            //consPessoa.Show();
        }

        private void BtnConsultarLogin_Click(object sender, EventArgs e)
        {
            FormConLogin consLogin = new FormConLogin();
            consLogin.TopLevel = false;
            consLogin.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(consLogin);
            consLogin.Show();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            FormAttPessoa attPessoa = new FormAttPessoa();
            attPessoa.TopLevel = false;
            attPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(attPessoa);
            attPessoa.Show();
        }

        private void BtnAtualizarLogin_Click(object sender, EventArgs e)
        {
            FormAttLogin attLogin = new FormAttLogin();
            attLogin.TopLevel = false;
            attLogin.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(attLogin);
            attLogin.Show();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            FormDelPessoa delPessoa = new FormDelPessoa();
            delPessoa.TopLevel = false;
            delPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(delPessoa);
            delPessoa.Show();
        }

        private void BtnDeletarLogin_Click(object sender, EventArgs e)
        {
            FormDelLogin delLogin = new FormDelLogin();
            delLogin.TopLevel = false;
            delLogin.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(delLogin);
            delLogin.Show();
        }
    }
}
