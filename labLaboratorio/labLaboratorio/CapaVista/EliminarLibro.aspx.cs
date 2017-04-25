using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class EliminarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) {

                this.cargarCombo();

            }
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.eliminarLibro(this.DArea.Text);
            if (val) {
                this.Msg.Text = "El libro con codigo =  " + this.DArea.Text;
                this.cargarCombo();
                return;

            }
            this.Msg.Text = "existe un error al eliminar";
            
        }

        private void cargarCombo() {
            this.DArea.Items.Clear();
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarLibros();

            ListItem oItem = new ListItem("no seleccion", "no seleccion");
            this.DArea.Items.Add(oItem);

            foreach (DataRow dr in datos.Tables["Libros"].Rows)
            {
                ListItem Item = new ListItem(dr["libCodigo"].ToString(), dr["libCodigo"].ToString());
                this.DArea.Items.Add(Item);


            }
        }
    }
}