using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class ModificarArea : System.Web.UI.Page
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
                    ListItem Item = new ListItem(dr["areCodigo"].ToString(), dr["areCodigo"].ToString());
                    this.DArea.Items.Add(Item);


                }
            }
            }

        protected void cmdConsultar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarAreasEspecifica(this.DArea.Text);

            foreach (DataRow dr in datos.Tables["Areas"].Rows)
            {
              this.txtCodigo.Text= dr["areCodigo"].ToString();
                this.txtNombre.Text = dr["areNombre"].ToString();
                this.txtTiempo.Text = dr["areTiempo"].ToString();
                


            }
        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtCodigo.Text) || string.IsNullOrEmpty(this.txtNombre.Text) || String.IsNullOrEmpty(this.txtTiempo.Text)) {

                this.Msg.Text = "No puede dejar campos vacios ";
                return;
            }

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.modificarArea(this.txtCodigo.Text, this.txtNombre.Text, this.txtTiempo.Text);
            if (val) {
                this.Msg.Text = "se modifico el area con codigo = "+this.txtCodigo.Text+" de manera exitosa" ;
                this.vaciar();
                return;
            }
            this.Msg.Text = "existe unn error al modificar ";

        }

        private void vaciar() {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtTiempo.Text = "";
        }
    }
}