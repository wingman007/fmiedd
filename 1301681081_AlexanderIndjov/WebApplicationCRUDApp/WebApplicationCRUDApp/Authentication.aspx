<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="WebApplicationCRUDApp.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        html{
            background-color:silver;
        }
        .AuthenticationStyle{
            padding:20px;
           text-align:center;
        }
        .BtnStyle:hover{
            background-color:green;
        }
        </style>
</head>
<body style="height: 194px">
    <div class="AuthenticationStyle">
    <form id="form1" runat="server">
    <div style="height: 186px">
    
        <asp:Label ID="LblUsername" runat="server" Font-Bold="True" Text="USERNAME:"></asp:Label>
        <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LblPassword" runat="server" Font-Bold="True" Text="PASSWORD: "></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server" Width="129px"></asp:TextBox>
        <br />
        <asp:Button ID="BtnLogIN" runat="server" CssClass="BtnStyle" Height="42px" OnClick="BtnLogIN_Click" Text="LogIN" Width="222px" />
        <br />
    </div>
    </form>
   </div>
</body>
</html>
