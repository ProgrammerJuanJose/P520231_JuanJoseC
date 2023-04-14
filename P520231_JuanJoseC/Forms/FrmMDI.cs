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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Globales.MiFormPregunta.Show();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Control para que el form no se abra varias veces si el usuario selecciona varias veces esta ventanilla

            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmusuariosGestion();

                Globales.MiFormGestionUsuarios.Show();
            }
                
        }
    }
}
