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
    public partial class FrmusuariosGestion : Form
    {
        public FrmusuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmusuariosGestion_Load(object sender, EventArgs e)
        {
            //Definir el padre mdi
            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();


        }

        private void CargarListaRoles()
        {
            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.ValueMember = "Descrip";
                CbRolesUsuario.DataSource = dt;   
                CbRolesUsuario.SelectedIndex = -1;

            }
            
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
