using PruebasSistemaFOP.ServicioInstructores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasSistemaFOP.ServicioAspirantes;
using PruebasSistemaFOP.ServicioGrupos;
using System.Linq;
using System;



namespace PruebasSistemaFOP
{
    [TestClass]
    public class PruebasServicios
    {
        ServicioAgenteClient ServicioAspirantes = new ServicioAgenteClient();
        ServicioInstructorClient ServicioInstructores = new ServicioInstructorClient();
        ServiciosGruposClient ServicioGrupo = new ServiciosGruposClient();

        [TestMethod]
        public void ObtenerAgentesActivos()
        {
           
            var resultado = ServicioAspirantes.ListarAspirantesActivos().ToList();
            Assert.AreEqual(6, resultado.Count);
                
        }

        [TestMethod]
        public void ObtenerAgentePorId()
        {
          
            var resultado = ServicioAspirantes.ObtenerAspirantePorIdAsync(2);
            Assert.AreEqual("Flor de Maria", resultado.Result.Nombre);

        }

        [TestMethod]
        public void GuardarNuevoAspirante()
        {


            ServicioAspirantes.Aspirante NuevoAspirante = new ServicioAspirantes.Aspirante()
            {
                NumeroEmpleado = "E002397",
                Nombre = "Ricardo",
                ApellidoPaterno = "Monarca",
                ApellidoMaterno = "Jimenez",
                Estatus = true
            };



            var resultado = ServicioAspirantes.GuardarAspirate(NuevoAspirante);
            Assert.AreEqual(1, resultado.Key);

        }

        [TestMethod]
        public void ActuaizarAspirante()
        {
                                    
            var resultado = ServicioAspirantes.ActualizarAspirante(5, false);
            Assert.AreEqual(1, resultado.Key);

        }

        [TestMethod]
        public void ListarAspirantesSinGrupo()
        {
           
            var resultado = ServicioAspirantes.ObtenerAspirantesSinGrupo().ToList();
            Assert.AreEqual(7, resultado.Count);

        }

        [TestMethod]
        public void ListarInstructoresActivos()
        {

            var resultado = ServicioInstructores.ListarInstructoresActivos().ToList();
            Assert.AreEqual(2, resultado.Count);
        }

        [TestMethod]
        public void GuardarNuevoInstructor()
        {

            Instructor NuevoInstructor = new Instructor()
            {
                NombreCompleto = "Ana Maria Galavis Flores",
                Estatus = true
            };

            var resultado = ServicioInstructores.GuardarInstructor(NuevoInstructor);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void ObtenerInstructorPorId()
        {

            var resultado = ServicioInstructores.ObtenerInstructorPorId(1);
            Assert.AreEqual("Guillermo Zambrano Perez", resultado.NombreCompleto);
        }

        [TestMethod]
        public void CambiarEstatusInstructor()
        {

            var resultado = ServicioInstructores.CambiarEstatusInstructor(1,true);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void ActualizarDatosInstructor()
        {
            Instructor NuevoInstructor = new Instructor()
            {
                IdInstructor = 2,
                NombreCompleto = "Rosa Maria Galavis Robles"                
            };

            var resultado = ServicioInstructores.ActualizarInstructor(NuevoInstructor);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void GuardarNuevoGrupo()
        {
            Grupo NuevoGrupo = new Grupo()
            {
                 PNI = "001",
                 IdCampana = 1,
                 IdTurno = 1,
                 IdInstructor = 1,
                 InicioTeoria = new DateTime(2020,05,22),
                 FinTeoria = new DateTime(2020, 05, 29),
                 InicioOpc = new DateTime(2020, 05, 30),
                 FinOpc = new DateTime(2020, 06, 05),
            };

            var resultado = ServicioGrupo.GuardarGrupo(NuevoGrupo);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void ObtenerGruposActivos()
        {

            var resultado = ServicioGrupo.ListarGruposActivos().ToList();
            Assert.AreEqual(1, resultado.Count);
        }

        [TestMethod]
        public void ObtenerGrupoPorId()
        {

            var resultado = ServicioGrupo.ObtenerGrupoPorId(2);
            Assert.AreEqual("001", resultado.PNI);
        }

        [TestMethod]
        public void AsignarAspiranteAGrupo()
        {

            var resultado = ServicioGrupo.AsignarAspiranteGrupo(2, 5, 1);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void EliminarAspiranteDeGrupo()
        {

            var resultado = ServicioGrupo.RemoverAspiranteGrupo(5, 2);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void ActualizarDatosGrupo()
        {
            Grupo NuevoGrupo = new Grupo()
            {
                IdGrupo = 2,
                PNI = "001",
                IdCampana = 1,
                IdTurno = 2,
                IdInstructor = 1              
            };

            var resultado = ServicioGrupo.ActualizarGrupo(NuevoGrupo);
            Assert.AreEqual(1, resultado.Key);
        }

        [TestMethod]
        public void ObtenerAspirantesGrupo()
        {

            var resultado = ServicioGrupo.ObtenerAspirantesGrupo(2);
            Assert.AreEqual(4, resultado.Count());
        }
    }
}
