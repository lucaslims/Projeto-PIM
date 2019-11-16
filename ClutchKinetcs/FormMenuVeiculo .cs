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
    public partial class FormMenuVeiculo : Form
    {
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
        public FormMenuVeiculo(FormMenuPrincipal frmAnt)
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

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
