<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN12.aspx.cs" Inherits="QN12.QN12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 12</title>
    <link href="QN12.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Information Update</h1>
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
                    <h5>Here display the data before it was updated.</h5>
                </div>
                <div class="table-container">
                    <asp:GridView ID="GridViewBeforeUpdate" runat="server"></asp:GridView>
                </div>
            </div>
            <div class="update">
                <div class="message-container">
                    <h5>Enter the old book ID you wish to edit.</h5>
                </div>
                <div class="editableID-container">
                    <asp:Label Text="Enter Book ID:" runat="server" ID="lblBookID" />
                    <asp:TextBox runat="server" ID="txtBookID" />
                    <span id="errBookID" runat="server"></span>
                </div>
                <div class="message-container">
                    <h5>Please fill out this form to update the data.</h5>
                </div>
                <div>
                    <asp:Label Text="New Book ID:" runat="server" ID="lblNewID" />
                    <asp:TextBox runat="server" ID="txtNewID" />
                    <span id="errNewID" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Book Title:" runat="server" ID="lblTitle" />
                    <asp:TextBox runat="server" ID="txtTitle" />
                    <span id="errTitle" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Publisher:" runat="server" ID="lblPublisher" />
                    <asp:TextBox runat="server" ID="txtPublisher" />
                    <span id="errPublisher" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Author:" runat="server" ID="lblAuthor" />
                    <asp:TextBox runat="server" ID="txtAuthor" />
                    <span id="errAuthor" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Edition:" runat="server" ID="lblEdition" />
                    <asp:TextBox runat="server" ID="txtEdition" />
                    <span id="errEdition" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="No of Pages:" runat="server" ID="lblPages" />
                    <asp:TextBox runat="server" ID="txtPages" TextMode="Number" />
                    <span id="errPages" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Price:" runat="server" ID="lblPrice" />
                    <asp:TextBox runat="server" ID="txtPrice" TextMode="Number" />
                    <span id="errPrice" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="Publish Date:" runat="server" ID="lblPublishDate" />
                    <asp:TextBox runat="server" ID="txtPublishDate" TextMode="Date" />
                    <span id="errPublishDate" runat="server"></span>
                </div>
                <div>
                    <asp:Label Text="ISBN No:" runat="server" ID="lblISBN" />
                    <asp:TextBox runat="server" ID="txtISBN" />
                    <span id="errISBN" runat="server"></span>
                </div>
                <div class="message-container">
                    <h5>Click the 'Update Data' button to update the information about the book.</h5>
                </div>
                <div class="button-container">
                    <asp:Button Text="Update Data" runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" />
                </div>
                <div class="message-container">
                    <h5>Here display the data after updated.</h5>
                </div>
                <div class="table-container">
                    <asp:GridView ID="GridViewAfterUpdate" runat="server"></asp:GridView>
                </div>
            </div>
        </form>
    </section>
</body>
</html>
