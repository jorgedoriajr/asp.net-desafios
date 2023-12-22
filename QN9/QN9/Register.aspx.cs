using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace QN9
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clearValidationErrors();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            clearValidationErrors();

            string name = txtName.Text;
            string fatherName = txtFatherName.Text;
            string motherName = txtMotherName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string gender = ddlGender.SelectedValue;
            string address = txtAddress.Text;
            string userID = txtID.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(name))
            {
                error++;
                errName.InnerHtml = "**Enter your name.";
            }

            if (string.IsNullOrWhiteSpace(fatherName))
            {
                error++;
                errFatherName.InnerHtml = "**Enter your father's name.";
            }

            if (string.IsNullOrWhiteSpace(motherName))
            {
                error++;
                errMotherName.InnerHtml = "**Enter your mother's name.";
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                error++;
                errEmail.InnerHtml = "**Enter your email.";
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                error++;
                errPhone.InnerHtml = "**Enter your phone number.";
            }

            if (string.IsNullOrWhiteSpace(gender) || gender == "Select your gender")
            {
                error++;
                errGender.InnerHtml = "**Select your gender.";
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                error++;
                errAddress.InnerHtml = "**Enter your address.";
            }

            if (string.IsNullOrWhiteSpace(userID))
            {
                error++;
                errID.InnerHtml = "**Enter your ID.";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                error++;
                errPassword.InnerHtml = "**Enter your password.";
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                error++;
                errConfirmPassword.InnerHtml = "**Confirm your password.";
            }
            else if (password != confirmPassword)
            {
                error++;
                errConfirmPassword.InnerHtml = "**Passwords do not match.";
            }

            if (error == 0)
            {
                try
                {
                    //Database Connectivety
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    //Sql Query To Record
                    MySqlCommand command = new MySqlCommand("INSERT INTO qn9_data(Name, FatherName, MotherName, Email, Phone, Gender, Address, UserID, Password)\r\n VALUES (@name, @fatherName, @motherName, @email, @phone, @gender, @address, @uID, @password)", connect);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@fatherName", fatherName);
                    command.Parameters.AddWithValue("@motherName", motherName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@uID", userID);
                    command.Parameters.AddWithValue("@password", password);

                    //execute query
                    command.ExecuteNonQuery();
                    errMessage.InnerText = "Database Connection and Data Registered Successfully!";

                }
                catch (Exception ex)
                {
                    errMessage.InnerText = "Error! **" + ex.Message;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        private void clearValidationErrors()
        {
            errName.InnerHtml = String.Empty;
            errFatherName.InnerHtml = String.Empty;
            errMotherName.InnerHtml = String.Empty;
            errEmail.InnerHtml = String.Empty;
            errPhone.InnerHtml = String.Empty;
            errGender.InnerHtml = String.Empty;
            errAddress.InnerHtml = String.Empty;
            errID.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
            errConfirmPassword.InnerHtml = String.Empty;
            errMessage.InnerText = String.Empty;
        }
    }
}
