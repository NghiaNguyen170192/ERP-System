<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateWESPage.aspx.cs"
    Inherits="Assignment2.HTML.WESFolder.UpdateWESPage" MasterPageFile="~/Site.master" %>

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
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White"
            BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px"
            NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
                Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label><br />
        <asp:TextBox ID="txtDate" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [WareHouseId] FROM [WareHouse]"></asp:SqlDataSource>
        <asp:Label ID="lblWareHouseId" runat="server" Text="Ware House Id:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="WareHouseId" DataValueField="WareHouseId" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtWareHouseName" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            SelectCommand="SELECT [Id] FROM [Provider]"></asp:SqlDataSource>
        <asp:Label ID="lblProviderId" runat="server" Text="Provider Id:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2"
            DataTextField="Id" DataValueField="Id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
            AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtProviderName" runat="server" ReadOnly="true" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblTotalValue" runat="server" Text="Total Value"></asp:Label><br />
        <asp:TextBox ID="txtTotalValue" runat="server" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexTotalValue" runat="server" ControlToValidate="txtTotalValue"
            ErrorMessage="Invalid Total Value (Must be numeric)" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblUser" runat="server" Text="User"></asp:Label><br />
        <asp:TextBox ID="txtUser" runat="server" Width="300px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexUser" runat="server" ControlToValidate="txtUser"
            ErrorMessage="Invalid User" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnWES" runat="server" OnClick="btnUpdateWareHouse_Click" 
            Text="Update WES" />
    </div>
</asp:Content>
