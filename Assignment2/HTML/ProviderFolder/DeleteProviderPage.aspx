<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteProviderPage.aspx.cs"
    Inherits="Assignment2.HTML.ProviderFolder.DeleteProviderPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="Id" DataValueField="Id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [Provider]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnProvider" runat="server" OnClick="btnProvider_Click" Text="Delete Provider" />
    </div>
</asp:Content>
