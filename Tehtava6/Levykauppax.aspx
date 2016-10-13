﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Levykauppax.aspx.cs" Inherits="Levykauppax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <asp:XmlDataSource ID="srcAlbums" runat="server" DataFile="~/App_Data/LevykauppaX.xml" XPath="//record"></asp:XmlDataSource>
    
    <asp:Repeater ID="Repeater1" DataSourceID="srcAlbums" OnItemDataBound="Repeater1_ItemDataBound" runat="server">
        <HeaderTemplate>

        </HeaderTemplate>
        <ItemTemplate>
            <div style="display:inline-block" runat="server">
                <div style="float:left;margin-left:20px">
                    <img width="150" height="150" src="images/<%# Eval("ISBN") %>.jpg" />         
                </div>
                <div style="float:left;margin-left:20px">
                    <br /><br /><span style="font-size:20px;font-weight:bold"><%# Eval("Artist") %> : <%# Eval("Title") %><br /><br />
                    ISBN:</span><span style="font-size:18px"> <a href="AlbumPage.aspx?value=<%# Eval("ISBN") %>"><%# Eval("ISBN") %></a></span> <br />
                    <span style="font-size:20px;font-weight:bold">Hinta:</span><span style="font-size:18px"> <%# Eval("Price") %></span>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Label ID="myLbl" runat="server"></asp:Label>
    
</asp:Content>

