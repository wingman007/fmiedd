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
    
        Welcom&nbsp;
       
        <h1>Contact Manager</h1>
        <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="Solid" Height="240px" Width="448px">


        </asp:GridView>--%>
    
    </div>
        <%--  <asp:TextBox ID="TextBox1" runat="server" Height="237px" OnLoad="TextBox1_Load" style="margin-top: 0px" Width="557px"></asp:TextBox>--%>
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" BorderStyle="Inset" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <Items>
                <asp:MenuItem Text="Create"  Value="Create" NavigateUrl="~/CrudViews/CreateForm.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Read" Value="Read" NavigateUrl="~/CrudViews/ReadForm.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Update" Value="Update" NavigateUrl="~/CrudViews/UpdateForm.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Delete" Value="Delete" NavigateUrl="~/CrudViews/DeleteForm.aspx"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#FFCC66" />
        </asp:Menu>
        <p>
        <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click">logout</asp:LinkButton>
       
        </p>
    </form>
</body>
</html>
