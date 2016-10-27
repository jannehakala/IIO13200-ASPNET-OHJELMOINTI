<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourseFeedback.aspx.cs" Inherits="CourseFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="float: left">
                <h1>Anna palaute</h1>
                Pvm:<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                Nimi: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
                Opintojakson nimi ja koodi: 
                <asp:TextBox ID="txtCourseID" runat="server"></asp:TextBox><br />
                <br />
                Olen oppinut:
                <asp:TextBox ID="txtLearned" TextMode="multiline" Columns="25" Rows="2" runat="server" /><br />
                <br />
                Haluan oppia:
                <asp:TextBox ID="txtWantLearn" TextMode="multiline" Columns="25" Rows="2" runat="server" />
            </div>
            <div style="float: left;margin-left:50px">
                <br /><br /><br />
                Hyvää:
                <asp:TextBox ID="txtGood" TextMode="multiline" Columns="25" Rows="2" runat="server" /><br /><br />
                Parannettavaa:
                <asp:TextBox ID="txtToMakeBetter" TextMode="multiline" Columns="25" Rows="2" runat="server" /><br /><br />
                Muuta:
                <asp:TextBox ID="txtElse" TextMode="multiline" Columns="25" Rows="2" runat="server" /><br /><br />
                <asp:Button ID="btnSendXML"  Text="Lähetä palaute (XML)" runat="server" OnClick="btnSendXML_Click" />
                <asp:Button ID="btnSendMySQL"  Text="Lähetä palaute (MySQL)" runat="server" OnClick="btnSendMySQL_Click" /><br /><br />
                <asp:Button ID="btnCheckFeedbacks" Text="Näytä palautteet" runat="server" OnClick="btnCheckFeedbacks_Click" />
            </div>
        </div>
    </form>
</body>
</html>
