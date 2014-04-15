<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteWESPage.aspx.cs" Inherits="Assignment2.HTML.WESFolder.DelteWESPage"
    MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [WesId] FROM [WES]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3"
            DataTextField="WesId" DataValueField="WesId" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"
            AutoPostBack="true">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnWES" runat="server" OnClick="btnUpdateWareHouse_Click" 
            Text="Delete WES" />
    </div>
</asp:Content>
