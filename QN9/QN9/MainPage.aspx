<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="QN9.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main DashBoard</title>
    <link href="MainPage.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <div class="welcome-container">
            <h1>Welcome to the Dashboard!</h1>
            <p>
                This is complete authentication process.
                <br />
                Finally you login to DashBoard!
            </p>
        </div>
        <div class="error-container">
            <span id="errMessage" runat="server"></span>
        </div>
        <form id="form1" runat="server">
            <div class="form-item-container">
                <asp:Button Text="Logout" runat="server" ID="btnLogout" OnClick="btnLogout_Click" />
            </div>
        </form>
    </section>
</body>
</html>
