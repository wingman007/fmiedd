<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CRUD.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcom&nbsp;&nbsp; &nbsp;<asp:Label ID="lblrollename" runat="server" Text="Label"></asp:Label>
&nbsp;<h1>Contact Manager</h1>
        <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="Solid" Height="240px" Width="448px">


        </asp:GridView>--%>
    
    </div>
        <%--  <asp:TextBox ID="TextBox1" runat="server" Height="237px" OnLoad="TextBox1_Load" style="margin-top: 0px" Width="557px"></asp:TextBox>--%>
        <asp:HyperLink ID="Create" runat="server" BackColor="#FFFBD6" BorderStyle="Inset" CssClass="menu-items" EnableTheming="True" ForeColor="#990000" Height="30px" NavigateUrl="~/CrudViews/CreateForm.aspx" Width="70px" BorderColor="White" Font-Size="Large">Create</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Read" runat="server" Height="30px" NavigateUrl="~/CrudViews/ReadForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" ForeColor="#990000" Width="70px">Read</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Update" runat="server" Height="30px" NavigateUrl="~/CrudViews/UpdateForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" ForeColor="#990000" Width="70px">Update</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Delete" runat="server" Height="30px" NavigateUrl="~/CrudViews/DeleteForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" Font-Underline="False" ForeColor="#990000" Width="70px">Delete</asp:HyperLink>
        <br />
&nbsp;<p>
        <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click">logout</asp:LinkButton>
       
        </p>
    </form>
</body>
</html>
