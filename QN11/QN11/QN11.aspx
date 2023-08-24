<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN11.aspx.cs" Inherits="QN11.QN11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 11</title>
    <link href="QN11.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Information Reading</h1>
        <div class="errMessage-container">
            <span id="errMessage" runat="server"></span>
        </div>
        <div class="message-container">
            <h5>Click the 'Retrieve Data' button to view the information about the books.</h5>
        </div>
        <form id="form1" runat="server">
            <div class="button-container">
                <asp:Button Text="Retrieve Data" runat="server" ID="btnRetrieve" OnClick="btnRetrieve_Click" />
            </div>
            <div class="table-container">
                <asp:GridView ID="GridView" runat="server"></asp:GridView>
            </div>
        </form>
    </section>
</body>
</html>
