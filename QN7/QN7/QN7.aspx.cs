using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN7
{
    public partial class QN7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorClear();

            if (Session["username"] != null)
            {
                Response.Redirect("Dashboard.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            errorClear();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int error = 0;

            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                error++;
                errUsername.InnerHtml = "**Enter your username.";
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                error++;
                errPassword.InnerHtml = "**Enter your password.";
            }
            if (error == 0)
            {
                if(username == "admin" &&  password == "admin1234") 
                {
                    Session.Add("username", username);
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    errMessage.InnerHtml = "**Invalid username or password";
                }
            }

        }

        private void errorClear()
        {
            errUsername.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
            errMessage.InnerHtml = String.Empty;
        }
    }
}