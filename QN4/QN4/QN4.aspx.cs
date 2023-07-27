using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN4
{
    public partial class QN4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errName.InnerHtml = string.Empty;
            errFatherName.InnerHtml = string.Empty;
            errMotherName.InnerHtml = string.Empty;
            errPhoneNo.InnerHtml = string.Empty;
            errEmail.InnerHtml = string.Empty;
            errGender.InnerHtml = string.Empty;
            errDob.InnerHtml = string.Empty;
            errAddress.InnerHtml = string.Empty;
            errBloodGroup.InnerHtml = string.Empty;
            errDepartment.InnerHtml = string.Empty;
            errCourse.InnerHtml = string.Empty;
            errPhoto.InnerHtml = string.Empty;
            errButton.InnerHtml = string.Empty;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string fname = txtFatherName.Text;
            string mname = txtMotherName.Text;
            string phone = txtPhoneNo.Text;
            string email = txtEmail.Text;
            string gender;
            if (rblMale.Checked)
            {
                gender = rblMale.Text;
            }
            else if (rblFemale.Checked)
            {
                gender = rblFemale.Text;
            }
            else if (rblOther.Checked)
            {
                gender = rblOther.Text;
            }
            else
            {
                gender = string.Empty;
            }
            string day = txtDay.Text;
            string month = txtMonth.Text;
            string year = txtYear.Text;
            string address = txtAddress.Text;
            string bloodGroup = ddlBloodGroup.SelectedValue;
            string SelectedDepartment;
            if (lblCSE.Checked)
            {
                SelectedDepartment = lblCSE.Text;
            }
            else if (lblEEE.Checked)
            {
                SelectedDepartment = lblEEE.Text;
            }
            else if (lblBBA.Checked)
            {
                SelectedDepartment = lblBBA.Text;
            }
            else
            {
                SelectedDepartment = string.Empty;
            }

            string SelectedCourse;
            if (lblC.Checked)
            {
                SelectedCourse = lblC.Text;
            }
            else if (lblCpp.Checked)
            {
                SelectedCourse = lblCpp.Text;
            }
            else if (lblJava.Checked)
            {
                SelectedCourse = lblJava.Text;
            }
            else if (lblAI.Checked)
            {
                SelectedCourse = lblAI.Text;
            }
            else if (lblMachineLearning.Checked)
            {
                SelectedCourse = lblMachineLearning.Text;
            }
            else if (lblRobotics.Checked)
            {
                SelectedCourse = lblRobotics.Text;
            }
            else
            {
                SelectedCourse = string.Empty;
            }

            int error = 0;

            if (string.IsNullOrWhiteSpace(name))
            {
                error++;
                errName.InnerHtml = "**Enter your Name";
            }
            if (string.IsNullOrWhiteSpace(fname))
            {
                error++;
                errFatherName.InnerHtml = "**Enter your father Name.";
            }
            if (string.IsNullOrWhiteSpace(mname))
            {
                error++;
                errMotherName.InnerHtml = "**Enter your mother Name.";
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                error++;
                errPhoneNo.InnerHtml = "**Enter your phone number.";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                error++;
                errEmail.InnerHtml = "**Enter your email address";
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                error++;
                errGender.InnerHtml = "**Select your gender.";
            }
            if (true)
            {
                if (string.IsNullOrWhiteSpace(day))
                {
                    error++;
                    errDob.InnerHtml = "**Fill-up 3 field properly.";
                }
                if (string.IsNullOrWhiteSpace(month))
                {
                    error++;
                    errDob.InnerHtml = "**Fill-up 3 field properly.";
                }
                if (string.IsNullOrWhiteSpace(year))
                {
                    error++;
                    errDob.InnerHtml = "**Fill-up 3 field properly.";
                }

            }
            if (string.IsNullOrWhiteSpace(address))
            {
                error++;
                errAddress.InnerHtml = "**Enter your address.";
            }
            if (string.IsNullOrWhiteSpace(bloodGroup))
            {
                error++;
                errBloodGroup.InnerText = "**Select your blood group.";
            }
            if (string.IsNullOrWhiteSpace(SelectedDepartment))
            {
                error++;
                errDepartment.InnerHtml = "**Select your Depertment.";
            }
            if (string.IsNullOrWhiteSpace(SelectedCourse))
            {
                error++;
                errCourse.InnerHtml = "**Select your Course.";
            }

            if (!filePhoto.HasFile)
            {
                error++;
                errPhoto.InnerText = "**Please select a photo.";
            }
            if (error == 0)
            {
                errButton.InnerHtml = "**Good Job!";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtMotherName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rblMale.Checked = false;
            rblFemale.Checked = false;
            rblOther.Checked = false;
            txtDay.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtAddress.Text = string.Empty;
            ddlBloodGroup.SelectedIndex = 0;
            lblCSE.Checked = false;
            lblEEE.Checked = false;
            lblBBA.Checked = false;
            lblC.Checked = false;
            lblCpp.Checked = false;
            lblJava.Checked = false;
            lblAI.Checked = false;
            lblMachineLearning.Checked = false;
            lblRobotics.Checked = false;
            filePhoto.Attributes.Clear();

            errButton.InnerHtml = "**Clear Successfully!";
        }
    }
}