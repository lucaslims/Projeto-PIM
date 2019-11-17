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
    public partial class FormConVeiculo : Form
    {
        public FormConVeiculo()
        {
            InitializeComponent();
        }

        private void AtualizarData(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Você tem certeza de que deseja atualizar esse dado?", "Opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
    
}
