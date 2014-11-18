<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NR.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtId" runat="server" CausesValidation="True" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtUname" runat="server" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
        &nbsp;<br />
        <asp:TextBox ID="txtPassword" type="password" runat="server" style="margin-top: 0px" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
        &nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="txtEmail" runat="server" Width="170px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="messBox" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbSelect" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="300px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="175px"></asp:ListBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" Width="61px" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" Width="61px" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" Width="61px" />
    <div>
    
    </div>
    </form>
</body>
</html>
