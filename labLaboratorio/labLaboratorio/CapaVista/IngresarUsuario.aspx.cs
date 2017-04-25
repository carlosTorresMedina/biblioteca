using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labLaboratorio.CapaVista
{
    public partial class IngresarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = this.txtNombre.Text;
            String direccion = this.txtDireccion.Text;

            String telefono = this.txtTelefono.Text;
            String correo = this.txtCorreo.Text;
            String estado = this.txtEstado.Text;

            if (String.IsNullOrEmpty(codigo) || String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(direccion) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(correo) || String.IsNullOrEmpty(estado))
            {
                this.Msg.Text = "Llene todos los campos";
                return;
            }

          
          

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.ingresarUsuario(codigo, nombre, direccion, telefono, correo, estado);
           

            if (val)
            {
                this.Msg.Text = "Se registro el usuario con nombre= " + nombre;
                this.vaciar();
                return;
            }

            this.Msg.Text = "El usuario ya se encuentra registrado en el sistema";
        }

        private void vaciar() {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtEstado.Text = "";
        }
    }
}