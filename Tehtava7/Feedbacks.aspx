<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedbacks.aspx.cs" Inherits="Feedbacks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Palautteet</h1>
            <br />
            <br />
            <asp:Button ID="btnGiveFeedback" Text="Anna palaute" runat="server" OnClick="btnGiveFeedback_Click" /><br />
            <br />
            <asp:Button ID="btnGetFeedbacksFromXML" Text="Hae palautteet (XML)" runat="server" OnClick="btnGetFeedbacksFromXML_Click" />
            <asp:Button ID="btnGetFeedbacksFromMySQL" Text="Hae palautteet (MySQL)" runat="server" OnClick="btnGetFeedbacksFromMySQL_Click" /><br />
            <br />
            <h1>XML</h1>
            <asp:GridView ID="gvFeedbacks" runat="server"></asp:GridView>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <h1>MySQL</h1>
            <asp:GridView ID="gvFeedbacksMySQL" runat="server"></asp:GridView>
            <asp:Label ID="lblMessage2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
