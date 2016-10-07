<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VRTrains.aspx.cs" Inherits="VRTrains" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="UTF-8"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddListCities" AutoPostBack="true" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnGetLeavingTrains" runat="server" Text="Hae lähtevät junat" OnClick="btnGetLeavingTrains_Click" />
        <asp:GridView ID="gvTrains" runat="server">
        </asp:GridView>
        <asp:Label ID="lblText" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
