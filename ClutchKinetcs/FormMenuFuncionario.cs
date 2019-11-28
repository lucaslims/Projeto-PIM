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
    public partial class FormMenuFuncionario : Form
    {
        private FormMenuPrincipal formMenuPrincipal;

        public FormMenuFuncionario(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
        }
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();

       /* public FormMenuFuncionario(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;
            InitializeComponent();
        }*/

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadFuncionario cadPessoa = new FormCadFuncionario();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }

        private void btnFecharMenuOpc_Click(object sender, EventArgs e)
        {
          
                menuPrincipal.floLayPnlMenSegundario.Controls.Clear();
            
        }
    }
}
