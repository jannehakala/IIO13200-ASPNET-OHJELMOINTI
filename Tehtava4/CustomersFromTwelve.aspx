<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomersFromTwelve.aspx.cs" Inherits="CustomersFromTwelve" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:SqlDataSource ID="srcCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:Customers %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
    <h1>Customers from SQL Server</h1>
    <div style="float: left; margin-right: 30px;">
        <asp:GridView ID="gvCustomers" runat="server" DataSourceID="srcCustomers" AutoGenerateColumns="False" DataKeyNames="astunnus">
            <Columns>
                <asp:BoundField DataField="astunnus" HeaderText="astunnus" ReadOnly="True" SortExpression="astunnus" />
                <asp:BoundField DataField="asnimi" HeaderText="asnimi" SortExpression="asnimi" />
                <asp:BoundField DataField="yhteyshlo" HeaderText="yhteyshlo" SortExpression="yhteyshlo" />
                <asp:BoundField DataField="postitmp" HeaderText="postitmp" SortExpression="postitmp" />
            </Columns>
        </asp:GridView>
    </div>
    <div style="float: left;">
        <h1>Customers from DBDemoxOy.cs class</h1>
        <asp:GridView ID="gvCustomers2" runat="server"></asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

