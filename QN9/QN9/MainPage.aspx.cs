using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN9
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("Login.aspx?msg=1");
            }
            errMessage.InnerText = "Welcome User: " + Session["userID"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //removing the cookie
            HttpCookie cookie = Request.Cookies["userID"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Session.Clear();
            Response.Redirect("Login.aspx?msg=2");
        }
    }
}