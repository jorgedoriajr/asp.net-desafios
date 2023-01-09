<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN2.aspx.cs" Inherits="QN2.QN2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 2</title>
    <link href="QN2.css" rel="stylesheet" />
</head>
<body>
    <div class="container" runat="server">
        <h1 runat="server">Simple Interest</h1>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lblPrincipal" Text="Principal" runat="server" />
                <span runat="server" id="errPrincipal"></span>
                <asp:TextBox ID="txtPrincipal" runat="server" TextMode="Number" />
            </div>
            <div>
                <asp:Label ID="lblInterest" Text="Rate of Interest" runat="server" />
                <span runat="server" id="errInterest"></span>
                <asp:TextBox ID="txtInterest" runat="server" TextMode="Number" />
            </div>
            <div>
                <asp:Label ID="lblTime" Text="Time" runat="server" />
                <span runat="server" id="errTime"></span>
                <asp:TextBox ID="txtTime" runat="server" TextMode="Number" />
            </div>
            <div>
                <asp:Label ID="lblInterestAmount" Text="Interest Amount:" runat="server" />
                <span id="lblInterestAmountTotal" runat="server"></span>
            </div>
            <div>
                <asp:Label ID="lblTotalPlusInterest" Text="Total Plus Interest:" runat="server" />
                <span id="lbllTotalPlusInterestTotal" runat="server"></span>
            </div>
            <div>
                <asp:Button Text="Calculate" runat="server" ID="btnCalculate" OnClick="btnCalculate_Click" />
            </div>
        </form>
    </div>
</body>
</html>
