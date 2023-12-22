<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="QN9.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link href="Register.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <div class="welcome-container">
            <h1>Welcome to the Register Page!</h1>
            <p>
                This is complete authentication process.
                <br />
                Get ready to register your information in database!
            </p>
        </div>

        <div class="error-container">
            <span id="errMessage" runat="server"></span>
        </div>
        <form id="form1" runat="server">
            <div class="form-item-container">
                <asp:Label Text="Name:" runat="server" ID="lblName" />
                <asp:TextBox runat="server" ID="txtName" />
                <span id="errName" runat="server"></span>
            </div>

            <div class="form-item-container">
                <asp:Label Text="Father's Name:" runat="server" ID="lblFatherName" />
                <asp:TextBox runat="server" ID="txtFatherName" />
                <span id="errFatherName" runat="server"></span>
            </div>

            <div class="form-item-container">
                <asp:Label Text="Mother's Name:" runat="server" ID="lblMotherName" />
                <asp:TextBox runat="server" ID="txtMotherName" />
                <span id="errMotherName" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Email:" runat="server" ID="lblEmail" />
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" />
                <span id="errEmail" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Phone No:" runat="server" ID="lblPhone" />
                <asp:TextBox runat="server" ID="txtPhone" TextMode="Phone" />
                <span id="errPhone" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Gender:" runat="server" ID="lblGender" />
                <asp:DropDownList runat="server" ID="ddlGender">
                    <asp:ListItem Text="Select your gender" Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                    <asp:ListItem Text="Other" Value="Other" />
                </asp:DropDownList>
                <span id="errGender" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Address:" runat="server" ID="lblAddress" />
                <asp:TextBox runat="server" ID="txtAddress" />
                <span id="errAddress" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="ID No:" runat="server" ID="lblID" />
                <asp:TextBox runat="server" ID="txtID" />
                <span id="errID" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Password:" runat="server" ID="lblPassword" />
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <span id="errPassword" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Label Text="Confirm Password:" runat="server" ID="lblConfirmPassword" />
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" />
                <span id="errConfirmPassword" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:Button Text="Save" runat="server" ID="btnSave" OnClick="btnSave_Click"/>
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click"/>
            </div>
        </form>
    </section>
</body>
</html>
