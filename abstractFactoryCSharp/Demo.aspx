<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="abstractFactoryCSharp.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span runat="server" id="myEmployee"></span>

        <asp:DropDownList runat="server" ID ="ddEmployee" OnSelectedIndexChanged="DdEmployee_SelectedIndexChanged" AutoPostBack ="true">
            <asp:ListItem Value="0">All</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:DataGrid ID ="dgEmployees" runat ="server" AutoGenerateColumns ="False" OnItemCommand="dgEmployees_ItemCommand">
            <Columns>
                <asp:BoundColumn DataField="FirstName" HeaderText="First Name"></asp:BoundColumn>
                <asp:BoundColumn DataField="LastName" HeaderText="Last Name"></asp:BoundColumn>
                <asp:BoundColumn DataField="Title" HeaderText="Title"></asp:BoundColumn>
                <asp:BoundColumn DataField="Age" HeaderText="Age"></asp:BoundColumn>
                <asp:BoundColumn DataField="Salary" HeaderText="Salary"></asp:BoundColumn>
                <asp:ButtonColumn ButtonType="LinkButton" Text="GetQuote" CommandName="quote"></asp:ButtonColumn>
            </Columns>
        </asp:DataGrid>
    </div>
    </form>
</body>
</html>
