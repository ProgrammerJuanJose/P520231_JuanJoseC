using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JuanJoseC
{
    public static class Globales
    {
        //Estas propiedas al pertenecer a una clase static se auto instancian 
        //y se puede obtener acceso a ellas en la globalidad de la aplicación. 

        public static Form MiFormPrincipal = new Forms.FrmMDI();

        public static Forms.FrmUsuariosGestion MiFormGestionUsuarios = new Forms.FrmUsuariosGestion();

        //Debemos tener un obj de tipo Usuario que permita almacenar los datos del usuario
        //que se haya logueado correctamente 
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Forms.FrmRegistroCompra MiFormRegistroCompra = new Forms.FrmRegistroCompra();


    }
}
