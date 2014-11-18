<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body
        {
            font-family: Candara; font-size: 14px; border: none;
        }

        a {
            text-decoration: none;
            color: green;
        }
        table td, th {
            margin: 5px;
        }
    </style>
</head>
    
<body ">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PersonID" DataSourceID="SqlDataSource3" ShowFooter="True" AllowSorting="True" Width="603px" Height="72px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="PersonID" HeaderText="PersonID" ReadOnly="True" SortExpression="PersonID" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:usersConnectionString %>" DeleteCommand="DELETE FROM [Persons] WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))" InsertCommand="INSERT INTO [Persons] ([PersonID], [LastName], [FirstName], [City]) VALUES (@PersonID, @LastName, @FirstName, @City)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Persons]" UpdateCommand="UPDATE [Persons] SET [LastName] = @LastName, [FirstName] = @FirstName, [City] = @City WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="PersonID" Type="Int32" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:usersConnectionString %>" DeleteCommand="DELETE FROM [Persons] WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))" InsertCommand="INSERT INTO [Persons] ([PersonID], [LastName], [FirstName], [City]) VALUES (@PersonID, @LastName, @FirstName, @City)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Persons]" UpdateCommand="UPDATE [Persons] SET [LastName] = @LastName, [FirstName] = @FirstName, [City] = @City WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="PersonID" Type="Int32" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:ValidationSummary ValidationGroup="INSERT" ID="ValidationSummary1" ForeColor="Red" runat="server" />
        <asp:ValidationSummary ID="ValidationSummary2" ForeColor="Red" runat="server" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            ConnectionString="<%$ ConnectionStrings:usersConnectionString %>" 
            DeleteCommand="DELETE FROM [Persons] WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))" 
            InsertCommand="INSERT INTO [Persons] ([PersonID], [LastName], [FirstName], [City]) VALUES (@PersonID, @LastName, @FirstName, @City)" 
            SelectCommand="SELECT * FROM [Persons]" 
            UpdateCommand="UPDATE [Persons] SET [LastName] = @LastName, [FirstName] = @FirstName, [City] = @City WHERE [PersonID] = @original_PersonID AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([City] = @original_City) OR ([City] IS NULL AND @original_City IS NULL))" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="PersonID" Type="Int32" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="original_PersonID" Type="Int32" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_City" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>