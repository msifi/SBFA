﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBFA.sbfaSecurity {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationResponse", Namespace="http://schemas.datacontract.org/2004/07/SBFA")]
    [System.SerializableAttribute()]
    public partial class AuthenticationResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string accessTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool authenticationStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int responseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string responseMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public string accessToken {
            get {
                return this.accessTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.accessTokenField, value) != true)) {
                    this.accessTokenField = value;
                    this.RaisePropertyChanged("accessToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool authenticationStatus {
            get {
                return this.authenticationStatusField;
            }
            set {
                if ((this.authenticationStatusField.Equals(value) != true)) {
                    this.authenticationStatusField = value;
                    this.RaisePropertyChanged("authenticationStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int responseCode {
            get {
                return this.responseCodeField;
            }
            set {
                if ((this.responseCodeField.Equals(value) != true)) {
                    this.responseCodeField = value;
                    this.RaisePropertyChanged("responseCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string responseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.responseMessageField, value) != true)) {
                    this.responseMessageField = value;
                    this.RaisePropertyChanged("responseMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PasswordChangeResponse", Namespace="http://schemas.datacontract.org/2004/07/SBFA")]
    [System.SerializableAttribute()]
    public partial class PasswordChangeResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool changeStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string responseMessageField;
        
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
        public bool changeStatus {
            get {
                return this.changeStatusField;
            }
            set {
                if ((this.changeStatusField.Equals(value) != true)) {
                    this.changeStatusField = value;
                    this.RaisePropertyChanged("changeStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string responseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.responseMessageField, value) != true)) {
                    this.responseMessageField = value;
                    this.RaisePropertyChanged("responseMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="sbfaSecurity.ISBFASecurity")]
    public interface ISBFASecurity {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/Authenticate", ReplyAction="http://tempuri.org/ISBFASecurity/AuthenticateResponse")]
        SBFA.sbfaSecurity.AuthenticationResponse Authenticate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/Authenticate", ReplyAction="http://tempuri.org/ISBFASecurity/AuthenticateResponse")]
        System.Threading.Tasks.Task<SBFA.sbfaSecurity.AuthenticationResponse> AuthenticateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/ChangePassword", ReplyAction="http://tempuri.org/ISBFASecurity/ChangePasswordResponse")]
        SBFA.sbfaSecurity.PasswordChangeResponse ChangePassword(string username, string oldpassword, string newpassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/ChangePassword", ReplyAction="http://tempuri.org/ISBFASecurity/ChangePasswordResponse")]
        System.Threading.Tasks.Task<SBFA.sbfaSecurity.PasswordChangeResponse> ChangePasswordAsync(string username, string oldpassword, string newpassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/UpdateUserDetails", ReplyAction="http://tempuri.org/ISBFASecurity/UpdateUserDetailsResponse")]
        bool UpdateUserDetails(string userName, string FirstName, string Surname, string EmailAddress, string MobileNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISBFASecurity/UpdateUserDetails", ReplyAction="http://tempuri.org/ISBFASecurity/UpdateUserDetailsResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserDetailsAsync(string userName, string FirstName, string Surname, string EmailAddress, string MobileNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISBFASecurityChannel : SBFA.sbfaSecurity.ISBFASecurity, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SBFASecurityClient : System.ServiceModel.ClientBase<SBFA.sbfaSecurity.ISBFASecurity>, SBFA.sbfaSecurity.ISBFASecurity {
        
        public SBFASecurityClient() {
        }
        
        public SBFASecurityClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SBFASecurityClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SBFASecurityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SBFASecurityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SBFA.sbfaSecurity.AuthenticationResponse Authenticate(string username, string password) {
            return base.Channel.Authenticate(username, password);
        }
        
        public System.Threading.Tasks.Task<SBFA.sbfaSecurity.AuthenticationResponse> AuthenticateAsync(string username, string password) {
            return base.Channel.AuthenticateAsync(username, password);
        }
        
        public SBFA.sbfaSecurity.PasswordChangeResponse ChangePassword(string username, string oldpassword, string newpassword) {
            return base.Channel.ChangePassword(username, oldpassword, newpassword);
        }
        
        public System.Threading.Tasks.Task<SBFA.sbfaSecurity.PasswordChangeResponse> ChangePasswordAsync(string username, string oldpassword, string newpassword) {
            return base.Channel.ChangePasswordAsync(username, oldpassword, newpassword);
        }
        
        public bool UpdateUserDetails(string userName, string FirstName, string Surname, string EmailAddress, string MobileNumber) {
            return base.Channel.UpdateUserDetails(userName, FirstName, Surname, EmailAddress, MobileNumber);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserDetailsAsync(string userName, string FirstName, string Surname, string EmailAddress, string MobileNumber) {
            return base.Channel.UpdateUserDetailsAsync(userName, FirstName, Surname, EmailAddress, MobileNumber);
        }
    }
}