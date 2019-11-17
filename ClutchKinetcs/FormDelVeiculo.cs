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
    public partial class FormDelVeiculo : Form
    {
        public FormDelVeiculo()
        {
            InitializeComponent();
        }

        private void DeletarCampo(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = new DialogResult();
            result= MessageBox.Show("Opção", "Você tem certeza de que deseja excluir esse dado?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
              
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
