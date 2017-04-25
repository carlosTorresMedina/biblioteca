using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace labLaboratorio.CapaLogica
{
    public class Usuario
    {

        /**
     ingresa un usuario en el sistema
     **/
        public bool ingresarUsuario(String codigo, String nombre, string direccion, String telefono, String correo,String estado)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("Insert into Usuarios (usuDocumento,usuNombre,usuDireccion,usuTelefono,usuCorreo,usuEstado) values('" + codigo + "','" + nombre + "','" + direccion + "','" + telefono + "','" + correo + "','" + estado 
                + "')");
        }



        /**
       consulta los usuarios registrados en el sistema
       **/
        public DataSet consultarUsuarios()
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Usuarios", "Usuarios");
        }


        /**
      consulta un usuario especifico registrado en el sistema
          lo busca por el numero de documento
      **/
        public DataSet consultarUsuariosEspecificos(String cod)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Usuarios where usuDocumento='"+cod+"'", "Usuarios");
        }

        /**
        modifica un determinado usuario segun su numero de documento
    **/
        public bool modifcarUsuario(String codigo, String nombre, String direccion, String telefono, String correo, String estado)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("update  Usuarios set usuNombre='"+nombre+ "' ,usuDireccion='" + direccion + "',usuTelefono='" + telefono + "',usuCorreo='" + correo + "',usuEstado='" + estado + "' where usuDocumento='" + codigo+"'");
        }


      
            /**
        modifica un determinado usuario segun su numero de documento
    **/
        public bool eliminarUsuario(String codigo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("delete from Usuarios where usuDocumento='" + codigo + "'");
        }

        /**
       sancion
   **/
        public bool sancionarUsuario(String codigo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("update  Usuarios set usuEstado='sancion' where usuDocumento='" + codigo + "'");
        }

    }
}