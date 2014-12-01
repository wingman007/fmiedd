<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fromAdmin.aspx.cs" Inherits="Task2_Web.fromAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="position: relative">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtId" runat="server" CausesValidation="True" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="First name: "></asp:Label>
        <br />
        <asp:TextBox ID="txtFname" runat="server" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Second name: "></asp:Label>
        <br />
        <asp:TextBox ID="txtSname" runat="server" style="margin-top: 0px" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
        &nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtPassword" runat="server" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Role:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_role" runat="server" AutoPostBack="True" Height="19px" Width="175px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>public</asp:ListItem>
            <asp:ListItem>member</asp:ListItem>
            <asp:ListItem>admin</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="messBox" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbSelect" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="410px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="175px"></asp:ListBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCreate" runat="server" OnClick="Button1_Click" Text="Create" Width="61px" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="Button2_Click" Text="Delete" Width="61px" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" OnClick="Button3_Click" Text="Update" Width="61px" />
    
    </div>
    </form>
</body>
</html>
