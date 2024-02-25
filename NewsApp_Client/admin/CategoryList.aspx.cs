using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient _client = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            var categories = _client.GetAllCategory();
            string html = string.Empty;
            int i = 1;
            foreach (var category in categories)
            {
                html += $@"<tr>
                                <td scope=""row"">{i}</td>
                                <td>{category.CategoryName}</td>
                                <td>
                                    <a runat=""server"" href=""/admin/AddOrEditCategory.aspx?id={Server.UrlEncode(category.Id.ToString())}"" class=""btn btn-primary btn-sm me-3"">Edit</a>
                                    <a runat=""server"" href=""/admin/DeleteCategory.aspx?id={Server.UrlEncode(category.Id.ToString())}"" class=""btn btn-danger btn-sm"">Delete</a>
                                </td>
                           </tr> ";
                i++;
            }
            ListOfCategoeies.Controls.Add(new Literal() { Text = html });
        }
    }
}