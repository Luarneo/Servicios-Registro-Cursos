using ServiciosFOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosFOP
{
    [ServiceContract]
    interface IServicioAgente
    {
        [OperationContract]
        KeyValuePair<int,string> GuardarAspirate(Aspirante NuevoAspirante);

        [OperationContract]
        List<Aspirante> ListarAspirantesActivos();

        [OperationContract]
        Aspirante ObtenerAspirantePorId(int IdAspirante);

        [OperationContract]
        KeyValuePair<int, string> ActualizarAspirante(int IdAspirante, bool NuevoEstatus);

        [OperationContract]
        List<Aspirante> ObtenerAspirantesSinGrupo();
    }
}
