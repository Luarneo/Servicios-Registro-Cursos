using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiciosFOP.Models
{
    [DataContract]
    public class Aspirante
    {
        [DataMember]
        public int IdAspirante { get; set; }
        [DataMember]
        public string NumeroEmpleado { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]       
        public bool Estatus { get; set; }        
    }
}