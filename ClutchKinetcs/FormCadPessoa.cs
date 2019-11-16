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
    public partial class FormCadPessoa : Form
    {
        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();

        public FormCadPessoa(FormMenuPrincipal frmAnt)
        {
            this.menuPrincipal = frmAnt;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuPrincipal.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;

            if (menuPrincipal.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void FormCadPessoa_ParentChanged(object sender, EventArgs e)
        {
            if (menuPrincipal.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;

            if (menuPrincipal.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
