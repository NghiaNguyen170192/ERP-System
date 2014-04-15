<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWareHousePage.aspx.cs"
    Inherits="Assignment2.HTML.WareHouseFolder.AddWareHousePage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
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
        <asp:Button ID="btnWareHouse" runat="server" 
            OnClick="btnAddWareHouse_Click" Text="Add Ware House" />
    </div>
</asp:Content>
