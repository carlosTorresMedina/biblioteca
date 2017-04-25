using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class EliminarArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CapaLogica.Fachada fachada = new CapaLogica.Fachada();
                DataSet datos = fachada.consultarAreas();
                ListItem oItem = new ListItem("no seleccion", "no seleccion");
                this.DArea.Items.Add(oItem);

                foreach (DataRow dr in datos.Tables["Areas"].Rows)
                {
                    ListItem Item = new ListItem(dr["areNombre"].ToString(), dr["areNombre"].ToString());
                    this.DArea.Items.Add(Item);


                }

            }
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.eliminarAreas(this.DArea.Text);
            if (val) {
                this.Msg.Text = "se elimino de manera exitosa el area= "+this.DArea.Text;
                return;
            }
            this.Msg.Text = "error al eliminar";
        }
    }
}