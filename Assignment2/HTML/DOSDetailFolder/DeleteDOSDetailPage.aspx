<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteDOSDetailPage.aspx.cs"
    Inherits="Assignment2.HTML.DOSDetailFolder.DeleteDOSDetailPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [DOSDetail]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="DOS Detail ID: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="Id" DataValueField="Id">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Delete DOS Detail" 
            onclick="Button1_Click" />
    </div>
</asp:Content>
