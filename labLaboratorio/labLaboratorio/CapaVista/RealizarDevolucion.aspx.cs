using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class RealizarDevolucion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CFecha.Visible = false;
                this.llenarCombos();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.CFecha.Visible)
            {
                this.CFecha.Visible = false;
            }
            else {
                this.CFecha.Visible = true;
            }
        }

        protected void CFecha_SelectionChanged(object sender, EventArgs e)
        {
            this.Fecha1.Text = this.CFecha.SelectedDate.ToShortDateString();
            this.CFecha.Visible = false;
        }


        private void llenarCombos()
        {
            this.DUsuario.Items.Clear();
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            DataSet datos = fachada.consultarUsuarios();
            ListItem oItem = new ListItem("no seleccion", "no seleccion");
            this.DUsuario.Items.Add(oItem);

            foreach (DataRow dr in datos.Tables["Usuarios"].Rows)
            {
                ListItem Item = new ListItem(dr["usuDocumento"].ToString(), dr["usuDocumento"].ToString());
                this.DUsuario.Items.Add(Item);
            }

            this.DLibro.Items.Clear();
            DataSet datos1 = fachada.consultarLibros();

            ListItem oItem1 = new ListItem("no seleccion", "no seleccion");
            this.DLibro.Items.Add(oItem1);

            foreach (DataRow dr in datos1.Tables["Libros"].Rows)
            {
                ListItem Item = new ListItem(dr["libCodigo"].ToString(), dr["libCodigo"].ToString());
                this.DLibro.Items.Add(Item);
            }
        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String libro = this.DLibro.Text;
            String usuario = this.DUsuario.Text;
            DateTime fecha = this.CFecha.SelectedDate;

            if (String.IsNullOrEmpty(codigo) || String.IsNullOrEmpty(libro) || String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(this.Fecha1.Text)) {
                this.Msg.Text = "debe llenar los campos";
                return;
            }
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.realizarDevolucion(codigo, fecha, usuario, libro);

            if (val) {
                this.Msg.Text = "se realizo la devolucion correctamente";
                return;
            }
            this.Msg.Text = "existe un error al realizar la devolucion";

        }
    }
}