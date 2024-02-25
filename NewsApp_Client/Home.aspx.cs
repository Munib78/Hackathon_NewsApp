using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient catClient = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            var catList = catClient.GetAllCategory();
            string html = "";
            foreach (var cat in catList)
            {
                html += $@"<a href=""News.aspx?category={cat.CategoryName}"" class=""me-4 text-dark text-decoration-none"">{cat.CategoryName}</a>";
            }

            AllCategories.Controls.Add(new Literal() { Text = html });

            NewsServiceRef.NewsServiceClient newsClient = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
            var newsList = newsClient.GetAllNews();
            html = "";
            foreach (var news in newsList)
            {
                html += $@"<div class=""card my-3"">
                                        <div class=""row"">
                                            <div class=""col-md-4"">
                                                <img src=""{news.UrlToImage}"" class=""card-img-top"" width=""100%"" height=""100%"" alt=""...""/>
                                            </div>
                                            <div class=""col-md-8"">
                                                <div class=""card-body"">
                                                    <h5 class=""card-title"">{news.Title}</h5>
                                                    <span class=""badge bg-info mb-2"">{news.Category.CategoryName}</span>
                                                    <p class=""card-text"">{news.Description}</p>
                                                    <p class=""card-text d-flex flex-column"">
                                                        <small class=""text-muted""> By {news.Author}</small>
                                                        <small class=""text-muted""> On {news.PublishedOn.ToLongDateString()} {news.PublishedOn.ToLongTimeString()}</small>
                                                    </p>
                                                    <a href=""{news.Url}"" target=""_blank"" class=""btn btn-sm btn-dark""> Read More </a>
                                                </div>
                                            </div>
                                        </div>
                                      </div>";
            }
            AllNews.Controls.Add(new Literal() { Text = html });
        }
    }
}