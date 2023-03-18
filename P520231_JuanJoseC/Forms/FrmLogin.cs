using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerContrasennia_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = false;
        }

        private void btnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Hay que vaidar el usuario
            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
