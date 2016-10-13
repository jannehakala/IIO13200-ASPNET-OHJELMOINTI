<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Finnkino.aspx.cs" Inherits="Finnkino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcTheatres" Runat="server" DataFile="http://www.finnkino.fi/xml/TheatreAreas/" XPath="TheatreAreas/TheatreArea/Name"/>
    
        <asp:ListBox ID="lbTheatres" Height="600" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbTheatres_SelectedIndexChanged" Font-Size="18" BackColor="#FCC500" /> <br />
        <asp:Label ID="lblInfo" Font-Size="20" BackColor="#FCC500" runat="server"></asp:Label>
    </div>

    </form>
</body>
</html>
