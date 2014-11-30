<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsCrudAccess.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Height="40px" Text="Добре дошли!"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Height="20px" Text="Потребител: " Width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="tbuser" runat="server" Height="20px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Height="20px" Text="Парола:" Width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="tbpass" runat="server" Height="20px" TextMode="Password"></asp:TextBox>
    </p>
<p>
        <asp:CheckBox ID="cbRememberMe" runat="server" Font-Bold="False" Text="Запомни ме" />
    </p>
<p>
        <asp:Label ID="lbError" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="Red" Height="20px" Text="Грешно потребителско име или парола. Моля опитайте отново." Visible="False"></asp:Label>
    </p>
    <p style="margin-left: 120px">
        <asp:Button ID="btnok" runat="server" Font-Bold="True" Text="Вход" Width="63px" OnClick="btnok_Click" />
&nbsp;&nbsp;&nbsp;
    </p>

</asp:Content>
