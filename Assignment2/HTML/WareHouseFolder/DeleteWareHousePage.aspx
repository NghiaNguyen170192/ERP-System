<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DeleteWareHousePage.aspx.cs"
    Inherits="Assignment2.HTML.WareHouseFolder.DeleteWareHousePage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="WareHouseId" DataValueField="WareHouseId" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [WareHouseId] FROM [WareHouse]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="btnWareHouse" runat="server" OnClick="btnDeleteWareHouse_Click" 
            Text="Delete Ware House" />
    </div>
</asp:Content>
