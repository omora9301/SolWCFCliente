﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClienteLibreriaDosCapas.ServiceLibreria {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntRespuesta", Namespace="http://schemas.datacontract.org/2004/07/EntityLibreria")]
    [System.SerializableAttribute()]
    public partial class EntRespuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria EntLibreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria[] LibrosListaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFClienteLibreriaDosCapas.ServiceLibreria.EntCategoria[] ListaCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MsjField;
        
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
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria EntLibre {
            get {
                return this.EntLibreField;
            }
            set {
                if ((object.ReferenceEquals(this.EntLibreField, value) != true)) {
                    this.EntLibreField = value;
                    this.RaisePropertyChanged("EntLibre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((this.ErrorField.Equals(value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria[] LibrosLista {
            get {
                return this.LibrosListaField;
            }
            set {
                if ((object.ReferenceEquals(this.LibrosListaField, value) != true)) {
                    this.LibrosListaField = value;
                    this.RaisePropertyChanged("LibrosLista");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntCategoria[] ListaCategoria {
            get {
                return this.ListaCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaCategoriaField, value) != true)) {
                    this.ListaCategoriaField = value;
                    this.RaisePropertyChanged("ListaCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Msj {
            get {
                return this.MsjField;
            }
            set {
                if ((object.ReferenceEquals(this.MsjField, value) != true)) {
                    this.MsjField = value;
                    this.RaisePropertyChanged("Msj");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntLibreria", Namespace="http://schemas.datacontract.org/2004/07/EntityLibreria")]
    [System.SerializableAttribute()]
    public partial class EntLibreria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EdicionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFClienteLibreriaDosCapas.ServiceLibreria.EntCategoria EntCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
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
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((this.CategoriaField.Equals(value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Edicion {
            get {
                return this.EdicionField;
            }
            set {
                if ((object.ReferenceEquals(this.EdicionField, value) != true)) {
                    this.EdicionField = value;
                    this.RaisePropertyChanged("Edicion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialField, value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntCategoria EntCategoria {
            get {
                return this.EntCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.EntCategoriaField, value) != true)) {
                    this.EntCategoriaField = value;
                    this.RaisePropertyChanged("EntCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntCategoria", Namespace="http://schemas.datacontract.org/2004/07/EntityLibreria")]
    [System.SerializableAttribute()]
    public partial class EntCategoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCField;
        
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
        public int IdC {
            get {
                return this.IdCField;
            }
            set {
                if ((this.IdCField.Equals(value) != true)) {
                    this.IdCField = value;
                    this.RaisePropertyChanged("IdC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreC {
            get {
                return this.NombreCField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCField, value) != true)) {
                    this.NombreCField = value;
                    this.RaisePropertyChanged("NombreC");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLibreria.IServiceLibreria")]
    public interface IServiceLibreria {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Obtener", ReplyAction="http://tempuri.org/IServiceLibreria/ObtenerResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Obtener();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Obtener", ReplyAction="http://tempuri.org/IServiceLibreria/ObtenerResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ObtenerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/ObtenerC", ReplyAction="http://tempuri.org/IServiceLibreria/ObtenerCResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta ObtenerC();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/ObtenerC", ReplyAction="http://tempuri.org/IServiceLibreria/ObtenerCResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ObtenerCAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/IdObtener", ReplyAction="http://tempuri.org/IServiceLibreria/IdObtenerResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta IdObtener(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/IdObtener", ReplyAction="http://tempuri.org/IServiceLibreria/IdObtenerResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> IdObtenerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Actualizar", ReplyAction="http://tempuri.org/IServiceLibreria/ActualizarResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Actualizar(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Actualizar", ReplyAction="http://tempuri.org/IServiceLibreria/ActualizarResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ActualizarAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Agregar", ReplyAction="http://tempuri.org/IServiceLibreria/AgregarResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Agregar(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Agregar", ReplyAction="http://tempuri.org/IServiceLibreria/AgregarResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> AgregarAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Buscar", ReplyAction="http://tempuri.org/IServiceLibreria/BuscarResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Buscar(string valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Buscar", ReplyAction="http://tempuri.org/IServiceLibreria/BuscarResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> BuscarAsync(string valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Eliminar", ReplyAction="http://tempuri.org/IServiceLibreria/EliminarResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Eliminar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/Eliminar", ReplyAction="http://tempuri.org/IServiceLibreria/EliminarResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> EliminarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/ValidarRepetido", ReplyAction="http://tempuri.org/IServiceLibreria/ValidarRepetidoResponse")]
        WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta ValidarRepetido(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibreria/ValidarRepetido", ReplyAction="http://tempuri.org/IServiceLibreria/ValidarRepetidoResponse")]
        System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ValidarRepetidoAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLibreriaChannel : WCFClienteLibreriaDosCapas.ServiceLibreria.IServiceLibreria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLibreriaClient : System.ServiceModel.ClientBase<WCFClienteLibreriaDosCapas.ServiceLibreria.IServiceLibreria>, WCFClienteLibreriaDosCapas.ServiceLibreria.IServiceLibreria {
        
        public ServiceLibreriaClient() {
        }
        
        public ServiceLibreriaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLibreriaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLibreriaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLibreriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Obtener() {
            return base.Channel.Obtener();
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ObtenerAsync() {
            return base.Channel.ObtenerAsync();
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta ObtenerC() {
            return base.Channel.ObtenerC();
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ObtenerCAsync() {
            return base.Channel.ObtenerCAsync();
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta IdObtener(int id) {
            return base.Channel.IdObtener(id);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> IdObtenerAsync(int id) {
            return base.Channel.IdObtenerAsync(id);
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Actualizar(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.Actualizar(l);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ActualizarAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.ActualizarAsync(l);
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Agregar(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.Agregar(l);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> AgregarAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.AgregarAsync(l);
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Buscar(string valor) {
            return base.Channel.Buscar(valor);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> BuscarAsync(string valor) {
            return base.Channel.BuscarAsync(valor);
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta Eliminar(int id) {
            return base.Channel.Eliminar(id);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> EliminarAsync(int id) {
            return base.Channel.EliminarAsync(id);
        }
        
        public WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta ValidarRepetido(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.ValidarRepetido(l);
        }
        
        public System.Threading.Tasks.Task<WCFClienteLibreriaDosCapas.ServiceLibreria.EntRespuesta> ValidarRepetidoAsync(WCFClienteLibreriaDosCapas.ServiceLibreria.EntLibreria l) {
            return base.Channel.ValidarRepetidoAsync(l);
        }
    }
}
