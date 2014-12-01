<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateForm.aspx.cs" Inherits="CRUD.CrudViews.CreateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Member.aspx" Target="_parent"  CssClass="logoutlink" Font-Underline="True">← Back to Manager</asp:HyperLink>
    <div>
        <h1>Create New Contact</h1>
    </div>

        <asp:Label ID="fname" runat="server" Text="First Name: " CssClass="font"></asp:Label>
&nbsp;<asp:TextBox ID="tbfname" runat="server" CssClass="textboxfont"></asp:TextBox>
        <br />
        <asp:Label ID="lname" runat="server" Text="Last Name: " CssClass="font"></asp:Label>
&nbsp;<asp:TextBox ID="tblname" runat="server" CssClass="textboxfont"></asp:TextBox>
        <br />
        <asp:Label ID="email" runat="server" Text="Email: " CssClass="font"></asp:Label>
&nbsp;<asp:TextBox ID="tbemail" runat="server" CssClass="textboxfont"></asp:TextBox>

        <p>

        <asp:Button ID="submit" runat="server" Text=" Submit " OnClick="submit_Click" CssClass="loginbutton" />

        </p>
        <p>

            &nbsp;</p>

        <asp:Label ID="errorlabel" runat="server" Text="Label" CssClass="font" ForeColor="Red" Visible="False"></asp:Label>

    </form>
</body>
</html>
