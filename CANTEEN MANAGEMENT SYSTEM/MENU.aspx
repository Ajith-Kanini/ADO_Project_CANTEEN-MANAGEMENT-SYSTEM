<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MENU.aspx.cs" Inherits="CANTEEN_MANAGEMENT_SYSTEM.MENU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:darkblue;color:white;text-align:center">
    <h1>KANINI FOOD COURT</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lab" runat="server" Text="Select Item to remove"></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="ItemName" DataValueField="ItemName" DataSourceID="SqlDataSource1"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:Canteen_ManagementConnectionString %>" ProviderName="<%$ ConnectionStrings:Canteen_ManagementConnectionString.ProviderName %>" SelectCommand="SELECT [ItemName] FROM [MENU]"></asp:SqlDataSource>
            <asp:Button ID="delete" runat="server" Text="Remove" OnClick="delete_Click" /><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Select Item type"></asp:Label> <br /><br />
            <select id="Itemtype" runat="server">
                <option>VEG</option>
                <option>NON VEG</option>
            </select>
            <asp:Button ID="CNT" runat="server" Text="Get Count" OnClick="CNT_Click" /><br /><br />
            <asp:GridView ID="GridView1" runat="server" style="margin-left:auto;margin-right:auto;"></asp:GridView>
        </div>
    </form>
</body>
</html>
