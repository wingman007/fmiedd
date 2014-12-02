<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Регистрация на нов потребител"></asp:Label>
    
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
        <asp:Button ID="submit_btn" runat="server" OnClick="submit_btn_Click" Text="Регистирай" Width="226px" />
        <br />
        <asp:Label ID="error_lbl" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="Medium" OnClick="Button1_Click" Text="Връщане във &quot;Вход&quot;" Width="226px" />
        <br />
        <p>
    
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" Text="Същесвуващи потребители:"></asp:Label>
    
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
        <br />
        <br />
        Изтриване на потребител с ID <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="ID" DataValueField="ID" Height="27px" Width="78px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:TextBox ID="security_box" runat="server" OnTextChanged="security_box_TextChanged">въведи парола</asp:TextBox>
        <br />
        <asp:Button ID="del_btn" runat="server" OnClick="del_btn_Click" Text="Изтрии!" Width="418px" />
&nbsp;<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" ProviderName="<%$ ConnectionStrings:myConnectionString.ProviderName %>" SelectCommand="SELECT [ID] FROM [users]"></asp:SqlDataSource>
    </form>
</body>
</html>
