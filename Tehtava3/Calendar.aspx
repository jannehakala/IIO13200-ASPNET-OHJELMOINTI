<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 id="mytext" runat="server"></h1>
        Valitse haluamasi päivä: <asp:Label ID="lblSelectedDate" runat="server"></asp:Label><br />
        Valitun päivän ja tämän päivän erotus: <asp:Label ID="lblDateDifference" runat="server"></asp:Label><br />
        <asp:Button ID="btnPreviousYear" runat="server" Text="< vuosi" OnClick="btnPreviousYear_Click" />
        <asp:Button ID="btnNextYear" runat="server" Text="vuosi >   " OnClick="btnNextYear_Click" />
        <asp:Calendar ID="cal1" runat="server" OnSelectionChanged="cal1_SelectionChanged" AutoPostBack="True"></asp:Calendar>
    </div>
    </form>
</body>
</html>
