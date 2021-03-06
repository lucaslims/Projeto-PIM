﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Control;
using Model;

namespace ClutchKinetcs
{
    public partial class FormMenuPrincipal : Form
    {
        int X = 0;
        int Y = 0;

        static clsGlobal varglob = new clsGlobal();

        Point pointlbl = new Point();
         
        private void pnlOpcSW_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void pnlOpcSW_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        FormLogin frmLogin = new FormLogin(varglob);
        clsLogin pessoaLogin = new clsLogin();
        clsPessoa pessoaLogada = new clsPessoa();

        private void TrocaBotoesMaximizeNormalWinState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnNormalState.Visible = false;
                this.btnNormalState.Enabled = false;
                this.btnMaximizeState.Visible = true;
                this.btnMaximizeState.Enabled = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaximizeState.Visible = false;
                this.btnMaximizeState.Enabled = false;
                this.btnNormalState.Visible = true;
                this.btnNormalState.Enabled = true;
               
            }
        }

        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(pnlOpcSW_MouseDown);
            this.MouseMove += new MouseEventHandler(pnlOpcSW_MouseMove);
            TrocaBotoesMaximizeNormalWinState();
        }
        public FormMenuPrincipal(FormLogin formAnt)
        {
            InitializeComponent();
            formAnt = frmLogin;
            this.MouseDown += new MouseEventHandler(pnlOpcSW_MouseDown);
            this.MouseMove += new MouseEventHandler(pnlOpcSW_MouseMove);
            TrocaBotoesMaximizeNormalWinState();
        }
        public FormMenuPrincipal(FormLogin formAnt, clsPessoa pessoaLogada)
        {
            formAnt = frmLogin;
            this.pessoaLogada = pessoaLogada;
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(pnlOpcSW_MouseDown);
            this.MouseMove += new MouseEventHandler(pnlOpcSW_MouseMove);
            //TrocaBotoesMaximizeNormalWinState();
            lblNomeUser.Text = pessoaLogada.Nome;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.conexaoBD;
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            MySqlDataReader dr;

            lblNomeUser.Text = pessoaLogada.Nome;
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnPessoas, "Gerenciamento de Pessoas");
            toolTip1.SetToolTip(this.btnVeiculos, "Gerenciamento de Veiculos");
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            //Define a hora atual na label
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnFecharSW_Click(object sender, EventArgs e)
        {
            //Finaliza a aplicação
            Application.Exit();
        }

        private void BtnNormalState_Click(object sender, EventArgs e)
        {
            TrocaBotoesMaximizeNormalWinState();
        }

        private void BtnMaximizeState_Click(object sender, EventArgs e)
        {
            TrocaBotoesMaximizeNormalWinState();
        }

        private void BtnMinimizedState_Click(object sender, EventArgs e)
        {
            //minimiza o sistema
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }

        private void BtnPessoas_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuPessoa menuPessoa = new FormMenuPessoa(this);
            //define q o menu de opções não será o form principal
            menuPessoa.TopLevel = false;
            //retira a borda do menu opc
            menuPessoa.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuPessoa);
            //exibe o menu de opções
            menuPessoa.Show();
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuVeiculo menuVeiculo = new FormMenuVeiculo(this);
            //define q o menu de opções não será o form principal
            menuVeiculo.TopLevel = false;
            //retira a borda do menu opc
            menuVeiculo.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuVeiculo);
            //exibe o menu de opções
            menuVeiculo.Show();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuFuncionario menuFunc = new FormMenuFuncionario(this);
            //define q o menu de opções não será o form principal
            menuFunc.TopLevel = false;
            //retira a borda do menu opc
            menuFunc.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuFunc);
            //exibe o menu de opções
            menuFunc.Show();
        }

        private void BtnLocacao_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuLocacao menuLocacao = new FormMenuLocacao(this);
            //define q o menu de opções não será o form principal
            menuLocacao.TopLevel = false;
            //retira a borda do menu opc
            menuLocacao.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuLocacao);
            //exibe o menu de opções
            menuLocacao.Show();
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuServicos menuServ = new FormMenuServicos(this);
            //define q o menu de opções não será o form principal
            menuServ.TopLevel = false;
            //retira a borda do menu opc
            menuServ.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuServ);
            //exibe o menu de opções
            menuServ.Show();
        }

        private void BtnLocalizacao_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuLocalizacao menuLocalizacao = new FormMenuLocalizacao(this);
            //define q o menu de opções não será o form principal
            menuLocalizacao.TopLevel = false;
            //retira a borda do menu opc
            menuLocalizacao.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuLocalizacao);
            //exibe o menu de opções
            menuLocalizacao.Show();
        }

        private void BtnRota_Click(object sender, EventArgs e)
        {
            //Cria instancia do menu de opcoes
            FormMenuViagem menuViagem = new FormMenuViagem(this);
            //define q o menu de opções não será o form principal
            menuViagem.TopLevel = false;
            //retira a borda do menu opc
            menuViagem.FormBorderStyle = FormBorderStyle.None;
            //limpa o Flow Layout Panel
            floLayPnlMenSegundario.Controls.Clear();
            //Adiciona a instancia do menu de opcoes
            floLayPnlMenSegundario.Controls.Add(menuViagem);
            //exibe o menu de opções
            menuViagem.Show();
        }

        private void pnlOpcSW_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TrocaBotoesMaximizeNormalWinState();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
