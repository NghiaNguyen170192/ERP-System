<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProviderPage.aspx.cs"
    Inherits="Assignment2.HTML.ProviderFolder.AddProviderPage" MasterPageFile="~/Site.master" %>

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
        <asp:Label ID="Address" runat="server" Text="Address" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtAddress" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexAddress" runat="server" ControlToValidate="txtAddress"
            ErrorMessage="Invalid Address" ValidationExpression="^[a-zA-Z0-9 ,./_]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblPhone" runat="server" Text="Phone" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtPhone" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexPhone" runat="server" ControlToValidate="txtPhone"
            ErrorMessage="Invalid Phone" ValidationExpression="^((012[0-9])|(016[2-9])|(09[0-9])|(0188)|(0199))[0-9]{7}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtEmail" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Invalid Email" ValidationExpression="^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblContactPerson" runat="server" Text="Contact Person" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtContactPerson" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexContactPerson" runat="server" ControlToValidate="txtContactPerson"
            ErrorMessage="Invalid Contact Person" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblContactPhone" runat="server" Text="Contact Phone" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtContactPhone" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexContactPhone" runat="server" ControlToValidate="txtContactPhone"
            ErrorMessage="Invalid ContactPhone" ValidationExpression="^^((012[0-9])|(016[2-9])|(09[0-9])|(0188)|(0199))[0-9]{7}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email" Width="100px"></asp:Label><br />
        <asp:TextBox ID="txtContactEmail" runat="server" MaxLength="255" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexContactEmail" runat="server" ControlToValidate="txtContactEmail"
            ErrorMessage="Invalid Contact Email" ValidationExpression="^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnProvider" runat="server" OnClick="btnProvider_Click" Text="Add Provider" />
    </div>
</asp:Content>
