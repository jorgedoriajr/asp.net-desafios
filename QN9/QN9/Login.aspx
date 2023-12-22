<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QN9.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="Login.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <div class="welcome-container">
            <h1>Welcome to the Login Page!</h1>
            <p>
                This is complete authentication process.
            <br />
                Get ready to login and Access of Dashboard!
            </p>
        </div>

        <div class="error-container">
            <span id="errLoginMessage" runat="server"></span>
        </div>
        <form id="form1" runat="server">
            <div class="form-item-container">
                <asp:Label Text="Your ID:" runat="server" ID="lblID" />
                <asp:TextBox runat="server" ID="txtID" />
                <span id="errID" runat="server"></span>
            </div>

            <div class="form-item-container">
                <asp:Label Text="Password:" runat="server" ID="lblPassword" />
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <span id="errPassword" runat="server"></span>
            </div>
            <div class="form-item-container">
                <asp:CheckBox Text="Remember Me" runat="server" ID="chkRemember" />
                <span id="errRemember" runat="server" ></span>
            </div>
            <div class="form-item-container">
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
                <asp:Button Text="Register" runat="server" ID="btnRegister" OnClick="btnRegister_Click" />
            </div>
        </form>
        <div class="error-container">
            <span id="errMessage" runat="server"></span>
        </div>
    </section>
</body>
</html>
