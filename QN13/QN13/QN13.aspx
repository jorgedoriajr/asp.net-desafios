<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN13.aspx.cs" Inherits="QN13.QN13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 13</title>
    <link href="QN13.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Information Delete</h1>
        <div class="errMessage-container">
            <span id="errMessage" runat="server"></span>
        </div>
        <form id="form1" runat="server">
            <div class="read">
                <div class="message-container">
                    <h5>Click the 'Retrieve Data' button to view the information about the books.</h5>
                </div>
                <div class="button-container">
                    <asp:Button Text="Retrieve Data" runat="server" ID="btnRetrieve" OnClick="btnRetrieve_Click" />
                </div>
                <div class="message-container">
                    <h5>Here display the data before it was deleted:</h5>
                </div>
                <div class="table-container">
                    <asp:GridView ID="GridViewBeforeDelete" runat="server"></asp:GridView>
                </div>
            </div>
            <div class="delete">
                <div class="message-container">
                    <h5>Enter the old book ID you wish to edit.</h5>
                </div>
                <div class="deletableID-container">
                    <asp:Label Text="Enter Book ID:" runat="server" ID="lblBookID" />
                    <asp:TextBox runat="server" ID="txtBookID" />
                    <span id="errBookID" runat="server"></span>
                </div>
                <div class="message-container">
                    <h5>Click the 'Delete Record' button to update the information about the book.</h5>
                </div>
                <div class="button-container">
                    <asp:Button Text="Delete Record" runat="server" ID="btnDelete" OnClick="btnDelete_Click" />
                </div>
                <div class="message-container">
                    <h5>Here display the data after deleted:</h5>
                </div>
                <div class="table-container">
                    <asp:GridView ID="GridViewAfterDelete" runat="server"></asp:GridView>
                </div>
            </div>
        </form>
    </section>
</body>
</html>
