using ServiciosFOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosFOP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosGrupos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosGrupos
    {        
        [OperationContract]
        List<Grupo> ListarGruposActivos();

        [OperationContract]
        KeyValuePair<int, string> GuardarGrupo(Grupo NuevoGrupo);

        [OperationContract]
        Grupo ObtenerGrupoPorId(int IdGrupo);

        [OperationContract]
        KeyValuePair<int, string> ActualizarGrupo(Grupo DatosGrupo);

        [OperationContract]
        List<Aspirante> ObtenerAspirantesGrupo(int IdGrupo);

        [OperationContract]
        KeyValuePair<int, string> AsignarAspiranteGrupo(int IdGrupo, int IdAspirante, int IdInstructor);

        [OperationContract]
        KeyValuePair<int, string> RemoverAspiranteGrupo(int IdAspirante, int IdGrupo);
    }
}
