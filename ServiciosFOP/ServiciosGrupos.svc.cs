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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosGrupos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiciosGrupos.svc o ServiciosGrupos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiciosGrupos : IServiciosGrupos
    {
        SqlConnection conexion = new SqlConnection("Data Source =.; initial catalog = BDFOP; User ID = userFOP2; Password=master17;");
        public KeyValuePair<int, string> ActualizarGrupo(Grupo DatosGrupo)
        {

            {
                try
                {

                    string SP = "dbo.[ACTUALIZAR_DATOS_GRUPO]";

                    SqlCommand cmd = new SqlCommand(SP, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdGrupo", DatosGrupo.IdGrupo);
                    cmd.Parameters.AddWithValue("@PNI", DatosGrupo.PNI);
                    cmd.Parameters.AddWithValue("@IdCampana", DatosGrupo.IdCampana);
                    cmd.Parameters.AddWithValue("@IdTurno", DatosGrupo.IdTurno);
                    cmd.Parameters.AddWithValue("@IdInstructor", DatosGrupo.IdInstructor);


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

        public KeyValuePair<int, string> AsignarAspiranteGrupo(int IdGrupo, int IdAspirante, int IdInstructor)
        {
            {
                try
                {

                    string SP = "dbo.[INSERTAR_ASPIRANTE_A_GRUPO]";

                    SqlCommand cmd = new SqlCommand(SP, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo);
                    cmd.Parameters.AddWithValue("@IdAspirante", IdAspirante);
                    cmd.Parameters.AddWithValue("@IdInstructor", IdInstructor);

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


        public KeyValuePair<int, string> GuardarGrupo(Grupo NuevoGrupo)
        {
            {
                try
                {

                    string spInsertAsp = "dbo.[INSERTAR_GRUPO]";

                    SqlCommand cmd = new SqlCommand(spInsertAsp, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PNI", NuevoGrupo.PNI);
                    cmd.Parameters.AddWithValue("@IdCampana", NuevoGrupo.IdCampana);
                    cmd.Parameters.AddWithValue("@IdTurno", NuevoGrupo.IdTurno);
                    cmd.Parameters.AddWithValue("@InicioT", NuevoGrupo.InicioTeoria);
                    cmd.Parameters.AddWithValue("@FinT", NuevoGrupo.FinTeoria);
                    cmd.Parameters.AddWithValue("@InicioO", NuevoGrupo.InicioOpc);
                    cmd.Parameters.AddWithValue("@FinO", NuevoGrupo.FinOpc);
                    cmd.Parameters.AddWithValue("@IdInstructor", NuevoGrupo.IdInstructor);

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

        public List<Grupo> ListarGruposActivos()
        {
            List<Grupo> ListaFinal = new List<Grupo>();
            string SP = "[dbo].[OBTENER_GRUPOS_ACTIVOS]";

            SqlCommand cmd = new SqlCommand(SP, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Grupo GrupoAsignado = new Grupo();
                GrupoAsignado.IdGrupo = Convert.ToInt32(dt.Rows[i]["IdGrupo"]);
                GrupoAsignado.PNI = dt.Rows[i]["PNI"].ToString();
                GrupoAsignado.IdCampana = Convert.ToInt32(dt.Rows[i]["IdCampana"]);
                GrupoAsignado.IdTurno = Convert.ToInt32(dt.Rows[i]["IdTurno"]);
                GrupoAsignado.Campana = dt.Rows[i]["Campana"].ToString();
                GrupoAsignado.IdInstructor = Convert.ToInt32(dt.Rows[i]["IdInstructor"]);
                GrupoAsignado.Instructor = dt.Rows[i]["NombreCom"].ToString();


                ListaFinal.Add(GrupoAsignado);

            }

            return ListaFinal;
        }

        public List<Aspirante> ObtenerAspirantesGrupo(int IdGrupo)
        {
            List<Aspirante> ListaFinal = new List<Aspirante>();
            string SP = "[dbo].[OBTENER_ASPIRANTES_DE_GRUPO]";

            SqlCommand cmd = new SqlCommand(SP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Aspirante AspiranteAsignado = new Aspirante();

                AspiranteAsignado.IdAspirante = Convert.ToInt32(dt.Rows[0]["IdAspirante"]);
                AspiranteAsignado.NumeroEmpleado = dt.Rows[0]["NumeroEmp"].ToString();
                AspiranteAsignado.Nombre = dt.Rows[0]["Nombre"].ToString();
                AspiranteAsignado.ApellidoPaterno = dt.Rows[0]["ApPaterno"].ToString();
                AspiranteAsignado.ApellidoMaterno = dt.Rows[0]["ApMaterno"].ToString();
                AspiranteAsignado.Estatus = Convert.ToBoolean(dt.Rows[0]["Estatus"]);

                ListaFinal.Add(AspiranteAsignado);
            }


            return ListaFinal;
        }

        public Grupo ObtenerGrupoPorId(int IdGrupo)
        {
            string SP = "[dbo].[OBTENER_GRUPO_POR_ID]";

            SqlCommand cmd = new SqlCommand(SP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            Grupo GrupoAsignado = new Grupo();

            GrupoAsignado.IdGrupo = Convert.ToInt32(dt.Rows[0]["IdGrupo"]);
            GrupoAsignado.PNI = dt.Rows[0]["PNI"].ToString();
            GrupoAsignado.IdCampana = Convert.ToInt32(dt.Rows[0]["IdCampana"]);
            GrupoAsignado.IdTurno = Convert.ToInt32(dt.Rows[0]["IdTurno"]);
            GrupoAsignado.Campana = dt.Rows[0]["Campana"].ToString();
            GrupoAsignado.Turno = dt.Rows[0]["Turno"].ToString();
            GrupoAsignado.IdInstructor = Convert.ToInt32(dt.Rows[0]["IdInstructor"]);
            GrupoAsignado.Instructor = dt.Rows[0]["NombreCom"].ToString();



            return GrupoAsignado;
        }

        public KeyValuePair<int, string> RemoverAspiranteGrupo(int IdAspirante, int IdGrupo)
        {
            {
                try
                {

                    string SP = "dbo.[ELIMINAR_ASPIRANTE_GRUPO]";

                    SqlCommand cmd = new SqlCommand(SP, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAspirante", IdAspirante);
                    cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo);

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
    }
}
