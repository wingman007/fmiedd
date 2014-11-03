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
        <h1 class="title">LOGIN Form</h1>
        <asp:Label CssClass="labels" ID="username" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox CssClass="texts" ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" CssClass="field-validation-error" ErrorMessage="The username field is required."></asp:RequiredFieldValidator>
        <asp:Label CssClass="labels" ID="password" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox CssClass="texts" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" CssClass="field-validation-error" ErrorMessage="The password field is required." />
 
        <a class="buttonlogin" href="ContactManager.aspx">Login</a>
    </div>
    </form>
</body>
</html>
