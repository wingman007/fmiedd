<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StefanCRUDWebApplicationAccess.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet"href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css"/>
    <!-- Optional theme -->
    <link rel="stylesheet"href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap-theme.min.css"/>
    <!-- Latest compiled and minified JavaScript -->
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
    
        <asp:Label ID="Label1" runat="server" Text="Login" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True"></asp:Label>
    
    </div>
        <p>
            &nbsp;</p>
                <asp:Label ID="Label3" runat="server" Text="username:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
                <asp:TextBox ID="username_box" runat="server"></asp:TextBox>
        <br />
        <br />
                <asp:Label ID="Label4" runat="server" Text="password:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
                <asp:TextBox ID="password_box" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="error_lbl" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC3300"></asp:Label>
        <br />
                <asp:Button ID="enter_btn" class="btn btn-primary" runat="server" Font-Size="Large" OnClick="enter_btn_Click" Text="login" Width="72px" Height="30px" />
                <p><a href="registration.aspx" class="btn btn-primary">register</a><br /></p>
            <br />
        <br />
    </div>
    </form>
</body>
</html>
