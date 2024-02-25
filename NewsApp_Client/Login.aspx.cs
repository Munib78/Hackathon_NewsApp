using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApp_Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            AccountServiceRef.AccountServiceClient client = new AccountServiceRef.AccountServiceClient("BasicHttpBinding_IAccountService");
            string email = Email.Text, password = Password.Text;
            var user = client.Login(email, password);
            if (user != null)
            {
                Session["user"] = user;
                Response.Redirect("~/admin/NewsList.aspx");
            }
            else
            {
                LoginError.Text = "Invalid email or password";
                Session["user"] = null;
            }
        }
    }
}