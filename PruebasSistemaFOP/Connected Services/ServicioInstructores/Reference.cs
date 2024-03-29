﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebasSistemaFOP.ServicioInstructores {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Instructor", Namespace="http://schemas.datacontract.org/2004/07/ServiciosFOP.Models")]
    [System.SerializableAttribute()]
    public partial class Instructor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdInstructorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCompletoField;
        
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
        public string NombreCompleto {
            get {
                return this.NombreCompletoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCompletoField, value) != true)) {
                    this.NombreCompletoField = value;
                    this.RaisePropertyChanged("NombreCompleto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioInstructores.IServicioInstructor")]
    public interface IServicioInstructor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ListarInstructoresActivos", ReplyAction="http://tempuri.org/IServicioInstructor/ListarInstructoresActivosResponse")]
        PruebasSistemaFOP.ServicioInstructores.Instructor[] ListarInstructoresActivos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ListarInstructoresActivos", ReplyAction="http://tempuri.org/IServicioInstructor/ListarInstructoresActivosResponse")]
        System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioInstructores.Instructor[]> ListarInstructoresActivosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ObtenerInstructorPorId", ReplyAction="http://tempuri.org/IServicioInstructor/ObtenerInstructorPorIdResponse")]
        PruebasSistemaFOP.ServicioInstructores.Instructor ObtenerInstructorPorId(int IdInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ObtenerInstructorPorId", ReplyAction="http://tempuri.org/IServicioInstructor/ObtenerInstructorPorIdResponse")]
        System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioInstructores.Instructor> ObtenerInstructorPorIdAsync(int IdInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/GuardarInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/GuardarInstructorResponse")]
        System.Collections.Generic.KeyValuePair<int, string> GuardarInstructor(PruebasSistemaFOP.ServicioInstructores.Instructor NuevoInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/GuardarInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/GuardarInstructorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> GuardarInstructorAsync(PruebasSistemaFOP.ServicioInstructores.Instructor NuevoInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/CambiarEstatusInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/CambiarEstatusInstructorResponse")]
        System.Collections.Generic.KeyValuePair<int, string> CambiarEstatusInstructor(int IdInstructor, bool NuevoEstatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/CambiarEstatusInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/CambiarEstatusInstructorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> CambiarEstatusInstructorAsync(int IdInstructor, bool NuevoEstatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ActualizarInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/ActualizarInstructorResponse")]
        System.Collections.Generic.KeyValuePair<int, string> ActualizarInstructor(PruebasSistemaFOP.ServicioInstructores.Instructor DatosInstructor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioInstructor/ActualizarInstructor", ReplyAction="http://tempuri.org/IServicioInstructor/ActualizarInstructorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> ActualizarInstructorAsync(PruebasSistemaFOP.ServicioInstructores.Instructor DatosInstructor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioInstructorChannel : PruebasSistemaFOP.ServicioInstructores.IServicioInstructor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioInstructorClient : System.ServiceModel.ClientBase<PruebasSistemaFOP.ServicioInstructores.IServicioInstructor>, PruebasSistemaFOP.ServicioInstructores.IServicioInstructor {
        
        public ServicioInstructorClient() {
        }
        
        public ServicioInstructorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioInstructorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioInstructorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioInstructorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PruebasSistemaFOP.ServicioInstructores.Instructor[] ListarInstructoresActivos() {
            return base.Channel.ListarInstructoresActivos();
        }
        
        public System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioInstructores.Instructor[]> ListarInstructoresActivosAsync() {
            return base.Channel.ListarInstructoresActivosAsync();
        }
        
        public PruebasSistemaFOP.ServicioInstructores.Instructor ObtenerInstructorPorId(int IdInstructor) {
            return base.Channel.ObtenerInstructorPorId(IdInstructor);
        }
        
        public System.Threading.Tasks.Task<PruebasSistemaFOP.ServicioInstructores.Instructor> ObtenerInstructorPorIdAsync(int IdInstructor) {
            return base.Channel.ObtenerInstructorPorIdAsync(IdInstructor);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> GuardarInstructor(PruebasSistemaFOP.ServicioInstructores.Instructor NuevoInstructor) {
            return base.Channel.GuardarInstructor(NuevoInstructor);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> GuardarInstructorAsync(PruebasSistemaFOP.ServicioInstructores.Instructor NuevoInstructor) {
            return base.Channel.GuardarInstructorAsync(NuevoInstructor);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> CambiarEstatusInstructor(int IdInstructor, bool NuevoEstatus) {
            return base.Channel.CambiarEstatusInstructor(IdInstructor, NuevoEstatus);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> CambiarEstatusInstructorAsync(int IdInstructor, bool NuevoEstatus) {
            return base.Channel.CambiarEstatusInstructorAsync(IdInstructor, NuevoEstatus);
        }
        
        public System.Collections.Generic.KeyValuePair<int, string> ActualizarInstructor(PruebasSistemaFOP.ServicioInstructores.Instructor DatosInstructor) {
            return base.Channel.ActualizarInstructor(DatosInstructor);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> ActualizarInstructorAsync(PruebasSistemaFOP.ServicioInstructores.Instructor DatosInstructor) {
            return base.Channel.ActualizarInstructorAsync(DatosInstructor);
        }
    }
}
