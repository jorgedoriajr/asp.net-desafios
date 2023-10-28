<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="QN8.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>
    <style>
        div{
            margin: auto;
            text-align: center;
            padding: 20px;
        }
        h1{
            color: red;
            margin: 10px;
        }
        p{
            font-size: 25px;
            color: green;
            margin: 10px;
        }
        #btnLogout{
            height: 30px;
            width: 100px;
            margin: 10px;
            font-size: 20px;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to the Application!</h1>
            <p>Hello, Admin</p>
            <asp:Button runat="server" Text="Logout" ID="btnLogout" OnClick="btnLogout_Click"/>
        </div>
    </form>
</body>
</html>
