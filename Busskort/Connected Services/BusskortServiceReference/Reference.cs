﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Busskort.BusskortServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Anmälan", Namespace="http://schemas.datacontract.org/2004/07/BusskortService")]
    [System.SerializableAttribute()]
    public partial class Anmälan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BeviljadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string E_postField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EfternamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FörnamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MotiveringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostnummerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkolaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string barnEfternamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string barnFörnamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int barnPersonnummerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ÅrskursField;
        
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
        public string Adress {
            get {
                return this.AdressField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressField, value) != true)) {
                    this.AdressField = value;
                    this.RaisePropertyChanged("Adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Beviljad {
            get {
                return this.BeviljadField;
            }
            set {
                if ((object.ReferenceEquals(this.BeviljadField, value) != true)) {
                    this.BeviljadField = value;
                    this.RaisePropertyChanged("Beviljad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string E_post {
            get {
                return this.E_postField;
            }
            set {
                if ((object.ReferenceEquals(this.E_postField, value) != true)) {
                    this.E_postField = value;
                    this.RaisePropertyChanged("E_post");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Efternamn {
            get {
                return this.EfternamnField;
            }
            set {
                if ((object.ReferenceEquals(this.EfternamnField, value) != true)) {
                    this.EfternamnField = value;
                    this.RaisePropertyChanged("Efternamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Förnamn {
            get {
                return this.FörnamnField;
            }
            set {
                if ((object.ReferenceEquals(this.FörnamnField, value) != true)) {
                    this.FörnamnField = value;
                    this.RaisePropertyChanged("Förnamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Motivering {
            get {
                return this.MotiveringField;
            }
            set {
                if ((object.ReferenceEquals(this.MotiveringField, value) != true)) {
                    this.MotiveringField = value;
                    this.RaisePropertyChanged("Motivering");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ort {
            get {
                return this.OrtField;
            }
            set {
                if ((object.ReferenceEquals(this.OrtField, value) != true)) {
                    this.OrtField = value;
                    this.RaisePropertyChanged("Ort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Postnummer {
            get {
                return this.PostnummerField;
            }
            set {
                if ((this.PostnummerField.Equals(value) != true)) {
                    this.PostnummerField = value;
                    this.RaisePropertyChanged("Postnummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Skola {
            get {
                return this.SkolaField;
            }
            set {
                if ((object.ReferenceEquals(this.SkolaField, value) != true)) {
                    this.SkolaField = value;
                    this.RaisePropertyChanged("Skola");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefon {
            get {
                return this.TelefonField;
            }
            set {
                if ((this.TelefonField.Equals(value) != true)) {
                    this.TelefonField = value;
                    this.RaisePropertyChanged("Telefon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string barnEfternamn {
            get {
                return this.barnEfternamnField;
            }
            set {
                if ((object.ReferenceEquals(this.barnEfternamnField, value) != true)) {
                    this.barnEfternamnField = value;
                    this.RaisePropertyChanged("barnEfternamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string barnFörnamn {
            get {
                return this.barnFörnamnField;
            }
            set {
                if ((object.ReferenceEquals(this.barnFörnamnField, value) != true)) {
                    this.barnFörnamnField = value;
                    this.RaisePropertyChanged("barnFörnamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int barnPersonnummer {
            get {
                return this.barnPersonnummerField;
            }
            set {
                if ((this.barnPersonnummerField.Equals(value) != true)) {
                    this.barnPersonnummerField = value;
                    this.RaisePropertyChanged("barnPersonnummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Årskurs {
            get {
                return this.ÅrskursField;
            }
            set {
                if ((this.ÅrskursField.Equals(value) != true)) {
                    this.ÅrskursField = value;
                    this.RaisePropertyChanged("Årskurs");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AnmälanInput", Namespace="http://schemas.datacontract.org/2004/07/BusskortService")]
    [System.SerializableAttribute()]
    public partial class AnmälanInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BeviljadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string E_postField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EfternamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FörnamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MotiveringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostnummerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkolaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string barnEfternamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string barnFörnamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int barnPersonnummerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ÅrskursField;
        
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
        public string Adress {
            get {
                return this.AdressField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressField, value) != true)) {
                    this.AdressField = value;
                    this.RaisePropertyChanged("Adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Beviljad {
            get {
                return this.BeviljadField;
            }
            set {
                if ((object.ReferenceEquals(this.BeviljadField, value) != true)) {
                    this.BeviljadField = value;
                    this.RaisePropertyChanged("Beviljad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string E_post {
            get {
                return this.E_postField;
            }
            set {
                if ((object.ReferenceEquals(this.E_postField, value) != true)) {
                    this.E_postField = value;
                    this.RaisePropertyChanged("E_post");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Efternamn {
            get {
                return this.EfternamnField;
            }
            set {
                if ((object.ReferenceEquals(this.EfternamnField, value) != true)) {
                    this.EfternamnField = value;
                    this.RaisePropertyChanged("Efternamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Förnamn {
            get {
                return this.FörnamnField;
            }
            set {
                if ((object.ReferenceEquals(this.FörnamnField, value) != true)) {
                    this.FörnamnField = value;
                    this.RaisePropertyChanged("Förnamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Motivering {
            get {
                return this.MotiveringField;
            }
            set {
                if ((object.ReferenceEquals(this.MotiveringField, value) != true)) {
                    this.MotiveringField = value;
                    this.RaisePropertyChanged("Motivering");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ort {
            get {
                return this.OrtField;
            }
            set {
                if ((object.ReferenceEquals(this.OrtField, value) != true)) {
                    this.OrtField = value;
                    this.RaisePropertyChanged("Ort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Postnummer {
            get {
                return this.PostnummerField;
            }
            set {
                if ((this.PostnummerField.Equals(value) != true)) {
                    this.PostnummerField = value;
                    this.RaisePropertyChanged("Postnummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Skola {
            get {
                return this.SkolaField;
            }
            set {
                if ((object.ReferenceEquals(this.SkolaField, value) != true)) {
                    this.SkolaField = value;
                    this.RaisePropertyChanged("Skola");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefon {
            get {
                return this.TelefonField;
            }
            set {
                if ((this.TelefonField.Equals(value) != true)) {
                    this.TelefonField = value;
                    this.RaisePropertyChanged("Telefon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string barnEfternamn {
            get {
                return this.barnEfternamnField;
            }
            set {
                if ((object.ReferenceEquals(this.barnEfternamnField, value) != true)) {
                    this.barnEfternamnField = value;
                    this.RaisePropertyChanged("barnEfternamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string barnFörnamn {
            get {
                return this.barnFörnamnField;
            }
            set {
                if ((object.ReferenceEquals(this.barnFörnamnField, value) != true)) {
                    this.barnFörnamnField = value;
                    this.RaisePropertyChanged("barnFörnamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int barnPersonnummer {
            get {
                return this.barnPersonnummerField;
            }
            set {
                if ((this.barnPersonnummerField.Equals(value) != true)) {
                    this.barnPersonnummerField = value;
                    this.RaisePropertyChanged("barnPersonnummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Årskurs {
            get {
                return this.ÅrskursField;
            }
            set {
                if ((this.ÅrskursField.Equals(value) != true)) {
                    this.ÅrskursField = value;
                    this.RaisePropertyChanged("Årskurs");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusskortServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAnmälanList", ReplyAction="http://tempuri.org/IService1/GetAnmälanListResponse")]
        Busskort.BusskortServiceReference.Anmälan[] GetAnmälanList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAnmälanList", ReplyAction="http://tempuri.org/IService1/GetAnmälanListResponse")]
        System.Threading.Tasks.Task<Busskort.BusskortServiceReference.Anmälan[]> GetAnmälanListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAnmälan", ReplyAction="http://tempuri.org/IService1/GetAnmälanResponse")]
        Busskort.BusskortServiceReference.Anmälan GetAnmälan(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAnmälan", ReplyAction="http://tempuri.org/IService1/GetAnmälanResponse")]
        System.Threading.Tasks.Task<Busskort.BusskortServiceReference.Anmälan> GetAnmälanAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAnmälan", ReplyAction="http://tempuri.org/IService1/DeleteAnmälanResponse")]
        void DeleteAnmälan(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAnmälan", ReplyAction="http://tempuri.org/IService1/DeleteAnmälanResponse")]
        System.Threading.Tasks.Task DeleteAnmälanAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAnmälan", ReplyAction="http://tempuri.org/IService1/UpdateAnmälanResponse")]
        void UpdateAnmälan(Busskort.BusskortServiceReference.AnmälanInput anmälanInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAnmälan", ReplyAction="http://tempuri.org/IService1/UpdateAnmälanResponse")]
        System.Threading.Tasks.Task UpdateAnmälanAsync(Busskort.BusskortServiceReference.AnmälanInput anmälanInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAnmälan", ReplyAction="http://tempuri.org/IService1/CreateAnmälanResponse")]
        void CreateAnmälan(Busskort.BusskortServiceReference.AnmälanInput anmälanInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAnmälan", ReplyAction="http://tempuri.org/IService1/CreateAnmälanResponse")]
        System.Threading.Tasks.Task CreateAnmälanAsync(Busskort.BusskortServiceReference.AnmälanInput anmälanInput);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Busskort.BusskortServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Busskort.BusskortServiceReference.IService1>, Busskort.BusskortServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Busskort.BusskortServiceReference.Anmälan[] GetAnmälanList() {
            return base.Channel.GetAnmälanList();
        }
        
        public System.Threading.Tasks.Task<Busskort.BusskortServiceReference.Anmälan[]> GetAnmälanListAsync() {
            return base.Channel.GetAnmälanListAsync();
        }
        
        public Busskort.BusskortServiceReference.Anmälan GetAnmälan(int id) {
            return base.Channel.GetAnmälan(id);
        }
        
        public System.Threading.Tasks.Task<Busskort.BusskortServiceReference.Anmälan> GetAnmälanAsync(int id) {
            return base.Channel.GetAnmälanAsync(id);
        }
        
        public void DeleteAnmälan(int id) {
            base.Channel.DeleteAnmälan(id);
        }
        
        public System.Threading.Tasks.Task DeleteAnmälanAsync(int id) {
            return base.Channel.DeleteAnmälanAsync(id);
        }
        
        public void UpdateAnmälan(Busskort.BusskortServiceReference.AnmälanInput anmälanInput) {
            base.Channel.UpdateAnmälan(anmälanInput);
        }
        
        public System.Threading.Tasks.Task UpdateAnmälanAsync(Busskort.BusskortServiceReference.AnmälanInput anmälanInput) {
            return base.Channel.UpdateAnmälanAsync(anmälanInput);
        }
        
        public void CreateAnmälan(Busskort.BusskortServiceReference.AnmälanInput anmälanInput) {
            base.Channel.CreateAnmälan(anmälanInput);
        }
        
        public System.Threading.Tasks.Task CreateAnmälanAsync(Busskort.BusskortServiceReference.AnmälanInput anmälanInput) {
            return base.Channel.CreateAnmälanAsync(anmälanInput);
        }
    }
}
