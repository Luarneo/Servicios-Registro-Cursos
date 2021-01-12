using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosFOP
{
    [ServiceContract]
    public interface IServicioCatalogos
    {
        [OperationContract]
        List<KeyValuePair<int, string>> ObtenerCampanas();

        [OperationContract]
        List<KeyValuePair<int, string>> ObtenerTurnos();
    }      
}
