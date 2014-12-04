<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginTo.aspx.cs" Inherits="Task4.LoginTo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 314px; width: 1393px">
    
        
    
        
    
        
    
        
    
        
    
        
    
        
    
        <asp:Label ID="lblusername" runat="server" Text="User name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtloginusername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtloginpassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" Text="Log in" OnClick="btnLogin_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        
    
        
    
        
    
        
    
        
    
        
    
        
    
    </div>
    </form>
</body>
</html>
