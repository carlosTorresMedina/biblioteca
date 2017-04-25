using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class RealizarPrestamo : System.Web.UI.Page
    {

      
        private DataSet tablaBase;
        private DataTable tablaDetalle;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.CFecha.Visible = false;
                this.CFechaLimite.Visible = false;
                this.crearEstructuraTabla();
                 this.desactivarPrestamo();
                this.llenarCombos();
             
                
            }
        }

        private void crearEstructuraTabla()
        {

            tablaDetalle = new DataTable();
            this.tablaDetalle.TableName = "Detalle";
            this.tablaBase = new DataSet();

            this.tablaBase.Tables.Add(this.tablaDetalle);

            tablaDetalle.Columns.Add("Libro", typeof(string));
            tablaDetalle.Columns.Add("Cantidad", typeof(string));
            tablaDetalle.Columns.Add("Fecha inicio", typeof(string));
            tablaDetalle.Columns.Add("Fecha fin", typeof(string));

            Session["tablaDetalle"] = this.tablaDetalle;
            Session["tablaBase"] = this.tablaBase;

           

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

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            DateTime fecha = this.CFecha.SelectedDate;
            String usuario = this.DUsuario.Text;

            if (String.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(this.Fecha1.Text) || string.IsNullOrEmpty(usuario)){
                this.Msg.Text = "llene todo los campos";
                return;

            }

            if (usuario == "no seleccion") {
                this.Msg.Text = "debe seleccionar un usuario";
                return;
            }

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.realizaPrestamo(codigo, fecha.Date, usuario);
            if (val) {
                this.Msg.Text = "adicione libros al prestamo con codigo = "+codigo;
                this.activarPrestamo();
                Session["codigo"] = codigo;
               Session["fechaInicio"] =fecha;
                return;
            }

            this.Msg.Text = "existe un error al realizar el prestamo";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (this.CFecha.Visible)
            {
                this.CFechaLimite.Visible = false;
            }
            else {
                this.CFechaLimite.Visible = true;
            }
        }

        protected void CFechaLimite_SelectionChanged(object sender, EventArgs e)
        {
            this.txtFechaLimite.Text = this.CFechaLimite.SelectedDate.ToShortDateString();
            this.CFechaLimite.Visible = false;
        }


        private void activarPrestamo() {
            this.DLibro.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.Button2.Enabled = true;
        }


        private void desactivarPrestamo() {
            this.DLibro.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.Button2.Enabled = false;
        }

        private void llenarCombos() {
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
            DateTime fechaFin = this.CFechaLimite.SelectedDate;
            String codigo = (String)Session["codigo"];
            String libro = this.DLibro.Text;
            int cant;

            if (libro == "no seleccion") {
                this.Msg.Text = "debe escoger un libro";
                return;
            }
            try {
                 cant = Int32.Parse(this.txtCantidad.Text);
            }
            catch (Exception) {
                this.Msg.Text = "la cantidad debe ser un valor numerico";
                return;
            }


            DateTime fechaI = (DateTime)Session["fechaInicio"];

            DataTable tabla = (DataTable)Session["tablaDetalle"];
            tabla.Rows.Add(libro,cant,fechaI.ToShortDateString(),fechaFin.ToShortDateString());       

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();


            bool val = fachada.registroFinalPrestamo(codigo, libro, cant, fechaFin);
            if (!val) {
                this.Msg.Text = "existe un error al agregar el libro con codigo=" + libro;
                return;
            }
            this.Msg.Text = " el libro con codigo=" + libro+" se registro existosamente";

            data.DataSource = (DataSet)Session["tablaBase"];

            this.data.DataBind();


        }
    }
}