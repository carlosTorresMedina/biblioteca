using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class ModificarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

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

        protected void cmdConsultar_Click(object sender, EventArgs e)
        {
            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            
            DataSet datos = fachada.consultarLibrosEspecifica(this.DArea.Text);
            foreach (DataRow dt in datos.Tables["Libros"].Rows)
            {
                this.txtCodigo.Text = dt["libCodigo"].ToString();
                this.txtNombre.Text = dt["libNombre"].ToString();
                this.txtPaginas.Text = dt["libNumPag"].ToString();
                this.txtEditorial.Text = dt["libEditorial"].ToString();

              
                ListItem oItem = new ListItem(dt["libArea"].ToString(), dt["libArea"].ToString());
                if (DArea1.Items.Contains(oItem))
                {
                    this.DArea1.Items.Add(oItem);
                }
               
                fachada = new CapaLogica.Fachada();
                DataSet datos1 = fachada.consultarAreas();

                

                foreach (DataRow dr in datos1.Tables["Areas"].Rows)
                {
                    ListItem Item = new ListItem(dr["areCodigo"].ToString(), dr["areCodigo"].ToString());
                    if (!this.DArea1.Items.Contains(Item))
                    {
                        this.DArea1.Items.Add(Item);
                    }


                }

            }
        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = this.txtNombre.Text;
            String paginas = this.txtPaginas.Text;

            String editorial = this.txtEditorial.Text;
            String area = this.DArea1.Text;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(paginas) || string.IsNullOrEmpty(editorial) || string.IsNullOrEmpty(area))
            {
                this.Msg.Text = "Debe llenar los campos";
                return;
            }

            if (area == "no seleccion")
            {
                this.Msg.Text = "Debe seleccionar un area para realizar el registro";
                return;
            }
            int pages;
            try
            {
                pages = Int32.Parse(paginas);
            }
            catch (Exception)
            {
                this.Msg.Text = "El numero de paginas debe ser un numero";

                return;
            }

            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.ModificarLibro(codigo,nombre,pages,editorial,area);

            if (val)
            {
                this.Msg.Text = "Se modifico correctamente el libro = " + nombre;
                this.vaciar();
                return;
            }

            this.Msg.Text = "error al guardar";
        }

        private void vaciar() {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtEditorial.Text = "";
            this.txtPaginas.Text = "";

        }
    }
}