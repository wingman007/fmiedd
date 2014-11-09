<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateForm.aspx.cs" Inherits="CRUD.CrudViews.CreateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Member.aspx" Target="_parent">&lt;-  Back to Manager</asp:HyperLink>
    <div>
        <h1>Create New Contact</h1>
    </div>

        <asp:Label ID="fname" runat="server" Text="First Name: "></asp:Label>
&nbsp;<asp:TextBox ID="tbfname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lname" runat="server" Text="Last Name: "></asp:Label>
&nbsp;<asp:TextBox ID="tblname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="email" runat="server" Text="Email: "></asp:Label>
&nbsp;<asp:TextBox ID="tbemail" runat="server"></asp:TextBox>

        <p>

        <asp:Button ID="submit" runat="server" Text=" Submit " OnClick="submit_Click" />

        </p>

    </form>
</body>
</html>
