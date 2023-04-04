<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN6.aspx.cs" Inherits="QN6.QN6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 6</title>
    <link href="QN6.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Login from DataBase</h1>
        <form id="form1" runat="server">
            <div class="content">
                <asp:Label Text="Email:" runat="server" ID="lblEmail" />
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" />
                <span id="errEmail" runat="server"></span>
            </div>
            <div class="content">
                <asp:Label Text="Password:" runat="server" ID="lblPassword" />
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <span id="errPassword" runat="server"></span>
            </div>
            <div class="content">
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
            </div>
            <div>
                <span id="errDatabase" runat="server"></span>
            </div>
        </form>
    </section>
</body>
</html>
