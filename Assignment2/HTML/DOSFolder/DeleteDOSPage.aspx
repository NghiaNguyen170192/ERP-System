<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteDOSPage.aspx.cs"
    Inherits="Assignment2.HTML.DOSFolder.DeleteDOSPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">

        <asp:Label ID="Label1" runat="server" Text="DOS ID: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="DosId" DataValueField="DosId" AutoPostBack="true">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT [DosId] FROM [DOS]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Delete DOS" />

    </div>
</asp:Content>
