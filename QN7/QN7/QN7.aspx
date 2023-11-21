<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN7.aspx.cs" Inherits="QN7.QN7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 7</title>
    <link href="QN7.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Login Form</h1>
        <form id="form1" runat="server">
            <div class="contents">
                <asp:Label Text="Username:" runat="server" ID="lblUsername" />
                <asp:TextBox runat="server" ID="txtUsername" />
                <span id="errUsername" runat="server"></span>
            </div>
            <div class="contents">
                <asp:Label Text="Password:" runat="server" ID="lblPassword" />
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <span id="errPassword" runat="server"></span>
            </div>
            <div class="contents">
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
            </div>
            <div class="contents">
                <span id="errMessage" runat="server"></span>
            </div>
        </form>
    </section>
</body>
</html>
