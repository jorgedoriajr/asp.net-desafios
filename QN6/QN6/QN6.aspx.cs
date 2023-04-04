using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace QN6
{
    public partial class QN6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClearErrors();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ClearErrors();

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(email)) 
            {
                error++;
                errEmail.InnerHtml = "**Please Enter Your Email ID.";
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                error++;
                errPassword.InnerHtml = "**Please Enter Your Password.";
            }

            if (error == 0)
            {
                try
                {
                    //Database Connectivety
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    //Sql Query To Record
                    MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM registrations WHERE email = @email AND password = @password", connect);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // Execute the query and check the result
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Successful login
                        Response.Redirect("dashboard.html");
                    }
                    else
                    {
                        // Invalid login
                        errDatabase.InnerHtml = "**Invalid Email or Password.";
                    }

                }
                catch (Exception ex)
                {
                    errDatabase.InnerText = "Error! " + ex.Message;
                }

            }
        }

        private void ClearErrors()
        {
            errEmail.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
        }
    }
}