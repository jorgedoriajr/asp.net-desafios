<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN4.aspx.cs" Inherits="QN4.QN4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 4</title>
    <link href="QN4.css  " rel="stylesheet" />
</head>
<body>
    <div class="container" runat="server">
        <div class="title-container">
            <h1>Student Registration Form </h1>
        </div>
        <form id="form1" runat="server">
            <div class="form-content">
                <asp:Label Text="Name:" runat="server" ID="lblName" />
                <asp:TextBox placeholder="Enter full name" ID="txtName" runat="server" />
                <span id="errName" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Father's Name:" runat="server" ID="lblFatherName" />
                <asp:TextBox ID="txtFatherName" runat="server" />
                <span id="errFatherName" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Mother's Name:" runat="server" ID="lblMotherName" />
                <asp:TextBox ID="txtMotherName" runat="server" />
                <span id="errMotherName" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Phone Number:" runat="server" ID="lblPhoneNo" />
                <asp:TextBox TextMode="Phone" placeholder="017XXXXXXXXXX" ID="txtPhoneNo" runat="server" />
                <span id="errPhoneNo" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Email:" runat="server" ID="lblEmail" />
                <asp:TextBox TextMode="Email" ID="txtEmail" runat="server" />
                <span id="errEmail" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Gender:" runat="server" ID="lblGender" />
                <div class="radioOption">
                    <asp:RadioButton ID="rblMale" runat="server" Text="Male" Value="Male" GroupName="rblGender" />
                    <asp:RadioButton ID="rblFemale" runat="server" Text="Female" Value="Female" GroupName="rblGender" />
                    <asp:RadioButton ID="rblOther" runat="server" Text="Other" Value="Other" GroupName="rblGender" />
                </div>
                <span id="errGender" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Date Of Birth:" runat="server" ID="lblDob" />
                <div class="dateOption">
                    <asp:TextBox ID="txtDay" runat="server" MaxLength="2" Width="30"></asp:TextBox>
                    -
                    <asp:TextBox ID="txtMonth" runat="server" MaxLength="2" Width="30"></asp:TextBox>
                    -
                    <asp:TextBox ID="txtYear" runat="server" MaxLength="4" Width="30"></asp:TextBox>
                    <asp:Label Text="(dd-mm-yy)" runat="server" ID="lblDobRef" />
                </div>
                <span id="errDob" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Address:" runat="server" ID="lblAddress" />
                <asp:TextBox placeholder="Street:-     House:-      Road:-" ID="txtAddress" runat="server" />
                <span id="errAddress" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Blood Group:" runat="server" ID="lblBloodGroup" />
                <asp:DropDownList ID="ddlBloodGroup" runat="server">
                    <asp:ListItem Text="Select" />
                    <asp:ListItem Text="A+" Value="A+" />
                    <asp:ListItem Text="A-" Value="A-" />
                    <asp:ListItem Text="B+" Value="B+" />
                    <asp:ListItem Text="B-" Value="B-" />
                    <asp:ListItem Text="AB+" Value="AB+" />
                    <asp:ListItem Text="AB-" Value="AB-" />
                    <asp:ListItem Text="O+" Value="O+" />
                    <asp:ListItem Text="O-" Value="O-" />
                </asp:DropDownList>
                <span id="errBloodGroup" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Department:" runat="server" ID="lblDepartment" />
                <div class="radioOption">
                    <asp:RadioButton ID="lblCSE" runat="server" Text="CSE" Value="CSE" GroupName="rblDepartment" />
                    <asp:RadioButton ID="lblEEE" runat="server" Text="EEE" Value="EEE" GroupName="rblDepartment" />
                    <asp:RadioButton ID="lblBBA" runat="server" Text="BBA" Value="BBA" GroupName="rblDepartment" />
                </div>
                <span id="errDepartment" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Course:" runat="server" ID="lblCourse" />
                <div class="radioOption">
                    <asp:RadioButton ID="lblC" runat="server" Text="C" Value="C" GroupName="rblCourse" />
                    <asp:RadioButton ID="lblCpp" runat="server" Text="C++" Value="C++" GroupName="rblCourse" />
                    <asp:RadioButton ID="lblJava" runat="server" Text="Java" Value="Java" GroupName="rblCourse" />
                    <asp:RadioButton ID="lblAI" runat="server" Text="AI" Value="AI" GroupName="rblCourse" />
                    <asp:RadioButton ID="lblMachineLearning" runat="server" Text="Machine Learning" Value="ML" GroupName="rblCourse" />
                    <asp:RadioButton ID="lblRobotics" runat="server" Text="Robotics" Value="Robotics" GroupName="rblCourse" />
                </div>
                <span id="errCourse" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Label Text="Photo:" runat="server" ID="lblPhoto" />
                <asp:FileUpload ID="filePhoto" runat="server" />
                <span id="errPhoto" runat="server"></span>
            </div>
            <div class="form-content">
                <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
                <asp:Button Text="Reset" runat="server" ID="btnReset" OnClick="btnReset_Click" />
                <span id="errButton" runat="server"></span>
            </div>
        </form>
    </div>
</body>
</html>
