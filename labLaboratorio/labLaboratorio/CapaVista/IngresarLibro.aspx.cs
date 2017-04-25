using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class IngresarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem oItem = new ListItem("no seleccion", "no seleccion");
            this.dArea.Items.Add(oItem);
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarAreas();
            foreach (DataRow dr in datos.Tables["Areas"].Rows)
            {
                ListItem Item = new ListItem(dr["areCodigo"].ToString(), dr["areCodigo"].ToString());
                this.dArea.Items.Add(Item);


            }
        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = this.txtNombre.Text;
            String paginas = this.txtPaginas.Text;
           
            String editorial = this.txtEditorial.Text;
            String area = this.dArea.Text;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(paginas) ||  string.IsNullOrEmpty(editorial) || string.IsNullOrEmpty(area)) {
                this.Msg.Text = "Debe llenar los campos";
                return;
            }

            if (area == "no seleccion") {
                this.Msg.Text = "Debe seleccionar un area para realizar el registro";
                return;
            }
            int pages;
            try {
               pages = Int32.Parse(paginas);
            }
            catch(Exception) {
                this.Msg.Text = "El numero de paginas debe ser un numero";
                
                return;
            }

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.ingresarLibro(codigo, nombre, pages, editorial, area);

            if (val) {
                this.Msg.Text = "Se registro el libro con nombre= "+nombre;
                this.vaciar();
                return;
            }

            this.Msg.Text = "El libro ya se encuentra registrado en el sistema";


        }

        public void vaciar() {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtEditorial.Text = "";
            this.txtPaginas.Text = "";
        }
    }
}