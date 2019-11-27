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
            FormCadVeic cadPessoa = new FormCadVeic();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            FormConVeiculo cadPessoa = new FormConVeiculo();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void BtnCadastrarTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarModelo_Click(object sender, EventArgs e)
        {
            FormCadModelo cadPessoa = new FormCadModelo();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FormAttVeiculo cadPessoa = new FormAttVeiculo();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            FormDelVeiculo cadPessoa = new FormDelVeiculo();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }
    }
}
