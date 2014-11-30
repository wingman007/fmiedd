<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsCrudAccess._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="AuthenticatedMessagePanel">
        <asp:Label runat="server" ID="LBWelcomeBack"></asp:Label>
    </asp:Panel>
    
    <asp:Panel runat="Server" ID="AnonymousMessagePanel">
        <asp:HyperLink runat="server" ID="lnkLogin" Text="Вход" NavigateUrl="~/Login.aspx"></asp:HyperLink>
    </asp:Panel>

    <% if (!String.IsNullOrEmpty(Request.QueryString["ShowMessage"])) { %>
    <div class="alert alert-success" role="alert">Потребителят беше добавен успешно.</div>
     <%} %>

    <% if (!String.IsNullOrEmpty(Request.QueryString["ShowMessageUdapte"]))
       { %>
    <div class="alert alert-success" role="alert">Потребителят беше обновен успешно.</div>
     <%} %>

    <% if (!String.IsNullOrEmpty(Request.QueryString["ShowMessageDelete"]))
       { %>
    <div class="alert alert-success" role="alert">Потребителят беше изтрит успешно.</div>
     <%} %>
            
                      
            
     <asp:ListView ID="ListView1" runat="server"
            DataKeyNames="id" ItemType="WebFormsCrudAccess.Models.User"
            AutoGenerateColumns="false"
            AllowPaging="true" AllowSorting="true"
            SelectMethod="GetData">
            <EmptyDataTemplate>
              
            </EmptyDataTemplate>
            <LayoutTemplate>
                <div class="page-header">
                    <h1>Всички потребители</h1>
                </div>
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th>ИД</th>
                            <th>Потребител</th>
                            <th>Имейл</th>
                            <th>Парола</th>   
                            <th>Роля</th> 
                        </tr>
                    </thead>
                    <tbody>
                        <tr runat="server" id="itemPlaceholder" />
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:DynamicControl runat="server" DataField="id" ID="id" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="username" ID="username" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="email" ID="email" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="password" ID="pass" Mode="ReadOnly" />
                    </td> 
                     <td>
                       <asp:DynamicControl runat="server" DataField="role" ID="DynamicControl1" Mode="ReadOnly" />
                    </td>
                    
                     <% if ((string)(Session["Role"]) == "администратор")
                     { %>
                        <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Microsoft.AspNet.FriendlyUrls.FriendlyUrl.Href("~/Edit?id="+Item.Id) %>' Text="<i class='glyphicon glyphicon-edit'></i> Редактирай " /> /
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Microsoft.AspNet.FriendlyUrls.FriendlyUrl.Href("~/Delete?id="+Item.Id) %>' Text="Изтрии <i class='glyphicon glyphicon-remove-circle'></i> " />                                                                    
                    </td>
                    <%}
                      else
                       { %>
                           <td><td>
                       <% 
                       }
                       %>                                      
                   
                </tr>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>
