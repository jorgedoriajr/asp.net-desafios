<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN10.aspx.cs" Inherits="QN10.QN10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 10</title>
    <link href="QN10.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <h1>Book Record Creation</h1>
        <div class="error-container">
            <span id="errMessage" runat="server"></span>
        </div>
        <form id="form1" runat="server">
            <div>
                <asp:Label Text="Book ID:" runat="server" ID="lblBookID" />
                <asp:TextBox runat="server" ID="txtBookID" />
                <span id="errBookID" runat="server"></span>
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
            <div class="button-container">
                <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
            </div>
        </form>

    </section>
</body>
</html>
