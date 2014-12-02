<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgottenPassword.aspx.cs" Inherits="ForgottenPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Забравена парола"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="username:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="username_box" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="e-mail:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="email_box" runat="server" Width="142px"></asp:TextBox>
        </p>
        <asp:Button ID="ok_btn" runat="server" OnClick="Button1_Click" Text="Покажи" Width="201px" />
        <p style="margin-left: 40px">
            <asp:Label ID="pass_lbl" runat="server" Font-Bold="False" Font-Size="X-Large" Font-Underline="True" Text="вашата парола"></asp:Label>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="back_btn" runat="server" OnClick="back_btn_Click" Text="обратно към вход" Width="152px" />
        </p>
    </form>
</body>
</html>
