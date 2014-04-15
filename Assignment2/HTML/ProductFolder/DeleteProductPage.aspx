<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="DeleteProductPage.aspx.cs"
    Inherits="Assignment2.HTML.ProductFolder.DeleteProductPage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="Id" DataValueField="Id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [Product]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="btnDeleteProduct" runat="server" OnClick="btnDeleteProduct_Click"
            Text="Delete Product" />
    </div>
</asp:Content>
