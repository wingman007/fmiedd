<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexMember.aspx.cs" Inherits="StamislavaAramazova1301681111.indexMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="MemberLogin" Height="170px" style="text-align: center" Width="467px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="logOut" runat="server" OnClick="logOut_Click" style="text-align: center" Text="Log Out" Width="130px" />
        <asp:SqlDataSource ID="MemberLogin" runat="server" ConnectionString="Data Source=ARAMAZOVI;Initial Catalog=User;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
