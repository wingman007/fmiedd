<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Promote.aspx.cs" Inherits="WebApplicationCRUDApp.Promote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        html{
           background-color:silver;
        }
        .BtnStyle:hover{
            background-color:green;
        }
    </style>
</head>
<body style="height: 174px">
    <form id="form1" runat="server">
    <div style="height: 166px">
    
        <asp:Label ID="LblName" runat="server" Font-Bold="True" Text="USERNAME:"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LblPass" runat="server" Font-Bold="True" Text="PASSWORD:"></asp:Label>
        <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="IsAdmin" runat="server" Font-Bold="True" Text="ISADMIN:"></asp:Label>
        <asp:TextBox ID="TxtRole" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnPromote" runat="server" CssClass="BtnStyle" Height="44px" OnClick="BtnPromote_Click" Text="Promote" Width="215px" />
        <br />
    
    </div>
    </form>
</body>
</html>
