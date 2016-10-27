<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedbacks.aspx.cs" Inherits="Feedbacks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Palautteet</h1><br /><br />
        <asp:Button ID="btnGiveFeedback" Text="Anna palaute" runat="server" OnClick="btnGiveFeedback_Click" /><br /><br />
        <asp:Button ID="btnGetFeedbacksFromXML" Text="Hae palautteet (XML)" runat="server" />
        <asp:Button ID="btnGetFeedbacksFromMySQL" Text="Hae palautteet (MySQL)" runat="server" />
    </div>
    </form>
</body>
</html>
