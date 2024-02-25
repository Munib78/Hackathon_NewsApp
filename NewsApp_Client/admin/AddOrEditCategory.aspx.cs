using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client.admin
{
    public partial class AddOrEditCategory : System.Web.UI.Page
    {
        int categoryId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                categoryId = int.Parse(Request.QueryString["id"]);
                CategoryServiceRef.CategoryServiceClient _client = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
                Category category = _client.GetCategory(categoryId);
                CategoryName.Text = category.CategoryName;
                Button.Text = "Save";
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient _client = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            if (categoryId == 0)
            {
                Category category = new Category()
                {
                    CategoryName = CategoryName.Text
                };
                _client.AddCategory(category);
            }
            else
            {
                Category category = new Category()
                {
                    Id = categoryId,
                    CategoryName = CategoryName.Text
                };
                _client.EditCategory(category);
            }
            Response.Redirect("CategoryList.aspx");
        }
    }
}