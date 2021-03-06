//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDTEST.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfStudent")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long StudentIdField;
        
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
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegisterNo {
            get {
                return this.RegisterNoField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterNoField, value) != true)) {
                    this.RegisterNoField = value;
                    this.RaisePropertyChanged("RegisterNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long StudentId {
            get {
                return this.StudentIdField;
            }
            set {
                if ((this.StudentIdField.Equals(value) != true)) {
                    this.StudentIdField = value;
                    this.RaisePropertyChanged("StudentId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfStudent")]
    [System.SerializableAttribute()]
    public partial class ExceptionMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageOfActionField;
        
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
        public string errorMessageOfAction {
            get {
                return this.errorMessageOfActionField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageOfActionField, value) != true)) {
                    this.errorMessageOfActionField = value;
                    this.RaisePropertyChanged("errorMessageOfAction");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudents", ReplyAction="http://tempuri.org/IService1/GetStudentsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CRUDTEST.ServiceReference2.ExceptionMessage), Action="http://tempuri.org/IService1/GetStudentsExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfStudent")]
        CRUDTEST.ServiceReference2.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudents", ReplyAction="http://tempuri.org/IService1/GetStudentsResponse")]
        System.Threading.Tasks.Task<CRUDTEST.ServiceReference2.Student[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudents", ReplyAction="http://tempuri.org/IService1/AddStudentsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CRUDTEST.ServiceReference2.ExceptionMessage), Action="http://tempuri.org/IService1/AddStudentsExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfStudent")]
        void AddStudents(CRUDTEST.ServiceReference2.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudents", ReplyAction="http://tempuri.org/IService1/AddStudentsResponse")]
        System.Threading.Tasks.Task AddStudentsAsync(CRUDTEST.ServiceReference2.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CRUDTEST.ServiceReference2.ExceptionMessage), Action="http://tempuri.org/IService1/DeleteStudentExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfStudent")]
        void DeleteStudent(long StudentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(long StudentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CRUDTEST.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CRUDTEST.ServiceReference2.IService1>, CRUDTEST.ServiceReference2.IService1 {
        
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
        
        public CRUDTEST.ServiceReference2.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<CRUDTEST.ServiceReference2.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public void AddStudents(CRUDTEST.ServiceReference2.Student student) {
            base.Channel.AddStudents(student);
        }
        
        public System.Threading.Tasks.Task AddStudentsAsync(CRUDTEST.ServiceReference2.Student student) {
            return base.Channel.AddStudentsAsync(student);
        }
        
        public void DeleteStudent(long StudentId) {
            base.Channel.DeleteStudent(StudentId);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(long StudentId) {
            return base.Channel.DeleteStudentAsync(StudentId);
        }
    }
}
