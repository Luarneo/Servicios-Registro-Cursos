using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ServiciosFOP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1, IServicioCatalogos
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        SqlConnection conexion = new SqlConnection("Data Source =.; initial catalog = BDFOP; User ID = userFOP2; Password=master17;");

        public List<KeyValuePair<int,string>> ObtenerCampanas()
        {
            List<KeyValuePair<int, string>> ListaFinal = new List<KeyValuePair<int, string>>();

            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select * from Campanas", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    
                    ListaFinal.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                }

                return ListaFinal;
            }
          
        }

        public List<KeyValuePair<int, string>> ObtenerTurnos()
        {
            List<KeyValuePair<int, string>> ListaFinal = new List<KeyValuePair<int, string>>();

            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select * from Turnos", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListaFinal.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                }

                return ListaFinal;
            }

        }
    }
}
