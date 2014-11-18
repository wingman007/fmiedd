<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteForm.aspx.cs" Inherits="CRUD.CrudViews.DeleteForm" %>

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
        <h1>Delete Contact</h1>
    </div>
    <p>
        <asp:Label ID="lblcontactId" runat="server" Text="Enter Contact Id for Deleting and then click Enter: " CssClass="font"></asp:Label>
        <asp:TextBox ID="tbcontactid" runat="server" TextMode="Number" Width="82px" Height="30px" OnTextChanged="tbcontactid_TextChanged" CssClass="textboxfont"></asp:TextBox>
    </p>
        <asp:Label ID="errorlabel" runat="server" CssClass="font" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
