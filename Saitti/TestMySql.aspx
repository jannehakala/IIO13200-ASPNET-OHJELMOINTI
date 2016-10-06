<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestMySql.aspx.cs" Inherits="TestMySql" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <h2>SQLDataSourcen avulla</h2>
    <asp:SqlDataSource ID="srcMysli" runat="server" ConnectionString="<%$ ConnectionStrings:Mysli %>"
        ProviderName="MySql.Data.MySqlClient"
        SelectCommand="SELECT " +
                                "esittaja.nimi as Artist, " +
                                "vuosi.vuosi as Year, " +
                                "maa.nimi as Country, " +
                                "esittaja.avain as ID " +
                    "FROM esittaja " +
                    "left join vuosi on esittaja.vuosi_avain = vuosi.avain " +
                    "left join maa on esittaja.maa_avain = maa.avain " +
                    "GROUP BY esittaja.nimi;"
        UpdateCommand="UPDATE esittaja set nimi=@Nimi"></asp:SqlDataSource>

    <asp:GridView ID="gvArtistsDataSource" runat="server" DataSourceID="srcMysli"></asp:GridView>
    <asp:Button  ID="btnGetArtists" runat="server" Text="Hae artistit." OnClick="btnGetArtists_Click"/>
    <asp:GridView ID="gvArtists" runat="server"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    <asp:Label ID="lblMessages" runat="server" />
</asp:Content>

