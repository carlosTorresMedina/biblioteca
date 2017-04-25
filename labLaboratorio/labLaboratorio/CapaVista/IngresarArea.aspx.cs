using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labLaboratorio.CapaVista
{
    public partial class Area : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = this.txtNombre.Text;
            String tiempo = this.txtTiempo.Text;
            if(string.IsNullOrEmpty(codigo)|| string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tiempo)){
                this.Msg.Text = "Llene todos los campos";
                return;
            }
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.ingresarArea(codigo, nombre, tiempo);
            if (val) {
                this.Msg.Text = "Registro exitoso area con codigo = "+codigo ;
                this.vaciar();
                return;
            }

            this.Msg.Text = "El area ya se encuentra registrada";
        }

        private void vaciar() {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtTiempo.Text = "";
        }
    }
}