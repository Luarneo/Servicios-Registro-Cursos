using ServiciosFOP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosFOP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IServicioAgente
    {


        SqlConnection conexion = new SqlConnection("Data Source =.; initial catalog = BDFOP; User ID = userFOP2; Password=master17;");

        public KeyValuePair<int,string> GuardarAspirate(Aspirante NuevoAspirante)
        {
            {
                try
                {
                    string spInsertAsp = "dbo.[INSERTAR_ASPIRANTE]";

                    SqlCommand cmd = new SqlCommand(spInsertAsp, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroEmp", NuevoAspirante.NumeroEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", NuevoAspirante.Nombre);
                    cmd.Parameters.AddWithValue("@ApPat", NuevoAspirante.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApMat", NuevoAspirante.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Est", NuevoAspirante.Estatus);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                                       
                    return new KeyValuePair<int, string>(1, "Operación Exitosa");
                    
                }
                catch (Exception ex)
                {
                    return new KeyValuePair<int, string>(0, ex.Message);
                }
                                                
            }
        }

        public List<Aspirante> ListarAspirantesActivos()
        {

            List<Aspirante> ListaFinal = new List<Aspirante>(); 
            string spInsertAsp = "[dbo].[OBTENER_ASPIRANTES_ACTIVOS]";

            SqlCommand cmd = new SqlCommand(spInsertAsp, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Aspirante AspiranteAsignado = new Aspirante();
                
                AspiranteAsignado.IdAspirante = Convert.ToInt32(dt.Rows[i]["IdAspirante"]);
                AspiranteAsignado.NumeroEmpleado = dt.Rows[i]["NumeroEmp"].ToString();
                AspiranteAsignado.Nombre = dt.Rows[i]["Nombre"].ToString();
                AspiranteAsignado.ApellidoPaterno = dt.Rows[i]["ApPaterno"].ToString();
                AspiranteAsignado.ApellidoMaterno = dt.Rows[i]["ApMaterno"].ToString();
                AspiranteAsignado.Estatus = Convert.ToBoolean(dt.Rows[i]["Estatus"]);

                ListaFinal.Add(AspiranteAsignado);
                              
            }

            return ListaFinal;
        }

        public Aspirante ObtenerAspirantePorId(int IdAspirante)
        {


            string spObtAsp = "[dbo].[OBTENER_ASPIRANTE_POR_ID]";

            SqlCommand cmd = new SqlCommand(spObtAsp, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAspirante", IdAspirante);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
                Aspirante AspiranteAsignado = new Aspirante();

                AspiranteAsignado.IdAspirante = Convert.ToInt32(dt.Rows[0]["IdAspirante"]);
                AspiranteAsignado.NumeroEmpleado = dt.Rows[0]["NumeroEmp"].ToString();
                AspiranteAsignado.Nombre = dt.Rows[0]["Nombre"].ToString();
                AspiranteAsignado.ApellidoPaterno = dt.Rows[0]["ApPaterno"].ToString();
                AspiranteAsignado.ApellidoMaterno = dt.Rows[0]["ApMaterno"].ToString();
                AspiranteAsignado.Estatus = Convert.ToBoolean(dt.Rows[0]["Estatus"]);

                 

            return AspiranteAsignado;
        }

        public KeyValuePair<int, string> ActualizarAspirante(int IdAspirante, bool NuevoEstatus)
        {
                        
            {
                try
                {
                    string spActAsp = "dbo.[ACTUALIZAR_ESTATUS_ASPIRANTE]";

                    SqlCommand cmd = new SqlCommand(spActAsp, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAspirante", IdAspirante);
                    cmd.Parameters.AddWithValue("@NvoEstatus", NuevoEstatus);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    return new KeyValuePair<int, string>(1, "Operación Exitosa");

                }
               catch(Exception ex)
                {
                    return new KeyValuePair<int, string>(0, ex.Message);
                }
            }
                                           
        }

        public List<Aspirante> ObtenerAspirantesSinGrupo()
        {

            List<Aspirante> ListaFinal = new List<Aspirante>();
            string spInsertAsp = "[dbo].[OBTENER_ASPIRANTES_SIN_GRUPO]";

            SqlCommand cmd = new SqlCommand(spInsertAsp, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Aspirante AspiranteAsignado = new Aspirante();

                AspiranteAsignado.IdAspirante = Convert.ToInt32(dt.Rows[i]["IdAspirante"]);
                AspiranteAsignado.NumeroEmpleado = dt.Rows[i]["NumeroEmp"].ToString();
                AspiranteAsignado.Nombre = dt.Rows[i]["Nombre"].ToString();
                AspiranteAsignado.ApellidoPaterno = dt.Rows[i]["ApPaterno"].ToString();
                AspiranteAsignado.ApellidoMaterno = dt.Rows[i]["ApMaterno"].ToString();
                AspiranteAsignado.Estatus = Convert.ToBoolean(dt.Rows[i]["Estatus"]);

                ListaFinal.Add(AspiranteAsignado);

            }

            return ListaFinal;
        }
               
    }
}
