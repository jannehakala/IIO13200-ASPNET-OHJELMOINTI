<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ikkunalaskin.aspx.cs" Inherits="Ikkunalaskin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblWindowWidth" runat="server" Text="Ikkunan leveys (L):"></asp:Label>
        <asp:TextBox ID="txtWindowWidth" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblWindowHeight" runat="server" Text="Ikkunan korkeus (H):"></asp:Label>
        <asp:TextBox ID="txtWindowHeight" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblFrameWidth" runat="server" Text="Karmipuun leveys (W):"></asp:Label>
        <asp:TextBox ID="txtFrameWidth" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnCalculatePrice" runat="server" Text="Laske tarjoushinta" OnClick="btnCalculatePrice_Click" /><br /><br />
        <asp:Label ID="lblWindowArea" runat="server" Text="Ikkunan pinta-ala:"></asp:Label>
        <asp:Label ID="lblResultWindowArea" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="lblFrameCircuit" runat="server" Text="Karmin piiri:"></asp:Label>
        <asp:Label ID="lblResultFrameCircuit" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="lblPrice" runat="server" Text="Tarjoushinta (ilman ALV):"></asp:Label>
        <asp:Label ID="lblResultPrice" runat="server" Text=""></asp:Label><br /><br />
    </div>
    </form>
</body>
</html>
