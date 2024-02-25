using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class AddOrEditNews : System.Web.UI.Page
    {
        int newsId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient catClient = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            var catList = catClient.GetAllCategory();
            if (Request.QueryString["id"] != null)
            {
                newsId = int.Parse(Request.QueryString["id"]);
                NewsServiceRef.NewsServiceClient newsClient = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
                NewsApp.Models.News news = newsClient.GetNews(newsId);
                NTitle.Text = news.Title;
                Source.Text = news.Source;
                Author.Text = news.Author;
                Description.Text = news.Description;
                Url.Text = news.Url;
                UrlToImage.Text = news.UrlToImage;
                Button.Text = "Save";
                Category.Items.Clear();
                foreach (var c in catList)
                {
                    Category.Items.Add(new ListItem() { Text = c.CategoryName, Value = c.Id.ToString(), Selected = news.Category.Id == c.Id });
                }
            }
            else
            {
                foreach (var c in catList)
                {
                    Category.Items.Add(new ListItem() { Text = c.CategoryName, Value = c.Id.ToString() });
                }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient catClient = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            Category selectedCategory = catClient.GetCategory(int.Parse(Category.SelectedValue));
            NewsServiceRef.NewsServiceClient newsClient = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
            if (newsId == 0)
            {
                NewsApp.Models.News news = new NewsApp.Models.News()
                {
                    Title = NTitle.Text,
                    Source = Source.Text,
                    Author = Author.Text,
                    Description = Description.Text,
                    Url = Url.Text,
                    UrlToImage = UrlToImage.Text,
                    Category = selectedCategory
                };
                newsClient.AddNews(news);
            }
            else
            {
                NewsApp.Models.News news = new NewsApp.Models.News()
                {
                    Id = newsId,
                    Title = NTitle.Text,
                    Source = Source.Text,
                    Author = Author.Text,
                    Description = Description.Text,
                    Url = Url.Text,
                    UrlToImage = UrlToImage.Text,
                    Category = selectedCategory
                };
                newsClient.EditNews(news);
            }
            Category.Items.Clear();
            Response.Redirect("NewsList.aspx");
        }
    }
}