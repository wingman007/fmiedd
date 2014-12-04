<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="WebApplicationCRUDApp.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style_sheet1.css" rel="stylesheet" />
</head>
<body style="height: 402px">
    <form id="form1" runat="server">
    <div style="height: 407px">
    
      <div class="Style">
          <asp:Label ID="LblState" runat="server"></asp:Label>
          <br />
          <asp:Button ID="BtnCreate" runat="server" Height="48px" OnClick="BtnCreate_Click" Text="Create" Width="100px" />
          <asp:Button ID="BtnUpdate" runat="server" Height="48px" OnClick="BtnUpdate_Click" Text="Update" Width="100px" />
          <asp:Button ID="BtnDelete" runat="server" Height="48px" OnClick="BtnDelete_Click" Text="Delete" Width="100px" />
          <asp:Button ID="BtnPromote" runat="server" Height="48px" OnClick="BtnPromote_Click" Text="Promote User" Width="100px" />
          <asp:LinkButton ID="LBLogOut" runat="server" OnClick="LBLogOut_Click">LogOut</asp:LinkButton>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Height="185px" Width="1046px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="RoleID" HeaderText="RoleID" SortExpression="RoleID" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ALEXANDERBase1ConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
     </div>
        <br />
    
        <br />
        <asp:ImageButton ID="BtnBack" runat="server" Height="86px" ImageUrl="~/Images/Undo.png" OnClick="BtnBack_Click" Width="220px" />
    
    </div>
    </form>
</body>
</html>
