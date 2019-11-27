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
    public partial class FormMenuLocacao : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
        public FormMenuLocacao()
        {
            InitializeComponent();
        }

        public FormMenuLocacao(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;
            InitializeComponent();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadLocacao cadPessoa = new FormCadLocacao();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormConLocacao cadPessoa = new FormConLocacao();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FormAttLocacao cadPessoa = new FormAttLocacao();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }
    }
}
