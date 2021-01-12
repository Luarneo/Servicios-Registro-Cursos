using ServiciosFOP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosFOP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioInstructor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioInstructor.svc o ServicioInstructor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioInstructor : IServicioInstructor
    {

        SqlConnection conexion = new SqlConnection("Data Source =.; initial catalog = BDFOP; User ID = userFOP2; Password=master17;");
        public KeyValuePair<int, string> ActualizarInstructor(Instructor DatosInstructor)
        {
            {
                try
                {

                    string SP = "dbo.[ACTUALIZAR_DATOS_INSTRUCTOR]";

                    SqlCommand cmd = new SqlCommand(SP, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdInstructor", DatosInstructor.IdInstructor);
                    cmd.Parameters.AddWithValue("@NombreCompleto", DatosInstructor.NombreCompleto);

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

        public KeyValuePair<int, string> CambiarEstatusInstructor(int IdInstructor, bool NuevoEstatus)
        {
            {
                try
                {
                    string SP = "dbo.[ACTUALIZAR_ESTATUS_INSTRUCTOR]";

                    SqlCommand cmd = new SqlCommand(SP, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdInstructor", IdInstructor);
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

        public KeyValuePair<int, string> GuardarInstructor(Instructor NuevoInstructor)
        {
            {
                try
                {
                    string spInsertAsp = "dbo.[INSERTAR_INSTRUCTOR]";

                    SqlCommand cmd = new SqlCommand(spInsertAsp, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreCompleto", NuevoInstructor.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Estatus", NuevoInstructor.Estatus);

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

        public List<Instructor> ListarInstructoresActivos()
        {
            List<Instructor> ListaFinal = new List<Instructor>();
            string SP = "[dbo].[OBTENER_INSTRUCTORES_ACTIVOS]";

            SqlCommand cmd = new SqlCommand(SP, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Instructor InstructorAsignado = new Instructor();
                InstructorAsignado.IdInstructor = Convert.ToInt32(dt.Rows[i]["IdInstructor"]);
                InstructorAsignado.NombreCompleto = dt.Rows[i]["NombreCom"].ToString();
                InstructorAsignado.Estatus = Convert.ToBoolean(dt.Rows[i]["Estatus"]);


                ListaFinal.Add(InstructorAsignado);

            }

            return ListaFinal;
        }

        public Instructor ObtenerInstructorPorId(int IdInstructor)
        {
            string SP = "[dbo].[OBTENER_INSTRUCTOR_POR_ID]";

            SqlCommand cmd = new SqlCommand(SP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdInstructor", IdInstructor);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

           
            Instructor InstructorAsignado = new Instructor();

            InstructorAsignado.IdInstructor = Convert.ToInt32(dt.Rows[0]["IdInstructor"]);
            InstructorAsignado.NombreCompleto = dt.Rows[0]["NombreCom"].ToString();
            InstructorAsignado.Estatus = Convert.ToBoolean(dt.Rows[0]["Estatus"]);

            return InstructorAsignado;
        }
    }
}
