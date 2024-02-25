<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="NewsApp_Client.News" MasterPageFile="~/User.Master"  %>

<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
    News App
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container my-3">
        <div class="d-flex justify-content-center">
            <asp:Panel ID="AllCategories" runat="server"></asp:Panel>
        </div>
        <hr />
    </div>
    <div class="container my-4">
        <asp:Panel ID="AllNews" runat="server"></asp:Panel>
    </div>
</asp:Content>
