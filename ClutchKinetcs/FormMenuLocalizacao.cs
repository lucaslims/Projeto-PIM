﻿using System;
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
    public partial class FormMenuLocalizacao : Form
    {
        private FormMenuPrincipal formMenuPrincipal;

        public FormMenuLocalizacao()
        {
            InitializeComponent();
        }

        public FormMenuLocalizacao(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;
            InitializeComponent();

        }
    }
}
