<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="StefanCRUDWebApplicationAccess.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet"href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css"/>
    <!-- Optional theme -->
    <link rel="stylesheet"href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap-theme.min.css"/>
    <!-- Latest compiled and minified JavaScript -->
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Registration"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Username:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="user_box" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Password:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="pass_box" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Email:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="email_box" runat="server" Width="153px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Type:"></asp:Label>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Regular</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Button ID="submit_btn" class="btn btn-primary" runat="server" OnClick="submit_btn_Click" Text="register" Width="121px" Height="26px" />
        <p><a href="login.aspx" class="btn btn-primary">Back</a><br /></p>
        <br />
        <asp:Label ID="error_lbl" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:Label>
        <br />
        <br />
        <br />
        <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
        <br />
        <br />
            </p>
       
&nbsp;</div>
    </form>
</body>
</html>
