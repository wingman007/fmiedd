<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormLogin.aspx.cs" Inherits="Lilyana_Ihtimanska_Task2.FormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            background-color: #FFFFFF;
        }
        .auto-style1 {
            font-weight: normal;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h1>&nbsp;</h1>
        </div>
        <div style="text-align: center">
            <p>
                &nbsp;</p>
        </div>
        <div style="text-align: center">
            <h1>Login Form</h1>
        </div>
        <div style="text-align: center">
            <p>
                <strong><span class="auto-style2">Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
        </div>
        <div style="text-align: center">
            <p class="auto-style1">
                <strong>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </p>
        </div>
        <div style="text-align: center">
            <p class="auto-style1">
                <asp:Label ID="lblFail" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
        <div style="text-align: center">
            <p class="auto-style1">
                <asp:Button ID="BtnLogin" runat="server" BackColor="#9999FF" Font-Bold="True" Font-Size="Medium" Height="30px" OnClick="BtnLogin_Click" Text="Login" Width="100px" />
            </p>
        </div>
    </form>
</body>
</html>
