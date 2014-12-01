<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CRUD.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
    <div class="font">
    
        Welcom &nbsp;&nbsp; &nbsp;<asp:Label ID="lblrollename" runat="server" Text="Label" CssClass="font" Font-Bold="True" ForeColor="#280302"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click" CssClass="logoutlink" Font-Underline="True">← logout</asp:LinkButton>
       
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Contact Manager</h1>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <img alt="" class="menu-items" src="eyes-office-women-yellow-icon.png" /></p>
    
    </div>
        <%--  <asp:TextBox ID="TextBox1" runat="server" Height="237px" OnLoad="TextBox1_Load" style="margin-top: 0px" Width="557px"></asp:TextBox>--%>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:HyperLink ID="Create" runat="server" BackColor="#FFFBD6" BorderStyle="Inset" CssClass="menu-items" EnableTheming="True" ForeColor="#990000" Height="79px" NavigateUrl="~/CrudViews/CreateForm.aspx" Width="73px" BorderColor="White" Font-Size="Large" ImageUrl="http://icons.iconarchive.com/icons/jommans/mushroom/72/File-Adobe-Dreamweaver-icon.png">Create</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Read" runat="server" Height="80px" NavigateUrl="~/CrudViews/ReadForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" ForeColor="#990000" Width="73px" ImageUrl="http://icons.iconarchive.com/icons/jommans/mushroom/72/Search-icon.png">Read</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Update" runat="server" Height="80px" NavigateUrl="~/CrudViews/UpdateForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" ForeColor="#990000" Width="73px" ImageUrl="http://icons.iconarchive.com/icons/jommans/mushroom/72/Recycle-Empty-icon.png">Update</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Delete" runat="server" Height="80px" NavigateUrl="~/CrudViews/DeleteForm.aspx" BackColor="#FFFBD6" BorderColor="White" BorderStyle="Inset" CssClass="menu-items" Font-Size="Large" Font-Underline="False" ForeColor="#990000" Width="73px" ImageUrl="http://icons.iconarchive.com/icons/jommans/mushroom/72/File-Adobe-Flash-icon.png">Delete</asp:HyperLink>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC6635" Text="Create"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#CC6635" Text="Retrieve"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#CC6635" Text="Update"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#CC6635" Text="Delete"></asp:Label>
&nbsp;<p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
