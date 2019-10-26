using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    public static class AutoCompletar
    {
        private static SqlConnection conexion;

        //metodo para cargar los datos de la db
        public static DataTable Datos()
            {
                DataTable dt = new DataTable();

                //SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());//cadena conexion
                //SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source =.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True"].ToString());//cadena conexion
                conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");

                string consulta = "SELECT * FROM seccionesVehiculo"; //consulta a la tabla
                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(dt);
                return dt;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["descSeccion"]));
                }

                return coleccion;
            }
        
    }
}
