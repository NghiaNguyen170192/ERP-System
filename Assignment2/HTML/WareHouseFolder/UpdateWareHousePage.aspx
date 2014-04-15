<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateWareHousePage.aspx.cs"
    Inherits="Assignment2.HTML.WareHouseFolder.UpdateWareHousePage" MasterPageFile="~/Site.master" %>

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
        <asp:Label ID="lblName" runat="server" Text="Name" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexName" runat="server" ControlToValidate="txtName"
            ErrorMessage="Error Name (Must be alphanumeric)" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtAddress" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexPrice" runat="server" ControlToValidate="txtAddress"
            ErrorMessage="Invalid Address" ValidationExpression="^[a-zA-Z0-9_ /.,]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnWareHouse" runat="server" OnClick="btnUpdateWareHouse_Click" Text="Update Ware House" />
    </div>
</asp:Content>
