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

        public FormMenuFuncionario()
        {
            InitializeComponent();
        }

        public FormMenuFuncionario(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
