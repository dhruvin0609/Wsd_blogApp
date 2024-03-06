﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bolgAppClient.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/blogAppLibrary")]
    [System.SerializableAttribute()]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
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
        public int PostId {
            get {
                return this.PostIdField;
            }
            set {
                if ((this.PostIdField.Equals(value) != true)) {
                    this.PostIdField = value;
                    this.RaisePropertyChanged("PostId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.ICommentService")]
    public interface ICommentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/CreateComment", ReplyAction="http://tempuri.org/ICommentService/CreateCommentResponse")]
        void CreateComment(string content, int postId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/CreateComment", ReplyAction="http://tempuri.org/ICommentService/CreateCommentResponse")]
        System.Threading.Tasks.Task CreateCommentAsync(string content, int postId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/GetCommentsByPostId", ReplyAction="http://tempuri.org/ICommentService/GetCommentsByPostIdResponse")]
        bolgAppClient.ServiceReference3.Comment[] GetCommentsByPostId(int postId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/GetCommentsByPostId", ReplyAction="http://tempuri.org/ICommentService/GetCommentsByPostIdResponse")]
        System.Threading.Tasks.Task<bolgAppClient.ServiceReference3.Comment[]> GetCommentsByPostIdAsync(int postId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommentServiceChannel : bolgAppClient.ServiceReference3.ICommentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommentServiceClient : System.ServiceModel.ClientBase<bolgAppClient.ServiceReference3.ICommentService>, bolgAppClient.ServiceReference3.ICommentService {
        
        public CommentServiceClient() {
        }
        
        public CommentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateComment(string content, int postId, int userId) {
            base.Channel.CreateComment(content, postId, userId);
        }
        
        public System.Threading.Tasks.Task CreateCommentAsync(string content, int postId, int userId) {
            return base.Channel.CreateCommentAsync(content, postId, userId);
        }
        
        public bolgAppClient.ServiceReference3.Comment[] GetCommentsByPostId(int postId) {
            return base.Channel.GetCommentsByPostId(postId);
        }
        
        public System.Threading.Tasks.Task<bolgAppClient.ServiceReference3.Comment[]> GetCommentsByPostIdAsync(int postId) {
            return base.Channel.GetCommentsByPostIdAsync(postId);
        }
    }
}
