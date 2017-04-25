using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace labLaboratorio.CapaLogica
{
    public class Fachada
    {

        /**
        ingresa un area al sistema
        **/
        public bool ingresarArea(String codigo, String nombre, String tiempo) {
            Area a=new Area();
            return a.ingresarArea(codigo, nombre, tiempo);
        }

        /**
        consulta todas las areas registradas en el sistema
        **/
        public DataSet consultarAreas() {
            Area a=new Area();
           return a.consultarAreas();
        }

        /**
       consulta todas las areas especifica por el nombre registradas en el sistema
       **/
        public DataSet consultarAreasEspecifica(String codigo)
        {
            Area a = new Area();
            return a.consultarAreasEspecifica(codigo);
        }


        /**
        modifica un area especifica
        **/
        public bool modificarArea(String cod,String nombre,String tiempo) {
            Area a = new Area();
            return a.modificarArea(cod,nombre,tiempo);
        }

/**
elimina un area especifica
**/
        public bool eliminarAreas(String nombre) {
            Area a = new Area();
            return a.eliminarAreas(nombre);
        }


        /**
        ingresa un libro en el sistema
        **/
        public bool ingresarLibro(String codigo, String nombre, int paginas, String editorial, String area)
        {
            Libro l = new Libro();
            return l.ingresarLibro(codigo, nombre, paginas, editorial, area);
        }


        /**
        consulta los libros registrados en el sistema
        **/
        public DataSet consultarLibros() {
            Libro l = new Libro();
            return l.consultarLibros();
        }

        /**
      consulta libros de manera especifica
      **/
        public DataSet consultarLibrosEspecifica(String codigo)
        {
            Libro l = new Libro();
            return l.consultarLibrosEspecifica(codigo);
        }

        /**
      modifica un libro en el sistema
       **/
        public bool ModificarLibro(String codigo, String nombre, int paginas, String editorial, String area)
        {
            Libro l = new Libro();
            return l.ModificarLibro(codigo, nombre, paginas, editorial, area);
        }


        /**
        elimina un determinado libro segun su nombre en el sistema
        **/
        public bool eliminarLibro(String codigo) {
            Libro l = new Libro();
           return l.eliminarLibro(codigo);
        }


        /**
     ingresa un usuario en el sistema
     **/
        public bool ingresarUsuario(String codigo, String nombre, string direccion, String telefono, String correo, String estado)
        {
            Usuario u = new Usuario();
            return u.ingresarUsuario(codigo, nombre, direccion, telefono, correo, estado);
        }


        /**
      consulta los usuarios registrados en el sistema
      **/
        public DataSet consultarUsuarios()
        {
            Usuario u = new Usuario();
            return u.consultarUsuarios();
        }

        /**
        consulta un usuario especifico registrado en el sistema
            lo busca por el numero de documento
        **/
        public DataSet consultarUsuariosEspecificos(String cod) {
            Usuario u = new Usuario();
            return u.consultarUsuariosEspecificos(cod);
        }


        /**
        modifica un determinado usuario segun su numero de documento
    **/
        public bool modifcarUsuario(String codigo, String nombre, String direccion, String telefono, String correo, String estado) {
            Usuario u = new Usuario();
            return u.modifcarUsuario(codigo,nombre,direccion,telefono,correo,estado);
        }

        /**
      modifica un determinado usuario segun su numero de documento
  **/
        public bool eliminarUsuario(String codigo)
        {
            Usuario u = new Usuario();
            return u.eliminarUsuario(codigo);
        }


        /**
        registra un prestamo en el sistema para un determinado usuario
            no se agrega ningun libro a este prestamo solo lo registra de manera general
        **/
        public bool realizaPrestamo(String codigo, DateTime fecha, String documentoUsuario) {
            Prestamo p = new Prestamo();
            return p.realizaPrestamo(codigo, fecha, documentoUsuario);
        }

        /**
        realiza el registro final de un prestamo adiconando libros al prestamo asociado;
        **/
        public bool registroFinalPrestamo(String codigo,String libro,int cantidad,DateTime fecha) {
            Prestamo p = new Prestamo();
            return p.registroFinalPrestamo(codigo,libro,cantidad,fecha);
        }


        /**
        registra una devolucion de un libro en el sistema
            y dependiendo de la fecha de entrega se genera multa o no se genera multa
        **/
        public bool realizarDevolucion(String codigo,DateTime fecha,String usuario,String libro) {
            Prestamo p = new Prestamo();
            return p.realizarDevolucion(codigo, fecha, usuario, libro);
        }

    }
}