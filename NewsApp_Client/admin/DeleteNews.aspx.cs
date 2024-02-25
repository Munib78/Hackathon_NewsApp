using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class DeleteNews : System.Web.UI.Page
    {
        int newsId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsServiceRef.NewsServiceClient _client = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
            if (Request.QueryString["id"] != null)
            {
                newsId = int.Parse(Request.QueryString["id"]);
                var news = _client.GetNews(newsId);
                ConfirmMsg.Text = $@"News ""{news.Title} - {news.Category.CategoryName}"" will be deleted.";
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            NewsServiceRef.NewsServiceClient _client = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
            _client.DeleteNews(newsId);
            Response.Redirect("NewsList.aspx");
        }
    }
}