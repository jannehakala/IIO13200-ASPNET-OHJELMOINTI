<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lotto.aspx.cs" Inherits="Lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Lotto</h1>
        <asp:DropDownList ID="ddLottoTypes" runat="server">
            <asp:ListItem Selected="True" Value="Lotto"> Lotto </asp:ListItem>
            <asp:ListItem Value="Viking Lotto"> Viking Lotto </asp:ListItem>
        </asp:DropDownList>
        <h4>Valitse montako riviä arvotaan:</h4>
        <asp:TextBox ID="txtRowAmount" runat="server" Width="30px">1</asp:TextBox>
        <asp:Button ID="btnGetLottoNumbers" runat="server" Text="Arvo lottonumerot" OnClick="btnGetLottoNumbers_Click" />
        <h4>Arvotut lottonumerot:</h4>
        <asp:Label ID="lblDrawnLottoNumbers" runat="server" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" />
    </div>
    </form>
</body>
</html>
