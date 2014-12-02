<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Retrieve.aspx.cs" Inherits="Retrieve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 590px;
        }
        .auto-style1 {
            width: 323px;
            height: 232px;
            margin-left: 440px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <center>
        <asp:Label ID="Label1" runat="server" Text="Записи в базата данни:" Font-Bold="True" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" Font-Size="Large" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="ID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Family" HeaderText="Family" SortExpression="Family" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="Birthday" HeaderText="Birthday" SortExpression="Birthday" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [adress_book]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID" Font-Size="Large" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="show_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Покажи" OnClick="clear_btn_Click" />
            <asp:Button ID="izchisti_btn" runat="server" Font-Bold="True" ForeColor="#3399FF" OnClick="izchisti_btn_Click" Text="Изчисти" />
            <p style="height: 203px">
                <asp:Label ID="Label3" runat="server" Text="Име:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="name_box" runat="server" Font-Size="Medium" OnTextChanged="name_box_TextChanged" Width="138px"></asp:TextBox>
        <br class="auto-style1" />
                <br class="auto-style1" />
                <asp:Label ID="Label4" runat="server" Text="Фамилия:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="family_box" runat="server" Font-Size="Medium" OnTextChanged="name_box_TextChanged" Width="138px"></asp:TextBox>
        <br class="auto-style1" />
                <br class="auto-style1" />
        <asp:Label ID="Label5" runat="server" Text="E-mail:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="email_box" runat="server" Font-Size="Medium" OnTextChanged="name_box_TextChanged" Width="138px"></asp:TextBox>
                <br class="auto-style1" />
                <br class="auto-style1" />
                <asp:Label ID="Label6" runat="server" Text="Рожденна дата:" Font-Bold="True" Font-Size="Large" Font-Underline="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="date_box" runat="server" Font-Size="Medium" OnTextChanged="name_box_TextChanged" Width="138px"></asp:TextBox>
            </p>
        <asp:Label ID="Label2" runat="server" Text="Възможни действия, за профила с, който сте влезли:" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            <br />
            <br />
            <asp:Button ID="add_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Добави" OnClick="add_btn_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="update_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Обнови" OnClick="update_btn_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="delete_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Изтрии" OnClick="delete_btn_Click" />
&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Label ID="error_lbl" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:Label>
            <br />
&nbsp;&nbsp;<p>
                <asp:Button ID="exit_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Изход от профила" OnClick="exit_btn_Click" />
            </p>
            <p>
                &nbsp;</p>
        </center>
    </form>
    </body>
</html>
