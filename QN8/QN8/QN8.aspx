<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN8.aspx.cs" Inherits="QN8.QN8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 8</title>
    <link href="QN8.css" rel="stylesheet" />
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
                <asp:CheckBox ID="chkRemember" runat="server" Text="Remember Me" />
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

