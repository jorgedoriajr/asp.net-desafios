using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace QN5
{
    public partial class QN5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Clear error messages on page load
            ClearErrorMessages();
        }

        protected void btnStoreRecord_Click(object sender, EventArgs e)
        {
            // Clear error messages before validating
            ClearErrorMessages();

            // Retrieve user input
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string gender = GetSelectedGender();
            string faculty = ddlFaculty.SelectedValue;

            int error = 0;

            // Validate user input
            if (string.IsNullOrWhiteSpace(name))
            {
                error++;
                errName.InnerHtml = "**Enter your Name.";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                error++;
                errEmail.InnerHtml = "**Enter your email address.";
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                error++;
                errPassword.InnerHtml = "**Enter a password.";
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                error++;
                errPhone.InnerHtml = "**Enter your Phone Number.";
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                error++;
                errGender.InnerHtml = "**Choose your Gender.";
            }
            if (string.IsNullOrWhiteSpace(faculty))
            {
                error++;
                errFaculty.InnerHtml = "**Select your Faculty.";
            }

            if(error == 0)
            {
                try
                {
                    //Database Connectivety
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    //Sql Query To Record
                    MySqlCommand command = new MySqlCommand("INSERT INTO registrations (Name, Email, Password, Phone, Gender, Faculty)\r\nVALUES (@name, @email, @password, @phone, @gender, @faculty)", connect);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@faculty", faculty);

                    //execute query
                    command.ExecuteNonQuery();
                    errDataBase.InnerText = "Database Connection and Register Successfully";

                }
                catch (Exception ex)
                {
                    errDataBase.InnerText = "Error! **" + ex.Message;
                }
            }

        }

        private void ClearErrorMessages()
        {
            errName.InnerHtml = String.Empty;
            errEmail.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
            errPhone.InnerHtml = String.Empty;
            errGender.InnerHtml = String.Empty;
            errFaculty.InnerHtml = String.Empty;
        }

        private string GetSelectedGender()
        {
            if (rblFemale.Checked)
            {
                return rblFemale.Text;
            }
            else if (rblMale.Checked)
            {
                return rblMale.Text;
            }
            else if (rblOther.Checked)
            {
                return rblOther.Text;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
