﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebasSistemaFOP.ServicioGrupos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Grupo", Namespace="http://schemas.datacontract.org/2004/07/ServiciosFOP.Models")]
    [System.SerializableAttribute()]
    public partial class Grupo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CampanaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FinOpcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FinTeoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCampanaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdGrupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdInstructorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTurnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime InicioOpcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime InicioTeoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstructorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TurnoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Campana {
            get {
                return this.CampanaField;
            }
            set {
                if ((object.ReferenceEquals(this.CampanaField, value) != true)) {
                    this.CampanaField = value;
                    this.RaisePropertyChanged("Campana");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estatus {
            get {
                return this.EstatusField;
            }
            set {
                if ((this.EstatusField.Equals(value) != true)) {
                    this.EstatusField = value;
                    this.RaisePropertyChanged("Estatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FinOpc {
            get {
                return this.FinOpcField;
            }
            set {
                if ((this.FinOpcField.Equals(value) != true)) {
                    this.FinOpcField = value;
                    this.RaisePropertyChanged("FinOpc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FinTeoria {
            get {
                return this.FinTeoriaField;
            }
            set {
                if ((this.FinTeoriaField.Equals(value) != true)) {
                    this.FinTeoriaField = value;
                    this.RaisePropertyChanged("FinTeoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCampana {
            get {
                return this.IdCampanaField;
            }
            set {
                if ((this.IdCampanaField.Equals(value) != true)) {
                    this.IdCampanaField = value;
                    this.RaisePropertyChanged("IdCampana");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdGrupo {
            get {
                return this.IdGrupoField;
            }
            set {
                if ((this.IdGrupoField.Equals(value) != true)) {
                    this.IdGrupoField = value;
                    this.RaisePropertyChanged("IdGrupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdInstructor {
            get {
                return this.IdInstructorField;
            }
            set {
                if ((this.IdInstructorField.Equals(value) != true)) {
                    this.IdInstructorField = value;
                    this.RaisePropertyChanged("IdInstructor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTurno {
            get {
                return this.IdTurnoField;
            }
            set {
                if ((this.IdTurnoField.Equals(value) != true)) {
                    this.IdTurnoField = value;
                    this.RaisePropertyChanged("IdTurno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime InicioOpc {
            get {
                return this.InicioOpcField;
            }
            set {
                if ((this.InicioOpcField.Equals(value) != true)) {
                    this.InicioOpcField = value;
                    this.RaisePropertyChanged("InicioOpc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime InicioTeoria {
            get {
                return this.InicioTeoriaField;
            }
            set {
                if ((this.InicioTeoriaField.Equals(value) != true)) {
                    this.InicioTeoriaField = value;
                    this.RaisePropertyChanged("InicioTeoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Instructor {
            get {
                return this.InstructorField;
            }
            set {
                if ((object.ReferenceEquals(this.InstructorField, value) != true)) {
                    this.InstructorField = value;
                    this.RaisePropertyChanged("Instructor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PNI {
            get {
                return this.PNIField;
            }
            set {
                if ((object.ReferenceEquals(this.PNIField, value) != true)) {
                    this.PNIField = value;
                    this.RaisePropertyChanged("PNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Turno {
            get {
                return this.TurnoField;
            }
            set {
                if ((object.ReferenceEquals(this.TurnoField, value) != true)) {
                    this.TurnoField = value;
                    this.RaisePropertyChanged("Turno");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aspirante", Namespace="http://schemas.datacontract.org/2004/07/ServiciosFOP.Models")]
    [System.SerializableAttribute()]
    public partial class Aspirante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAspiranteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroEmpleadoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estatus {
            get {
                return this.EstatusField;
            }
            set {
                if ((this.EstatusField.Equals(value) != true)) {
                    this.EstatusField = value;
                    this.RaisePropertyChanged("Estatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAspirante {
            get {
                return this.IdAspiranteField;
            }
            set {
                if ((this.IdAspiranteField.Equals(value) != true)) {
                    this.IdAspiranteField = value;
                    this.RaisePropertyChanged("IdAspirante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroEmpleado {
            get {
                return this.NumeroEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroEmpleadoField, value) != true)) {
                    this.NumeroEmpleadoField = value;
                    this.RaisePropertyChanged("NumeroEmpleado");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioGrupos.IServiciosGrupos")]
    public interface IServiciosGrupos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ListarGruposActivos", ReplyAction="http://tempuri.org/IServiciosGrupos/ListarGruposActivosResponse")]
        PruebasSistemaFOP.ServicioGrupos.Grupo[] ListarGruposActivos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ListarGruposActivos", ReplyAction="http://tempuri.org/IServiciosGrupos/ListarGruposActivosResponse")]
        System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Grupo[]> ListarGruposActivosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/GuardarGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/GuardarGrupoResponse")]
        System.Collections.Generic.KeyValuePair<int, string> GuardarGrupo(PruebasSistemaFOP.ServicioGrupos.Grupo NuevoGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/GuardarGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/GuardarGrupoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> GuardarGrupoAsync(PruebasSistemaFOP.ServicioGrupos.Grupo NuevoGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ObtenerGrupoPorId", ReplyAction="http://tempuri.org/IServiciosGrupos/ObtenerGrupoPorIdResponse")]
        PruebasSistemaFOP.ServicioGrupos.Grupo ObtenerGrupoPorId(int IdGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ObtenerGrupoPorId", ReplyAction="http://tempuri.org/IServiciosGrupos/ObtenerGrupoPorIdResponse")]
        System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Grupo> ObtenerGrupoPorIdAsync(int IdGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ActualizarGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/ActualizarGrupoResponse")]
        System.Collections.Generic.KeyValuePair<int, string> ActualizarGrupo(PruebasSistemaFOP.ServicioGrupos.Grupo DatosGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ActualizarGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/ActualizarGrupoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> ActualizarGrupoAsync(PruebasSistemaFOP.ServicioGrupos.Grupo DatosGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ObtenerAspirantesGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/ObtenerAspirantesGrupoResponse")]
        PruebasSistemaFOP.ServicioGrupos.Aspirante[] ObtenerAspirantesGrupo(int IdGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/ObtenerAspirantesGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/ObtenerAspirantesGrupoResponse")]
        System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Aspirante[]> ObtenerAspirantesGrupoAsync(int IdGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/AsignarAspiranteGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/AsignarAspiranteGrupoResponse")]
        System.Collections.Generic.KeyValuePair<int, string> AsignarAspiranteGrupo(int IdGrupo, int IdAspirante, int IdInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/AsignarAspiranteGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/AsignarAspiranteGrupoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> AsignarAspiranteGrupoAsync(int IdGrupo, int IdAspirante, int IdInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/RemoverAspiranteGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/RemoverAspiranteGrupoResponse")]
        System.Collections.Generic.KeyValuePair<int, string> RemoverAspiranteGrupo(int IdAspirante, int IdGrupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosGrupos/RemoverAspiranteGrupo", ReplyAction="http://tempuri.org/IServiciosGrupos/RemoverAspiranteGrupoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> RemoverAspiranteGrupoAsync(int IdAspirante, int IdGrupo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosGruposChannel : PruebasSistemaFOP.ServicioGrupos.IServiciosGrupos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosGruposClient : System.ServiceModel.ClientBase<PruebasSistemaFOP.ServicioGrupos.IServiciosGrupos>, PruebasSistemaFOP.ServicioGrupos.IServiciosGrupos {
        
        public ServiciosGruposClient() {
        }
        
        public ServiciosGruposClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosGruposClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosGruposClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosGruposClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PruebasSistemaFOP.ServicioGrupos.Grupo[] ListarGruposActivos() {
            return base.Channel.ListarGruposActivos();
        }
        
        public System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Grupo[]> ListarGruposActivosAsync() {
            return base.Channel.ListarGruposActivosAsync();
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> GuardarGrupo(PruebasSistemaFOP.ServicioGrupos.Grupo NuevoGrupo) {
            return base.Channel.GuardarGrupo(NuevoGrupo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> GuardarGrupoAsync(PruebasSistemaFOP.ServicioGrupos.Grupo NuevoGrupo) {
            return base.Channel.GuardarGrupoAsync(NuevoGrupo);
        }
        
        public PruebasSistemaFOP.ServicioGrupos.Grupo ObtenerGrupoPorId(int IdGrupo) {
            return base.Channel.ObtenerGrupoPorId(IdGrupo);
        }
        
        public System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Grupo> ObtenerGrupoPorIdAsync(int IdGrupo) {
            return base.Channel.ObtenerGrupoPorIdAsync(IdGrupo);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> ActualizarGrupo(PruebasSistemaFOP.ServicioGrupos.Grupo DatosGrupo) {
            return base.Channel.ActualizarGrupo(DatosGrupo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> ActualizarGrupoAsync(PruebasSistemaFOP.ServicioGrupos.Grupo DatosGrupo) {
            return base.Channel.ActualizarGrupoAsync(DatosGrupo);
        }
        
        public PruebasSistemaFOP.ServicioGrupos.Aspirante[] ObtenerAspirantesGrupo(int IdGrupo) {
            return base.Channel.ObtenerAspirantesGrupo(IdGrupo);
        }
        
        public System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioGrupos.Aspirante[]> ObtenerAspirantesGrupoAsync(int IdGrupo) {
            return base.Channel.ObtenerAspirantesGrupoAsync(IdGrupo);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> AsignarAspiranteGrupo(int IdGrupo, int IdAspirante, int IdInstructor) {
            return base.Channel.AsignarAspiranteGrupo(IdGrupo, IdAspirante, IdInstructor);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> AsignarAspiranteGrupoAsync(int IdGrupo, int IdAspirante, int IdInstructor) {
            return base.Channel.AsignarAspiranteGrupoAsync(IdGrupo, IdAspirante, IdInstructor);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> RemoverAspiranteGrupo(int IdAspirante, int IdGrupo) {
            return base.Channel.RemoverAspiranteGrupo(IdAspirante, IdGrupo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> RemoverAspiranteGrupoAsync(int IdAspirante, int IdGrupo) {
            return base.Channel.RemoverAspiranteGrupoAsync(IdAspirante, IdGrupo);
        }
    }
}