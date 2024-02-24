using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    [ServiceContract]
    public interface INewsService
    {
        [OperationContract]
        void AddNews(News newNews);

        [OperationContract]
        List<News> GetAllNews();

        [OperationContract]
        News EditNews(News changedNews);

        [OperationContract]
        void DeleteNews(int id);

        [OperationContract]
        News GetNews(int id);
    }
}
