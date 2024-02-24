/*using Microsoft.EntityFramework;*/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=NewsApp.Properties.Settings.NewsDB") { }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<User> Users { get; set; }

    }
}
