﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bolgAppClient.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/blogAppLibrary")]
    [System.SerializableAttribute()]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IPostService")]
    public interface IPostService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/CreatePost", ReplyAction="http://tempuri.org/IPostService/CreatePostResponse")]
        void CreatePost(string title, string content, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/CreatePost", ReplyAction="http://tempuri.org/IPostService/CreatePostResponse")]
        System.Threading.Tasks.Task CreatePostAsync(string title, string content, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/UpdatePost", ReplyAction="http://tempuri.org/IPostService/UpdatePostResponse")]
        void UpdatePost(int postId, string title, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/UpdatePost", ReplyAction="http://tempuri.org/IPostService/UpdatePostResponse")]
        System.Threading.Tasks.Task UpdatePostAsync(int postId, string title, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetAllPosts", ReplyAction="http://tempuri.org/IPostService/GetAllPostsResponse")]
        bolgAppClient.ServiceReference2.Post[] GetAllPosts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetAllPosts", ReplyAction="http://tempuri.org/IPostService/GetAllPostsResponse")]
        System.Threading.Tasks.Task<bolgAppClient.ServiceReference2.Post[]> GetAllPostsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetPostsByUserId", ReplyAction="http://tempuri.org/IPostService/GetPostsByUserIdResponse")]
        bolgAppClient.ServiceReference2.Post[] GetPostsByUserId(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetPostsByUserId", ReplyAction="http://tempuri.org/IPostService/GetPostsByUserIdResponse")]
        System.Threading.Tasks.Task<bolgAppClient.ServiceReference2.Post[]> GetPostsByUserIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/DeletePost", ReplyAction="http://tempuri.org/IPostService/DeletePostResponse")]
        void DeletePost(int postId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/DeletePost", ReplyAction="http://tempuri.org/IPostService/DeletePostResponse")]
        System.Threading.Tasks.Task DeletePostAsync(int postId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPostServiceChannel : bolgAppClient.ServiceReference2.IPostService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostServiceClient : System.ServiceModel.ClientBase<bolgAppClient.ServiceReference2.IPostService>, bolgAppClient.ServiceReference2.IPostService {
        
        public PostServiceClient() {
        }
        
        public PostServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreatePost(string title, string content, int userId) {
            base.Channel.CreatePost(title, content, userId);
        }
        
        public System.Threading.Tasks.Task CreatePostAsync(string title, string content, int userId) {
            return base.Channel.CreatePostAsync(title, content, userId);
        }
        
        public void UpdatePost(int postId, string title, string content) {
            base.Channel.UpdatePost(postId, title, content);
        }
        
        public System.Threading.Tasks.Task UpdatePostAsync(int postId, string title, string content) {
            return base.Channel.UpdatePostAsync(postId, title, content);
        }
        
        public bolgAppClient.ServiceReference2.Post[] GetAllPosts() {
            return base.Channel.GetAllPosts();
        }
        
        public System.Threading.Tasks.Task<bolgAppClient.ServiceReference2.Post[]> GetAllPostsAsync() {
            return base.Channel.GetAllPostsAsync();
        }
        
        public bolgAppClient.ServiceReference2.Post[] GetPostsByUserId(int userId) {
            return base.Channel.GetPostsByUserId(userId);
        }
        
        public System.Threading.Tasks.Task<bolgAppClient.ServiceReference2.Post[]> GetPostsByUserIdAsync(int userId) {
            return base.Channel.GetPostsByUserIdAsync(userId);
        }
        
        public void DeletePost(int postId) {
            base.Channel.DeletePost(postId);
        }
        
        public System.Threading.Tasks.Task DeletePostAsync(int postId) {
            return base.Channel.DeletePostAsync(postId);
        }
    }
}