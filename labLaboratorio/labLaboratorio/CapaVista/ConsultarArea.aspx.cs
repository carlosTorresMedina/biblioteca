using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class ConsultarArea : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CapaLogica.Fachada fachada = new CapaLogica.Fachada();
                DataSet datos = fachada.consultarAreas();
                this.Data.DataSource = datos;
                this.Data.DataBind();
                this.cargarCombo();
            }
           

        }

        protected void DArea_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        protected void cmdConsultar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarAreasEspecifica(this.DArea.Text);
            this.Data.DataSource = datos;
            this.Data.DataBind();
          
            


        }

        private void cargarCombo() {
           
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
}