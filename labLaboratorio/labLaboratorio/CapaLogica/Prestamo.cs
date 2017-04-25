using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace labLaboratorio.CapaLogica
{
    public class Prestamo
    {

        /**
       registra un prestamo en el sistema para un determinado usuario
           no se agrega ningun libro a este prestamo solo lo registra de manera general
       **/
        public bool realizaPrestamo(String codigo, DateTime fecha, String documentoUsuario)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

            return servicio.ejecutarDML("Insert into Prestamos (preCodigo,facFecha,preUsuario) values('" + codigo + "','" + fecha.Date + "','" + documentoUsuario+ "')");
        }

        /**
       realiza el registro final de un prestamo adiconando libros al prestamo asociado;
       **/
        public bool registroFinalPrestamo(String codigo, String libro,int cantidad,DateTime fecha)
        {

            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();

               return servicio.ejecutarDML("Insert into DetallePrestamo (dtpPrestamo,dtpLibro,dtpCantidad,dtpFechaFin) values('" + codigo + "','" + libro + "',"+cantidad+",'" +fecha + "')");    
        }

        /**
       registra una devolucion de un libro en el sistema
           y dependiendo de la fecha de entrega se genera multa o no se genera multa
       **/
        public bool realizarDevolucion(String codigo, DateTime fecha, String usuario, String libro)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();


            bool val= servicio.ejecutarDML("update DetallePrestamo set dtpFechaDev='"+fecha+"' where dtpPrestamo='"+codigo+"' and dtpLibro ='"+libro+"'");
            DataSet datos;
            DateTime fechaI;
            if (val) {
                datos = this.consultarPrestamoEspecifico(codigo,libro);
                foreach (DataRow dr in datos.Tables["DetallePrestamo"].Rows)
                {
                    fechaI =new DateTime();
                    fechaI= DateTime.Parse(dr["dtpFechaFin"].ToString());
                    
                    
                    if (fechaI.Date<fecha)
                    {
                        DateTime actual =new DateTime();
                        
                        DateTime fsancion = actual.AddDays(5);
                   val= servicio.ejecutarDML("Insert into Sanciones (sanCodigo,sanPrestamo,sanDiasSancion,sanFehaInicio,sanFechaFin) values('" + codigo +"-"+libro+ "','" + codigo+ "'," + 5 + ",'"+actual.Date+"','"+fsancion+"')");
                        Usuario u = new Usuario();
                        u.sancionarUsuario(usuario);
                    }
                }
               
            }
            return val;
        }


        /**
     consulta un prestamo especifico
            **/
        public DataSet consultarPrestamoEspecifico(String codigo, String libro)
        {
            ServiceReference.ServiceBDSoapClient servicio = new ServiceReference.ServiceBDSoapClient();
            return servicio.EjecutarConsulta("select * from DetallePrestamo where dtpPrestamo='" + codigo + "' and dtpLibro='"+libro+"'", "DetallePrestamo");
        }

    }
    

}