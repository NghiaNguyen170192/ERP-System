<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteWESDetailPage.aspx.cs"
    Inherits="Assignment2.HTML.WESDetailFolder.DeleteWESDetailPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:Label ID="lblWESDetailId" runat="server" Text="WES Detail ID: "></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT [Id] FROM [WESDetail]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Id" AutoPostBack="true">
        </asp:DropDownList>
        <br/>
        <br/>
        <asp:Button ID="btnWESDetail" runat="server" Text="Delete WES Detail" 
            onclick="btnWESDetail_Click" />
    </div>
</asp:Content>
