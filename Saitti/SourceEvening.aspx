<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SourceEvening.aspx.cs" Inherits="SourceEvening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source Page</h1>
            Message to send: <asp:TextBox ID="txtMessage" runat="server" /><br />
            <asp:RequiredFieldValidator ID="RequireFieldValidator1" runat="server" ErrorMessage="Teksti on pakollinen" ControlToValidate="txtMessage" />
            <asp:DropDownList ID="ddlMessages" runat="server" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:Button ID="btnQuery" runat="server" Text="Case1: Query String" OnClick="btnQuery_Click" /><br />
            <asp:Button ID="bntSession" runat="server" Text="Case2: Session" OnClick="bntSession_Click" /><br />
            <asp:Button ID="btnCookie" runat="server" Text="Case3: Cookie" OnClick="btnCookie_Click" /><br />
            <asp:Button ID="btnPublicProperty" runat="server" Text="Case4: Property" OnClick="btnPublicProperty_Click" /><br />
    </div>
    </form>
</body>
</html>
