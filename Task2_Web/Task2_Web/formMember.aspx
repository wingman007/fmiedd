<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formMember.aspx.cs" Inherits="Task2_Web.formMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtId" runat="server" CausesValidation="True" ReadOnly="True" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="First name: "></asp:Label>
        <br />
        <asp:TextBox ID="txtFname" runat="server" ReadOnly="True" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Second name: "></asp:Label>
        <br />
        <asp:TextBox ID="txtSname" runat="server" ReadOnly="True" style="margin-top: 0px" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
        &nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtPassword" runat="server" ReadOnly="True" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Role:"></asp:Label>
        <br />
        <asp:TextBox ID="txtRole" runat="server" ReadOnly="True" Width="170px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbSelect" runat="server">Users:</asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="410px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="175px"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
    </form>
</body>
</html>
