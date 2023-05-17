<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QN3.aspx.cs" Inherits="QN3.QN3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q.N 3</title>
    <link href="QN3.css" rel="stylesheet" />
</head>
<body>
    <div runat="server" class="container">
        <form id="form1" runat="server">
            <div class="top-section">
                <span runat="server">Assessement Info</span>
                <div runat="server" id="selectGender">
                    <asp:DropDownList runat="server" ID="drlGender">
                        <asp:ListItem Text="Select Gender" />
                        <asp:ListItem Text="Male" Value="male" />
                        <asp:ListItem Text="Female" Value="female" />
                        <asp:ListItem Text="Others" Value="others" />
                    </asp:DropDownList>
                </div>
                <div runat="server" id="selectStatus">
                    <asp:DropDownList runat="server" ID="drlStatus">
                        <asp:ListItem Text="Select Status" />
                        <asp:ListItem Text="Married" Value="married" />
                        <asp:ListItem Text="Un-Married" Value="unmarried" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="firstInput">
                <asp:Label Text="Monthly Salary" runat="server" ID="lblMonthlySalary" />
                <asp:TextBox runat="server" ID="txtMonthlySalary" TextMode="Number" />
            </div>
            <div class="annualCalculation">
                <asp:Label Text="Annual Income" runat="server" ID="lblAnnualIncome" />
                <span id="lblAnnualCalculated" runat="server"></span>
            </div>
            <div class="secondInput">
                <asp:Label Text="Annual Gross Salary" runat="server" ID="lblGrossSalary" />
                <asp:TextBox runat="server" ID="txtGrossSalary" TextMode="Number" />
            </div>
            <div class="buttonSection">
                <asp:Button Text="Clear Inputs" runat="server" ID="btnClearInput" OnClick="btnClearInput_Click" />
                <asp:Button Text="Calculate Tax" runat="server" ID="btnCalculateTax" OnClick="btnCalculateTax_Click" />
            </div>
        </form>
        <div class="resultSection">
            <span runat="server" id="calculatedTax">Calculated Tax:</span>
            <span runat="server" id="lblResult"></span>
        </div>
        <div class="errMessage">
            <h6 id="errMsg1" runat="server" ></h6>
            <h6 id="errMsg2" runat="server" ></h6>
            <h6 id="errMsg3" runat="server" ></h6>
            <h6 id="errMsg4" runat="server" ></h6>
        </div>
    </div>
</body>
</html>
