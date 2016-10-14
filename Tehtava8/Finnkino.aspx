<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Finnkino.aspx.cs" Inherits="Finnkino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="float: left;">
                <asp:ListBox ID="lbTheatres" Height="600" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbTheatres_SelectedIndexChanged" Font-Size="18" BackColor="#FCC500" />
                <br />

            </div>
            <div>
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <HeaderTemplate>
                        <table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div id="myDiv" runat="server"></div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <asp:Label ID="Label1" Font-Size="20" BackColor="#FCC500" runat="server"></asp:Label>
            <asp:Label ID="lblInfo" Font-Size="20" BackColor="#FCC500" runat="server"></asp:Label>
        </div>

    </form>
</body>
</html>
