<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ani_Krivova_1301681024_CRUD_Project.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/HomePageStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 class="title">LOGIN</h1>
        <asp:Label CssClass="labels" ID="username" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox CssClass="texts" ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label CssClass="labels" ID="password" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox CssClass="texts" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    </form>
</body>
</html>
