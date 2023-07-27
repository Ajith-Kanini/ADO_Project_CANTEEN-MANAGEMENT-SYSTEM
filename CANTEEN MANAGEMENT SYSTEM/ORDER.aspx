<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ORDER.aspx.cs" Inherits="CANTEEN_MANAGEMENT_SYSTEM.ORDER" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:darkblue;color:white;text-align:center">
    <h1>KANINI FOOD COURT</h1>
    <form id="form1" runat="server">
         <div style="margin-left:auto;margin-right:auto; margin-top:12%; width:600px; text-align:center;border-radius:20px;background-color:blue">
            <h3>Update</h3>
            <asp:Label ID="lab" runat="server" Text="Select Item to update"></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="ItemName" DataValueField="ItemName" DataSourceID="SqlDataSource1"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:Canteen_ManagementConnectionString %>" ProviderName="<%$ ConnectionStrings:Canteen_ManagementConnectionString.ProviderName %>" SelectCommand="SELECT [ItemName] FROM [MENU]"></asp:SqlDataSource>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Enter new Price"></asp:Label> <br />
            <asp:TextBox ID="ItemPrice" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label4" runat="server" Text="Enter new offer"></asp:Label> <br />
            <asp:TextBox ID="offer" runat="server"></asp:TextBox><br /><br />

             <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
           
        </div><br /><br />
    </form>
</body>
</html>
