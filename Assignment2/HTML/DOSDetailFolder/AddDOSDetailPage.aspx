<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDOSDetailPage.aspx.cs"
    Inherits="Assignment2.HTML.DOSDetailFolder.AddDOSDetailPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:Label ID="Label1" runat="server" Text="DOS ID: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
            DataTextField="DosId" DataValueField="DosId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [DosId] FROM [DOS]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [Product]"></asp:SqlDataSource>
        <asp:Label ID="Label2" runat="server" Text="Product ID: "></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2"
            DataTextField="Id" DataValueField="Id" AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
        <br />
        <asp:TextBox ID="txtQuantity" runat="server" OnTextChanged="txtQuantity_TextChanged"
            Width="300px" AutoPostBack="true"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="txtPrice" runat="server" Width="300px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add DOS Detail" />
    </div>
</asp:Content>
