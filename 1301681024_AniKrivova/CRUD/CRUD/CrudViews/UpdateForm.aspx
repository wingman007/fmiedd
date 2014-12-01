<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateForm.aspx.cs" Inherits="CRUD.CrudViews.UpdateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Member.aspx" Target="_parent" CssClass="logoutlink" Font-Underline="True">←  Back to Manager</asp:HyperLink>
    <div>
        <h1>Update Contact</h1>
        <p>
            <asp:Label ID="lblcontactId" runat="server" Text="Enter Contact Id for Updating and then click Enter: " CssClass="font"></asp:Label>
            <asp:TextBox ID="tbcontactid" runat="server" TextMode="Number" Width="82px" Height="30px" OnTextChanged="tbcontactid_TextChanged" CssClass="textboxfont"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Please pick a number " ForeColor="Red" CssClass="font"></asp:Label>
        </p>
    </div>
    <asp:Panel ID="UpdatePanel" runat="server" Visible="False">
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
    </asp:Panel>
    </form>
</body>
</html>
