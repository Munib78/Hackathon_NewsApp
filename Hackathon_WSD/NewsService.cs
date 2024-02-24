using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    public class NewsService : INewsService
    {
        public void AddNews(News newNews)
        {
            AppDbContext db = new AppDbContext();
            db.Entry(newNews.Category).State = System.Data.Entity.EntityState.Unchanged;
            db.News.Add(newNews);
            db.SaveChanges();
        }

        public void DeleteNews(int id)
        {
            AppDbContext db = new AppDbContext();
            var news = db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
        }

        public News EditNews(News changedNews)
        {
            AppDbContext db = new AppDbContext();
            db.Entry(changedNews).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return changedNews;
        }

        public List<News> GetAllNews()
        {
            AppDbContext db = new AppDbContext();
            return db.News.OrderByDescending(n => n.PublishedOn).Include(n => n.Category).ToList();
        }

        public News GetNews(int id)
        {
            AppDbContext db = new AppDbContext();
            return db.News.Where(n => n.Id == id).Include(n => n.Category).FirstOrDefault();
        }
    }
}
