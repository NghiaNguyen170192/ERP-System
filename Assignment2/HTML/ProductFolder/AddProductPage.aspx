<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AddProductPage.aspx.cs"
    Inherits="Assignment2.HTML.ProductFolder.AddProduct" %>

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
        <asp:Label ID="lblDes" runat="server" Text="Description" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtDes" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexDes" runat="server" ControlToValidate="txtDes"
            ErrorMessage="Invalid Description  (Must be alphanumeric)" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblUnit" runat="server" Text="Unit" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtUnit" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexUnit" runat="server" ControlToValidate="txtUnit"
            ErrorMessage="Invalid Unit (Must be bottle or box)" ValidationExpression="^bottle?$|^box?$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtPrice" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexPrice" runat="server" ControlToValidate="txtPrice"
            ErrorMessage="Invalid Price (Must be numeric)" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnAddProduct" runat="server" OnClick="btnAddProduct_Click" Text="Add Product" />
    </div>
</asp:Content>
