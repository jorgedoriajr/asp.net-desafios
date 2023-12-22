<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN9.aspx.cs" Inherits="QN9.QN9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 9</title>
    <link href="QN9.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <div class="welcome-container">
            <h1>Welcome to the Dashboard!</h1>
            <p>This is complete authentication process. Get ready to explore!</p>
        </div>
        <form id="form1" runat="server">
            <div class="form-item-container">
                <asp:Button Text="Register" runat="server" ID="btnRegister" OnClick="btnRegister_Click" />
            </div>
            <hr class="line" />
            <div class="form-item-container">
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
            </div>
        </form>
    </section>
</body>
</html>