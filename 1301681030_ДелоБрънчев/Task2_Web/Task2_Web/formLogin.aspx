<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formLogin.aspx.cs" Inherits="Task2_Web.formLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 576px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; font-family: 'Arial Black'; font-size: 20pt;">
    
        Login From<br />
        <table class="auto-style1" style="font-size: 10pt">
            <tr>
                <td style="text-align:right" class="auto-style2">
    
        <asp:Label ID="lbuser" runat="server" Text="User name"></asp:Label>
                </td>
                <td style="text-align:left">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style2">
        <asp:Label ID="lbpass" runat="server" Text="Password"></asp:Label>
                </td>
                <td style="text-align:left">
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbMess" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="98px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
