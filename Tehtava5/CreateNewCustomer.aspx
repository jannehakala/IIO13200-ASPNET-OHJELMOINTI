<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateNewCustomer.aspx.cs" Inherits="CreateNewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Lisää uusi asiakas</h1>
            <asp:Label ID="lblMessage" runat="server"/><br /><br />
            Asiakastunnus: <asp:TextBox ID="txtID" runat="server" /><br />
            Asiakkaan nimi: <asp:TextBox ID="txtCustomerName" runat="server" /><br />
            Yhteyshenkilö: <asp:TextBox ID="txtContactPerson" runat="server" /><br />
            Maakoodi: <asp:TextBox ID="txtCountryCode" runat="server" /><br />
            Postinumero: <asp:TextBox ID="txtPostalCode" runat="server" /><br />
            Postitoimipaikka: <asp:TextBox ID="txtPostOffice" runat="server" /><br />
            Ostot: <asp:TextBox ID="txtPurchases" runat="server" /><br />
            Aloitusvuosi: <asp:TextBox ID="txtCustomerYear" runat="server" /><br /><br />
            <asp:Button ID="btnCreateNewCustomer" Text="Luo asiakas" runat="server" OnClick="btnCreateNewCustomer_Click" /><br /><br />
            <a href="CustomersEntityFramework.aspx">Takaisin</a>
        </div>
    </form>
</body>
</html>
