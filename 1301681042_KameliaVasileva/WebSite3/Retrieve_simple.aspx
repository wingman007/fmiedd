<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Retrieve_simple.aspx.cs" Inherits="Retrieve" %>

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
            <p style="height: 203px">
                &nbsp;&nbsp;
        <br class="auto-style1" />
        <asp:Label ID="Label2" runat="server" Text="Възможни действия, за профила с, който сте влезли:" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
                <br class="auto-style1" />
&nbsp;&nbsp;&nbsp;
                <br class="auto-style1" />
                <asp:Button ID="exit_btn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" Text="Изход от профила" OnClick="exit_btn_Click" />
                <br class="auto-style1" />
                &nbsp;&nbsp;
                <br class="auto-style1" />
                <br class="auto-style1" />
&nbsp;&nbsp;&nbsp;
                </p>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;<br />
            <br />
            <br />
&nbsp;&nbsp;<p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </center>
    </form>
    </body>
</html>
