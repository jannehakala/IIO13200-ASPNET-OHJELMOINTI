<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AlbumPage.aspx.cs" Inherits="AlbumPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <img src="" id="albumImage" runat="server"/>

    <div id="albumInfos" style="font-size:20px;font-weight:bold" runat="server"></div>
    <div style="font-size:20px;font-weight:bold">Levyn biisit:</div>
    <div id="albumSongs" style="font-size:18px;" runat="server"></div>
    <a href="Levykauppax.aspx" runat="server">Takaisin</a>
</asp:Content>

