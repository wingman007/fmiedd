﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StamislavaAramazova1301681111.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="LOGIN:"></asp:Label>
    
    </div>
        <div style="width: 431px">
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            :
            <asp:TextBox ID="userLogin" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="passLogin" runat="server" style="text-align: center"></asp:TextBox>
        <div>
            <asp:Button ID="bttnLogin" runat="server" OnClick="bttnLogin_Click" Text="Login" Width="225px" />
        </div>
    </form>
</body>
</html>
