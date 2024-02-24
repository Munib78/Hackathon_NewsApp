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
    public interface IAccountService
    {
        [OperationContract]
        User Login(string email, string password);
    }
}
