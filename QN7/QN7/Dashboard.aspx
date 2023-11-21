<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="QN7.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DashBoard Demo</title>
    <style>
        section{
            margin: auto;
            text-align: center;
            padding: 20px;
        }
        h1{
            color: red;
            margin: 10px;
        }
        div{
            margin: 30px;
        }
        input[type="submit"]{
            height: 30px;
            width: 100px;
            background-color: blueviolet;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            color: #ffd800;
            font-size: 20px;
        }
    </style>
</head>
<body>
    <section>
        <h1>Welcom To DashBoard!</h1>
        <span id="lblWelcome" runat="server"></span>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="LogOut" runat="server" ID="btnLogout" OnClick="btnLogout_Click" />
        </div>
    </form>
    
    </section>
</body>
</html>
