using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    public class CategoryService : ICategoryService
    {
        public void AddCategory(Category newCategory)
        {
            AppDbContext db = new AppDbContext();
            db.Categories.Add(newCategory);
            db.SaveChanges();
        }

        public void DeleteCategory(int id)
        {

            AppDbContext db = new AppDbContext();
            var category = db.Categories.Find(id);

            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        public Category EditCategory(Category changedCategory)
        {
            AppDbContext db = new AppDbContext();
            Category cat = db.Categories.Where(c => c.Id == changedCategory.Id).FirstOrDefault();
            cat.CategoryName = changedCategory.CategoryName;
            db.SaveChanges();
            return cat;
        }

        public List<Category> GetAllCategory()
        {
            AppDbContext db = new AppDbContext();
            return db.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            AppDbContext db = new AppDbContext();
            return db.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
