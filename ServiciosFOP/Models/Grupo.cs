using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace ServiciosFOP.Models
{
    [DataContract]
    public class Grupo
    {
        [DataMember]
        public int IdGrupo { get; set; }

        [DataMember]
        public string PNI { get; set; }
        [DataMember]
        public int IdCampana { get; set; }

        [DataMember]
        public int IdTurno { get; set; }

        [DataMember]
        public string Campana { get; set; }

        [DataMember]
        public string Turno { get; set; }

        [DataMember]
        public int IdInstructor { get; set; }

        [DataMember]
        public string Instructor { get; set; }

        [DataMember]
        public bool Estatus { get; set; }

        [DataMember]
        public DateTime InicioTeoria { get; set; }

        [DataMember]
        public DateTime FinTeoria { get; set; }

        [DataMember]
        public DateTime InicioOpc { get; set; }

        [DataMember]
        public DateTime FinOpc { get; set; }



    }
}