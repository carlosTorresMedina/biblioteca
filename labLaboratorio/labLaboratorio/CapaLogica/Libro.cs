using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace labLaboratorio.CapaLogica
{
    public class Libro
    {

        /**
       ingresa un libro en el sistema
       **/
        public bool ingresarLibro(String codigo, String nombre, int paginas, String editorial, String area)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("Insert into Libros (libCodigo,libNombre,libNumPag,libEditorial,libArea) values('" + codigo + "','" + nombre + "'," + paginas + ",'" + editorial + "','" + area
                + "')");
        }

        /**
       consulta los libros registrados en el sistema
       **/
        public DataSet consultarLibros()
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Libros", "Libros");
        }

        /**
     consulta libros de manera especifica
     **/
        public DataSet consultarLibrosEspecifica(String codigo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Libros where libCodigo='" + codigo + "'", "Libros");
        }

        /**
    modifica un libro en el sistema
     **/
        public bool ModificarLibro(String codigo, String nombre, int paginas, String editorial, String area)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.ejecutarDML("update Libros set  libNombre='" + nombre + "', libNumPag="+paginas+",libEditorial='"+editorial+"',libArea='"+area+"' where libCodigo='" + codigo + "'");
        }


        /**
       elimina un determinado libro segun su nombre en el sistema
       **/
        public bool eliminarLibro(String codigo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.ejecutarDML("delete from Libros where libCodigo='"+codigo+"'");
        }

    }
}