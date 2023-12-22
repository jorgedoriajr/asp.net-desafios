using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN9
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //accessing the cookie
            HttpCookie cookie = Request.Cookies["userID"];
            if(cookie != null)
            {
                Session.Add("userID", cookie.Value);
                Response.Redirect("MainPage.aspx");
            }

            if (Request.QueryString["msg"] != null)
            {
                if (Request.QueryString["msg"].ToString() == "1")
                {
                    errLoginMessage.InnerText = "**Please login to access DashBoard.";
                }
                if (Request.QueryString["msg"].ToString() == "2")
                {
                    errLoginMessage.InnerText = "**Thanks for visiting the DashBoard. Logout successfully...";
                }
            }
            clearValidationErrors();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            clearValidationErrors();

            string userID = txtID.Text;
            string password = txtPassword.Text;

            int error = 0;
            if(string.IsNullOrEmpty(userID) )
            {
                error++;
                errID.InnerHtml = "**Enter your registered ID.";
            }
            if(string.IsNullOrEmpty(password) )
            {
                error++;
                errPassword.InnerHtml = "**Enter your registered Password.";
            }
            if (!chkRemember.Checked)
            {
                error++;
                errRemember.InnerHtml = "**Check the 'Remember Me' button to remember your login.";
            }

            if (error == 0)
            {
                try
                {
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    {
                        connect.Open();

                        MySqlCommand command = new MySqlCommand("SELECT * FROM qn9_data WHERE UserID = @userID AND Password = @password", connect);
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            //creating the cookie
                            if (chkRemember.Checked)
                            {
                                HttpCookie cookie = new HttpCookie("userID");
                                cookie.Value = userID;
                                cookie.Expires = DateTime.Now.AddDays(1);
                                Response.Cookies.Add(cookie);
                            }

                            Session.Add("@userID", userID);
                            Response.Redirect("MainPage.aspx");
                        }
                        else
                        {
                            errMessage.InnerText = "**Invalid ID or Password.";
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    errMessage.InnerText = "Error! **" + ex.Message;
                }
            }
        }

        private void clearValidationErrors()
        {
            errID.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
            errRemember.InnerHtml = String.Empty;
            errMessage.InnerText = String.Empty;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}