<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersEntityFramework.aspx.cs" Inherits="CustomersEntityFramework" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Button ID="btnGetAllCustomers" Text="Hae kaikki asiakkaat" runat="server" OnClick="btnGetAllCustomers_Click" />
                <asp:DropDownList ID="ddList" runat="server" AutoPostBack="true"></asp:DropDownList>
                <asp:Button ID="btnGetCustomersFromCountry" Text="Hae asiakkaat valitusta maasta" runat="server" OnClick="btnGetCustomersFromCountry_Click" />
                <asp:Button ID="btnGetCustomersBasedOnCountry" Text="Hae asiakkaat maittain" runat="server" OnClick="btnGetCustomersBasedOnCountry_Click" />
                <a href="CreateNewCustomer.aspx">Luo uusi asiakas</a>
            </div>
            <asp:GridView ID="gvCustomers" runat="server" />
            <asp:Label ID="lblMessages" runat="server" />
        </div>
    </form>
</body>
</html>
