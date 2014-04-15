<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="UpdateProductPage.aspx.cs" Inherits="Assignment2.HTML.ProductFolder.UpdateProductPage" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">

        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Id" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
        <br/>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT [Id] FROM [Product]"></asp:SqlDataSource>
        <asp:Label ID="lblName" runat="server" Text="Name" Width="100px"></asp:Label>    
        <br />
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
        <asp:Button ID="btnAddProduct" runat="server" OnClick="btnUpdateProduct_Click" Text="Update Product" />
    </div>
</asp:Content>
