using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class ServiceBD : System.Web.Services.WebService
{

    private SqlConnection Conexion;
    private String CadenaConexion= "data source=CARLOSTORRES\\SQLEXPRESS;initial catalog=Biblioteca;integrated security=true";

    public ServiceBD () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public DataSet EjecutarConsulta(String sql, String nombreTabla) {
        try {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            DataSet datos = new DataSet();
            SqlDataAdapter miAdaptador = new SqlDataAdapter(sql, Conexion);
            miAdaptador.Fill(datos, nombreTabla);
            this.Conexion.Close();
            return datos;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            Conexion.Close();

            return null;
        }
    }

    [WebMethod]
    public Boolean ejecutarDML(String DML)
    {
        bool val = false;
        try
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            this.Conexion.Open();
            SqlCommand comando = new SqlCommand(DML, Conexion);
            if (comando.ExecuteNonQuery() > 0)
            {
                val = true;
            }
            Conexion.Close();
            return val;
        }
        catch (Exception ex)
        {
         Console.Write(ex.StackTrace);
           Conexion.Close();

          return false;
        }
            
    }
}
