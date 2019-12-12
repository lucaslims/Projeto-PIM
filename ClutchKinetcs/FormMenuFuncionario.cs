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
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();

        public FormMenuFuncionario(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
        }

 

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FormAttFuncionario cadPessoa = new FormAttFuncionario();
            cadPessoa.TopLevel = false;
            cadPessoa.FormBorderStyle = FormBorderStyle.None;
            menuPrincipal.pnlPrincipal.Controls.Clear();
            menuPrincipal.pnlPrincipal.Controls.Add(cadPessoa);
            cadPessoa.Show();
        }
    }
}
