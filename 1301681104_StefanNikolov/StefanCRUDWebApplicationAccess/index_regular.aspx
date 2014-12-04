<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index_regular.aspx.cs" Inherits="StefanCRUDWebApplicationAccess.index_regular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Frond-end part</title>
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
        <h3>Front-end part <small>List view</small></h3>
        <br />
        <p><a href="login.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-log-out"></span>Logout</a><br /></p>
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
     </div>
    </form>
</body>
</html>
