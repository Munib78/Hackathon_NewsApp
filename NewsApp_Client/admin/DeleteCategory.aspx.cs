using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class DeleteCategory : System.Web.UI.Page
    {
        int categoeyId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient _client = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            if (Request.QueryString["id"] != null)
            {
                categoeyId = int.Parse(Request.QueryString["id"]);
                var category = _client.GetCategory(categoeyId);
                ConfirmMsg.Text = $@"Category ""{category.CategoryName}"" will be deleted.";
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient _client = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            _client.DeleteCategory(categoeyId);
            Response.Redirect("CategoryList.aspx");
        }
    }
}