using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class NewsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsServiceRef.NewsServiceClient _client = new NewsServiceRef.NewsServiceClient("BasicHttpBinding_INewsService");
            var news = _client.GetAllNews();
            string html = string.Empty;
            int i = 1;
            foreach (var n in news)
            {
                html += $@"<tr>
                                <td scope=""row"">{i}</td>
                                <td>{n.Title}</td>
                                <td>{n.Source}</td>
                                <td>{n.Author}</td>
                                <td>{n.PublishedOn}</td>
                                <td>{n.Category.CategoryName}</td>
                                <td>
                                    <a runat=""server"" href=""/admin/AddOrEditNews.aspx?id={Server.UrlEncode(n.Id.ToString())}"" class=""btn btn-primary btn-sm me-3"">Edit</a>
                                    <a runat=""server"" href=""/admin/DeleteNews.aspx?id={Server.UrlEncode(n.Id.ToString())}"" class=""btn btn-danger btn-sm"">Delete</a>
                                </td>
                           </tr> ";
                i++;
            }
            ListOfNews.Controls.Add(new Literal() { Text = html });
        }
    }
}