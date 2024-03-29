﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.CategoryServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/NewsApp.Models")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryServiceRef.ICategoryService")]
    public interface ICategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        void AddCategory(WindowsFormsApp1.CategoryServiceRef.Category newCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        System.Threading.Tasks.Task AddCategoryAsync(WindowsFormsApp1.CategoryServiceRef.Category newCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/EditCategory", ReplyAction="http://tempuri.org/ICategoryService/EditCategoryResponse")]
        WindowsFormsApp1.CategoryServiceRef.Category EditCategory(WindowsFormsApp1.CategoryServiceRef.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/EditCategory", ReplyAction="http://tempuri.org/ICategoryService/EditCategoryResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category> EditCategoryAsync(WindowsFormsApp1.CategoryServiceRef.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategory", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryResponse")]
        WindowsFormsApp1.CategoryServiceRef.Category GetCategory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategory", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category> GetCategoryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategory", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoryResponse")]
        WindowsFormsApp1.CategoryServiceRef.Category[] GetAllCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategory", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoryResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category[]> GetAllCategoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DeleteCategory", ReplyAction="http://tempuri.org/ICategoryService/DeleteCategoryResponse")]
        void DeleteCategory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DeleteCategory", ReplyAction="http://tempuri.org/ICategoryService/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryServiceChannel : WindowsFormsApp1.CategoryServiceRef.ICategoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp1.CategoryServiceRef.ICategoryService>, WindowsFormsApp1.CategoryServiceRef.ICategoryService {
        
        public CategoryServiceClient() {
        }
        
        public CategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCategory(WindowsFormsApp1.CategoryServiceRef.Category newCategory) {
            base.Channel.AddCategory(newCategory);
        }
        
        public System.Threading.Tasks.Task AddCategoryAsync(WindowsFormsApp1.CategoryServiceRef.Category newCategory) {
            return base.Channel.AddCategoryAsync(newCategory);
        }
        
        public WindowsFormsApp1.CategoryServiceRef.Category EditCategory(WindowsFormsApp1.CategoryServiceRef.Category category) {
            return base.Channel.EditCategory(category);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category> EditCategoryAsync(WindowsFormsApp1.CategoryServiceRef.Category category) {
            return base.Channel.EditCategoryAsync(category);
        }
        
        public WindowsFormsApp1.CategoryServiceRef.Category GetCategory(int id) {
            return base.Channel.GetCategory(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category> GetCategoryAsync(int id) {
            return base.Channel.GetCategoryAsync(id);
        }
        
        public WindowsFormsApp1.CategoryServiceRef.Category[] GetAllCategory() {
            return base.Channel.GetAllCategory();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.CategoryServiceRef.Category[]> GetAllCategoryAsync() {
            return base.Channel.GetAllCategoryAsync();
        }
        
        public void DeleteCategory(int id) {
            base.Channel.DeleteCategory(id);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(int id) {
            return base.Channel.DeleteCategoryAsync(id);
        }
    }
}
