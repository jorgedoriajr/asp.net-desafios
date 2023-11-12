<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN5.aspx.cs" Inherits="QN5.QN5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 5</title>
    <link href="QN5.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div>
            <h1>Informaton for DataBase</h1>
        </div>
        <form id="form1" runat="server">
            <div>
                <asp:Label Text="Name:" runat="server" ID="lblName" />
                <asp:TextBox ID="txtName" runat="server" />
                <span id="errName" runat="server"></span>
            </div>
            <div>
                <asp:Label Text="Email:" runat="server" ID="lblEmail" />
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" />
                <span id="errEmail" runat="server"></span>
            </div>
            <div>
                <asp:Label Text="Password:" runat="server" ID="lblPassword" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
                <span id="errPassword" runat="server"></span>
            </div>
            <div>
                <asp:Label Text="Phone:" runat="server" ID="lblPhone" />
                <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" />
                <span id="errPhone" runat="server"></span>
            </div>
            <div>
                <asp:Label Text="Gender:" runat="server" ID="lblGender" />
                <div class="radioOption">
                    <asp:RadioButton ID="rblMale" runat="server" Text="Male" Value="Male" GroupName="rblGender" />
                    <asp:RadioButton ID="rblFemale" runat="server" Text="Female" Value="Female" GroupName="rblGender" />
                    <asp:RadioButton ID="rblOther" runat="server" Text="Other" Value="Other" GroupName="rblGender" />
                </div>
                <span id="errGender" runat="server"></span>
            </div>
            <div>
                <asp:Label Text="Faculty:" runat="server" ID="lblFaculty" />
                <asp:DropDownList ID="ddlFaculty" runat="server">
                    <asp:ListItem Text="Select Faculty" Value="" />
                    <asp:ListItem Text="Humanities" Value="Humanities" />
                    <asp:ListItem Text="Management" Value="Management" />
                    <asp:ListItem Text="Science" Value="Science" />
                </asp:DropDownList>
                <span id="errFaculty" runat="server"></span>
            </div>
            <div class="btnCenter">
                <asp:Button Text="Store Record" runat="server" ID="btnStoreRecord" OnClick="btnStoreRecord_Click" />
                <span id="errStoreRecord" runat="server"></span>
            </div>
            <div>
                <span id="errDataBase" runat="server" ></span>
            </div>
        </form>
    </div>
</body>
</html>
