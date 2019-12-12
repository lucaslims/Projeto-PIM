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
    public partial class FormMenuServicos : Form
    {
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
     

        public FormMenuServicos(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
            
        }

     
        private void btnCadastroServ_Click(object sender, EventArgs e)
        {
            FormCadServico cadPessoa = new FormCadServico();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnConsultaServ_Click(object sender, EventArgs e)
        {
            FormConServico cadPessoa = new FormConServico();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnAtualizarServ_Click(object sender, EventArgs e)
        {
            FormAttServico cadPessoa = new FormAttServico();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnDeletarServ_Click(object sender, EventArgs e)
        {
            FormDelServico cadPessoa = new FormDelServico();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();

        }
    }
}
