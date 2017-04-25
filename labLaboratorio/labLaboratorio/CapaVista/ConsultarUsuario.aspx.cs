using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class ConsultarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                this.DArea.Items.Clear();
                CapaLogica.Fachada fachada = new CapaLogica.Fachada();
                DataSet datos = fachada.consultarUsuarios();
                this.Data.DataSource = datos;
                this.Data.DataBind();


                ListItem oItem = new ListItem("no seleccion", "no seleccion");
                this.DArea.Items.Add(oItem);

                foreach (DataRow dr in datos.Tables["Usuarios"].Rows)
                {
                    ListItem Item = new ListItem(dr["usuDocumento"].ToString(), dr["usuDocumento"].ToString());
                    this.DArea.Items.Add(Item);


                }
            }

        }

        protected void cmdConsultar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarUsuariosEspecificos(this.DArea.Text);
            this.Data.DataSource = datos;
            this.Data.DataBind();
        }
    }
}