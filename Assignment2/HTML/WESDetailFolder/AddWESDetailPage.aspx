<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWESDetailPage.aspx.cs"
    Inherits="Assignment2.HTML.WESDetailFolder.AddWESDetailPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [Product]"></asp:SqlDataSource>
        <asp:Label ID="lblProductId" runat="server" Text="Product Id: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
            DataTextField="Id" DataValueField="Id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtProductName" runat="server" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblWesId" runat="server" Text="WES Id: "></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [WesId] FROM [WES]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2"
            DataTextField="WesId" DataValueField="WesId" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label><br />
        <asp:TextBox ID="txtQuantity" runat="server" Width="300px" OnTextChanged="txtQuantity_TextChanged"
            AutoPostBack="true"></asp:TextBox><asp:RegularExpressionValidator ID="regexQuantity"
                runat="server" ErrorMessage="Invalid Quantity" ControlToValidate="txtQuantity"
                ValidationExpression="^(1|[1-9][0-9]*)$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblUnit" runat="server" Text="Unit"></asp:Label>
        <br />
        <asp:TextBox ID="txtUnit" runat="server" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexUnit" runat="server" ErrorMessage="Invalid Unit (Bottle/Box)"
            ControlToValidate="txtUnit" ValidationExpression="^bottle$|^box?$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label><br />
        <asp:TextBox ID="txtPrice" runat="server" Width="300px" ReadOnly="true"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnWESDetail" runat="server" Text="Add WES Detail" OnClick="btnWESDetail_Click" />
    </div>
</asp:Content>
