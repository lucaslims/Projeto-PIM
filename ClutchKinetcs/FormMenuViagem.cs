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
    public partial class FormMenuViagem : Form
    {
        private FormMenuPrincipal formMenuPrincipal;

        public FormMenuViagem()
        {
            InitializeComponent();
        }
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();

        public FormMenuViagem(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;
            InitializeComponent();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadViagem cadPessoa = new FormCadViagem();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnCadastrarAbast_Click(object sender, EventArgs e)
        {
            FormCadAbast cadPessoa = new FormCadAbast();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormConViagem cadPessoa = new FormConViagem();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FormAttViagem cadPessoa = new FormAttViagem();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            FormDelViagem cadPessoa = new FormDelViagem();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }
    }
}
