<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Влизане в профил" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True"></asp:Label>
    
    </div>
        <p>
            &nbsp;</p>
                <asp:Label ID="Label3" runat="server" Text="username:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
                <asp:TextBox ID="username_box" runat="server"></asp:TextBox>
        <br />
        <br />
                <asp:Label ID="Label4" runat="server" Text="password:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
                <asp:TextBox ID="password_box" runat="server" OnTextChanged="password_box_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="error_lbl" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC3300"></asp:Label>
        <br />
                <asp:Button ID="enter_btn" runat="server" Font-Size="Large" OnClick="enter_btn_Click" Text="Вход" Width="204px" />
            <br />
        <br />
        <asp:Button ID="reg_btn" runat="server" Text="нова регистрация" Width="203px" OnClick="reg_btn_Click" />
        <br />
        <br />
        <asp:Button ID="pass_btn" runat="server" OnClick="pass_btn_Click" Text="забравена парола" Width="201px" />
        <br />
    </form>
</body>
</html>
