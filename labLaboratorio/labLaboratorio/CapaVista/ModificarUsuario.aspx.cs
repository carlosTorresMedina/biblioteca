using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace labLaboratorio.CapaVista
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                this.DArea.Items.Clear();
                CapaLogica.Fachada fachada = new CapaLogica.Fachada();
                DataSet datos = fachada.consultarUsuarios();           
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
            foreach (DataRow dr in datos.Tables["Usuarios"].Rows)
            {
                this.txtCodigo.Text = dr["usuDocumento"].ToString();
                this.txtNombre.Text = dr["usuNombre"].ToString();
                this.txtDireccion.Text = dr["usuDireccion"].ToString();
                this.txtCorreo.Text = dr["usuCorreo"].ToString();
                this.txtTelefono.Text = dr["usuTelefono"].ToString();
                this.txtEstado.Text = dr["usuEstado"].ToString();

            }
        }

        protected void ButonIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = this.txtNombre.Text;
            String direccion = this.txtDireccion.Text;

            String telefono = this.txtTelefono.Text;
            String correo = this.txtCorreo.Text;
            String estado = this.txtEstado.Text;

            if (String.IsNullOrEmpty(codigo) || String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(direccion) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(correo) || String.IsNullOrEmpty(estado))
            {
                this.Msg.Text = "Llene todos los campos";
                return;
            }




            CapaLogica.Fachada fachada = new CapaLogica.Fachada();
            bool val = fachada.modifcarUsuario(codigo, nombre, direccion, telefono, correo, estado);


            if (val)
            {
                this.Msg.Text = "Se modifico el usuario con nombre= " + nombre;
                this.vaciar();
                return;
            }

            this.Msg.Text = "existe un error al modificar";
        }

        private void vaciar()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtEstado.Text = "";
        }
    }
}