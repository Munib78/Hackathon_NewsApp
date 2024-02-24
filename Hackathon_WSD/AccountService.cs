using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    public class AccountService : IAccountService
    {
        public User Login(string email, string password)
        {
            AppDbContext db = new AppDbContext();
            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }
    }
}
