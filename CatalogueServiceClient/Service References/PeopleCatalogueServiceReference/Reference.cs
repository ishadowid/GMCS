﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatalogueServiceClient.PeopleCatalogueServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/CatalogueService")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonNotFound", Namespace="http://schemas.datacontract.org/2004/07/CatalogueService")]
    [System.SerializableAttribute()]
    public partial class PersonNotFound : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleCatalogueServiceReference.IPeopleCatalogueService")]
    public interface IPeopleCatalogueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/GetAddressBook", ReplyAction="http://tempuri.org/IPeopleCatalogueService/GetAddressBookResponse")]
        CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] GetAddressBook();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/GetAddressBook", ReplyAction="http://tempuri.org/IPeopleCatalogueService/GetAddressBookResponse")]
        System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> GetAddressBookAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/SearchPersonByPhone", ReplyAction="http://tempuri.org/IPeopleCatalogueService/SearchPersonByPhoneResponse")]
        CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] SearchPersonByPhone(string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/SearchPersonByPhone", ReplyAction="http://tempuri.org/IPeopleCatalogueService/SearchPersonByPhoneResponse")]
        System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> SearchPersonByPhoneAsync(string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/SearchPersonByName", ReplyAction="http://tempuri.org/IPeopleCatalogueService/SearchPersonByNameResponse")]
        CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] SearchPersonByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/SearchPersonByName", ReplyAction="http://tempuri.org/IPeopleCatalogueService/SearchPersonByNameResponse")]
        System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> SearchPersonByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/AddPerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/AddPersonResponse")]
        int AddPerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/AddPerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/AddPersonResponse")]
        System.Threading.Tasks.Task<int> AddPersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/UpdatePerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/UpdatePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CatalogueServiceClient.PeopleCatalogueServiceReference.PersonNotFound), Action="http://tempuri.org/IPeopleCatalogueService/UpdatePersonPersonNotFoundFault", Name="PersonNotFound", Namespace="http://schemas.datacontract.org/2004/07/CatalogueService")]
        void UpdatePerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/UpdatePerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/DeletePerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/DeletePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CatalogueServiceClient.PeopleCatalogueServiceReference.PersonNotFound), Action="http://tempuri.org/IPeopleCatalogueService/DeletePersonPersonNotFoundFault", Name="PersonNotFound", Namespace="http://schemas.datacontract.org/2004/07/CatalogueService")]
        void DeletePerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleCatalogueService/DeletePerson", ReplyAction="http://tempuri.org/IPeopleCatalogueService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleCatalogueServiceChannel : CatalogueServiceClient.PeopleCatalogueServiceReference.IPeopleCatalogueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleCatalogueServiceClient : System.ServiceModel.ClientBase<CatalogueServiceClient.PeopleCatalogueServiceReference.IPeopleCatalogueService>, CatalogueServiceClient.PeopleCatalogueServiceReference.IPeopleCatalogueService {
        
        public PeopleCatalogueServiceClient() {
        }
        
        public PeopleCatalogueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleCatalogueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleCatalogueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleCatalogueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] GetAddressBook() {
            return base.Channel.GetAddressBook();
        }
        
        public System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> GetAddressBookAsync() {
            return base.Channel.GetAddressBookAsync();
        }
        
        public CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] SearchPersonByPhone(string phoneNumber) {
            return base.Channel.SearchPersonByPhone(phoneNumber);
        }
        
        public System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> SearchPersonByPhoneAsync(string phoneNumber) {
            return base.Channel.SearchPersonByPhoneAsync(phoneNumber);
        }
        
        public CatalogueServiceClient.PeopleCatalogueServiceReference.Person[] SearchPersonByName(string name) {
            return base.Channel.SearchPersonByName(name);
        }
        
        public System.Threading.Tasks.Task<CatalogueServiceClient.PeopleCatalogueServiceReference.Person[]> SearchPersonByNameAsync(string name) {
            return base.Channel.SearchPersonByNameAsync(name);
        }
        
        public int AddPerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            return base.Channel.AddPerson(newPerson);
        }
        
        public System.Threading.Tasks.Task<int> AddPersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            return base.Channel.AddPersonAsync(newPerson);
        }
        
        public void UpdatePerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            base.Channel.UpdatePerson(newPerson);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            return base.Channel.UpdatePersonAsync(newPerson);
        }
        
        public void DeletePerson(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            base.Channel.DeletePerson(newPerson);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(CatalogueServiceClient.PeopleCatalogueServiceReference.Person newPerson) {
            return base.Channel.DeletePersonAsync(newPerson);
        }
    }
}