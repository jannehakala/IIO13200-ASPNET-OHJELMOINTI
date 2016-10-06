<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DemoJSON.aspx.cs" Inherits="DemoJSON" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGet" runat="server" Text="Hae Json-teksti" OnClick="btnGet_Click" />
    <asp:Button ID="btnGetPerson" runat="server" Text="Hae Json ja muuta olioiksi" OnClick="btnGetPerson_Click" />
    <asp:Button ID="btnGetPolticis" runat="server" Text="Hae Json-teksti" OnClick="btnGetPolticis_Click"/>
    <asp:Literal ID="ltResult" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

