﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JuanJoseC.Forms
{
    public partial class FrmRegistroCompra : Form
    {
        public FrmRegistroCompra()
        {
            InitializeComponent();
        }

        private void FrmRegistroCompra_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;



        }
    }
}
