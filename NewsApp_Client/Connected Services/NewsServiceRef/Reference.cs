﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsApp_Client.NewsServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsServiceRef.INewsService")]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/AddNews", ReplyAction="http://tempuri.org/INewsService/AddNewsResponse")]
        void AddNews(NewsApp.Models.News newNews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/AddNews", ReplyAction="http://tempuri.org/INewsService/AddNewsResponse")]
        System.Threading.Tasks.Task AddNewsAsync(NewsApp.Models.News newNews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetAllNews", ReplyAction="http://tempuri.org/INewsService/GetAllNewsResponse")]
        NewsApp.Models.News[] GetAllNews();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetAllNews", ReplyAction="http://tempuri.org/INewsService/GetAllNewsResponse")]
        System.Threading.Tasks.Task<NewsApp.Models.News[]> GetAllNewsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/EditNews", ReplyAction="http://tempuri.org/INewsService/EditNewsResponse")]
        NewsApp.Models.News EditNews(NewsApp.Models.News changedNews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/EditNews", ReplyAction="http://tempuri.org/INewsService/EditNewsResponse")]
        System.Threading.Tasks.Task<NewsApp.Models.News> EditNewsAsync(NewsApp.Models.News changedNews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/DeleteNews", ReplyAction="http://tempuri.org/INewsService/DeleteNewsResponse")]
        void DeleteNews(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/DeleteNews", ReplyAction="http://tempuri.org/INewsService/DeleteNewsResponse")]
        System.Threading.Tasks.Task DeleteNewsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNews", ReplyAction="http://tempuri.org/INewsService/GetNewsResponse")]
        NewsApp.Models.News GetNews(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNews", ReplyAction="http://tempuri.org/INewsService/GetNewsResponse")]
        System.Threading.Tasks.Task<NewsApp.Models.News> GetNewsAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : NewsApp_Client.NewsServiceRef.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<NewsApp_Client.NewsServiceRef.INewsService>, NewsApp_Client.NewsServiceRef.INewsService {
        
        public NewsServiceClient() {
        }
        
        public NewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddNews(NewsApp.Models.News newNews) {
            base.Channel.AddNews(newNews);
        }
        
        public System.Threading.Tasks.Task AddNewsAsync(NewsApp.Models.News newNews) {
            return base.Channel.AddNewsAsync(newNews);
        }
        
        public NewsApp.Models.News[] GetAllNews() {
            return base.Channel.GetAllNews();
        }
        
        public System.Threading.Tasks.Task<NewsApp.Models.News[]> GetAllNewsAsync() {
            return base.Channel.GetAllNewsAsync();
        }
        
        public NewsApp.Models.News EditNews(NewsApp.Models.News changedNews) {
            return base.Channel.EditNews(changedNews);
        }
        
        public System.Threading.Tasks.Task<NewsApp.Models.News> EditNewsAsync(NewsApp.Models.News changedNews) {
            return base.Channel.EditNewsAsync(changedNews);
        }
        
        public void DeleteNews(int id) {
            base.Channel.DeleteNews(id);
        }
        
        public System.Threading.Tasks.Task DeleteNewsAsync(int id) {
            return base.Channel.DeleteNewsAsync(id);
        }
        
        public NewsApp.Models.News GetNews(int id) {
            return base.Channel.GetNews(id);
        }
        
        public System.Threading.Tasks.Task<NewsApp.Models.News> GetNewsAsync(int id) {
            return base.Channel.GetNewsAsync(id);
        }
    }
}
