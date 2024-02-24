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
    public interface ICategoryService
    {
        [OperationContract]
        void AddCategory(Category newCategory);

        [OperationContract]
        Category EditCategory(Category category);

        [OperationContract]
        Category GetCategory(int id);

        [OperationContract]
        List<Category> GetAllCategory();

        [OperationContract]
        void DeleteCategory(int id);
    }
}
