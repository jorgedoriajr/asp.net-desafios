using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN8
{
    public partial class QN8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorClear();

            if (!IsPostBack)
            {
                // Check if there is a saved username in the cookie
                string savedUsername = RetrieveCookie("Username");

                if (!string.IsNullOrEmpty(savedUsername))
                {
                    // If a username is found, populate the TextBox with the saved value
                    txtUsername.Text = savedUsername;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            errorClear();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int error = 0;
            if (String.IsNullOrWhiteSpace(username))
            {
                error++;
                errUsername.InnerHtml = "**Enter your username.";
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                error++;
                errPassword.InnerHtml = "**Enter your password.";
            }
            if (error == 0)
            {
                if (username == "admin" && password == "admin1234")
                {
                    if (chkRemember.Checked)
                    {
                        CreateCookie("Username", username);
                        Response.Redirect("WelcomePage.aspx");
                    }
                    Response.Redirect("WelcomePage.aspx");
                }
                else
                {
                        errMessage.InnerHtml = "**Incorrect Username or Password!";
                }
            }

        }

        private void CreateCookie(string name, string value)
        {
            HttpCookie cookie = new HttpCookie(name, value);
            cookie.Expires = DateTime.Now.AddHours(1);
            cookie.Secure = true;
            cookie.HttpOnly = true;
            Response.Cookies.Add(cookie);
        }

        private string RetrieveCookie(string name)
        {
            HttpCookie cookie = Request.Cookies[name];
            return cookie?.Value;
        }

        private void DestroyCookie(string name)
        {
            HttpCookie cookie = new HttpCookie(name);
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
        }

        private void errorClear()
        {
            errUsername.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
            errMessage.InnerHtml = String.Empty;
        }
    }
}