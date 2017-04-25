using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace labLaboratorio.CapaLogica
{
    public class Area
    {

        /**
        ingresa un area al sistema
        **/
        public bool ingresarArea(String codigo, String nombre, String tiempo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
           
            return servicio.ejecutarDML("Insert into Areas (areCodigo,areNombre,areTiempo) values('"+codigo+"','"+nombre+"','"+tiempo
                +"')");
        }


        /**
        consulta todas las areas registradas en el sistema
        **/
        public DataSet consultarAreas()
        {

            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Areas","Areas");
        }


        /**
       consulta todas las areas especifica por el nombre registradas en el sistema
       **/
        public DataSet consultarAreasEspecifica(String codigo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from Areas where areCodigo='"+codigo+"'", "Areas");
        }

        /**
       modifica un area especifica
       **/
        public bool modificarArea(String cod, String nombre, String tiempo)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.ejecutarDML("update Areas set areNombre='"+nombre+"', areTiempo='"+tiempo+"' where areCodigo='" + cod +"'");
        }

        /**
elimina un area especifica
**/
        public bool eliminarAreas(String nombre)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.ejecutarDML("delete from Areas where areNombre='"+nombre+"'");
        }


    }
}