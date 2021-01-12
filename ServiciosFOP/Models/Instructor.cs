using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiciosFOP.Models
{
    [DataContract]
    public class Instructor
    {
        [DataMember]
        public int IdInstructor { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
        [DataMember]
        public bool Estatus { get; set; }
    }
}