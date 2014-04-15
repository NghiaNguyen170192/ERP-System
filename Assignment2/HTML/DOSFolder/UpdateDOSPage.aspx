<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDOSPage.aspx.cs"
    Inherits="Assignment2.HTML.DOSFolder.UpdateDOSPage" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="padding">
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT [DosId] FROM [DOS]"></asp:SqlDataSource>
        <asp:Label ID="Label3" runat="server" Text="DOS ID: "></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" 
            DataSourceID="SqlDataSource2" DataTextField="DosId" DataValueField="DosId">
        </asp:DropDownList>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" 
            Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" 
            Width="330px" onselectionchanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" 
                Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <br />
        <asp:TextBox ID="txtDate" runat="server" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT [WareHouseId] FROM [WareHouse]"></asp:SqlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="From WareHouse"></asp:Label><br/>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="WareHouseId" 
            DataValueField="WareHouseId">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="To WareHouse"></asp:Label><br/>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="WareHouseId" 
            DataValueField="WareHouseId">
        </asp:DropDownList>
        <br />
        <br />


        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Update DOS" />


    </div>
</asp:Content>
