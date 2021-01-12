using ServiciosFOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosFOP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioInstructor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioInstructor
    {
        [OperationContract]
        List<Instructor> ListarInstructoresActivos();

        [OperationContract]
        Instructor ObtenerInstructorPorId(int IdInstructor);

        [OperationContract]
        KeyValuePair<int,string> GuardarInstructor(Instructor NuevoInstructor);

        [OperationContract]
        KeyValuePair<int, string> CambiarEstatusInstructor(int IdInstructor, bool NuevoEstatus);

        [OperationContract]
        KeyValuePair<int, string> ActualizarInstructor(Instructor DatosInstructor);
    }
}
