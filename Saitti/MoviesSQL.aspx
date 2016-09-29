<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesSQL.aspx.cs" Inherits="MoviesSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:Movies %>" SelectCommand="SELECT [title], [director], [url], [year] FROM [Movies]"></asp:SqlDataSource>
    <h1>Movies from SQL Server</h1>
    <asp:GridView ID="gvMovies" runat="server" DataSourceID="srcMovies" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="director" HeaderText="director" SortExpression="director" />
            <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
        </Columns>
</asp:GridView>
    <asp:Repeater ID="myRepeater" runat="server" DataSourceID="srcMovies">
        <ItemTemplate>
            <h3> <%# Eval("title") %></h3>
            <img src="<%# Eval("url") %> " alt="missing"  width="300"/>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

