<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CRUDProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="112px" Width="278px"></asp:ListBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="id" runat="server" style="margin-left: 63px" Width="119px"></asp:TextBox>
            <asp:Button ID="buttonadd" runat="server" OnClick="buttonadd_Click" style="margin-left: 108px" Text="Add" Width="55px" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="username" runat="server" style="margin-left: 16px"></asp:TextBox>
        <asp:Button ID="buttonedit" runat="server" OnClick="buttonedit_Click" style="margin-left: 111px" Text="Edit" Width="55px" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server" style="margin-left: 16px"></asp:TextBox>
            <asp:Button ID="buttondelete" runat="server" OnClick="buttondelete_Click" style="margin-left: 114px" Text="Delete" />
        </p>
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="email" runat="server" style="margin-left: 47px"></asp:TextBox>
    </form>
</body>
</html>
