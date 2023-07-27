<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Canteen_Home.aspx.cs" Inherits="CANTEEN_MANAGEMENT_SYSTEM.Canteen_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:darkblue;color:white;text-align:center">
     
    <form id="form1" runat="server" >
        <h1>KANINI FOOD COURT</h1>
         <asp:Button ID="Fetch" runat="server" Text="MENU" OnClick="Fetch_Click" />
            <asp:Button ID="order" runat="server" Text="To Update" OnClick="order_Click" />
        <asp:Button ID="search1" runat="server" Text="GO" Style="float: right" OnClick="search1_Click" />
        <input id="sea" type="search" placeholder="Search by Item name" runat="server" style="float:right"/>
        <div style="margin-left:auto;margin-right:auto; margin-top:12%; width:600px; text-align:center;border-radius:20px;background-color:blue">
            <h3>Add new Item</h3>
            <asp:Label ID="Label1" runat="server" Text="Enter Item Name"></asp:Label> <br />
            <asp:TextBox ID="ItemName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Select Item type"></asp:Label> <br />
            <select id="Itemtype" runat="server">
                <option>VEG</option>
                <option>NON VEG</option>
            </select><br /><br />

            <asp:Label ID="Label3" runat="server" Text="Enter Item Price"></asp:Label> <br />
            <asp:TextBox ID="ItemPrice" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label4" runat="server" Text="Enter offer you provide in %"></asp:Label> <br />
            <asp:TextBox ID="offer" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Insert" runat="server" Text="ADD" OnClick="Insert_Click" />
            <asp:Button ID="reset" runat="server" Text="Reset" OnClick="reset_Click" />
            
           
        </div><br /><br />
        <div>
            <asp:GridView ID="GridView1" runat="server" style="margin-left:auto;margin-right:auto"></asp:GridView>
        </div>
    </form>
</body>
</html>
