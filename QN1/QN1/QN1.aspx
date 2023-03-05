<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN1.aspx.cs" Inherits="QN1.QN1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 1</title>
    <link href="QN1.css" rel="stylesheet" />
</head>
<body>
    <div class="container" runat="server">
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="txtNum1" runat="server" textMode="Number" />
                <span id="errNum1" runat="server"></span>
            </div>
            <div>
                <asp:TextBox ID="txtNum2" runat="server" TextMode="Number" />
                <span id="errNum2" runat="server"></span>
            </div>
            <div>
                <span id="lblResult" runat="server">Enter number and click any button:</span>
            </div>
            <div id="buttons">
                <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click" />
                <asp:Button ID="btnSub" Text="Subtract" runat="server" OnClick="btnSub_Click" />
                <asp:Button ID="btnDiv" Text="Divide" runat="server" OnClick="btnDiv_Click" />
                <asp:Button ID="btnMul" Text="Multiply" runat="server" OnClick="btnMul_Click" />
            </div>
        </form>
    </div>
</body>
</html>
