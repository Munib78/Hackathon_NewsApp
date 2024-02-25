<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCategory.aspx.cs" Inherits="NewsApp_Client.admin.DeleteCategory" MasterPageFile="~/admin/Admin.Master"%>

<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
    Delete Category - News App
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">Delete category</h3>
        <hr class="text-primary" />
        <h5 class="my-3">Are you sure ?</h5>
        <asp:Label ID="ConfirmMsg" runat="server" CssClass="my-2" Text=""></asp:Label>
        <div class="d-flex align-items-center my-3">
            <asp:Button ID="Delete" runat="server" Text="Yes" CssClass="btn btn-danger me-3" OnClick="Delete_Click"/>
            <a runat="server" href="CategoryList.aspx" class="btn btn-primary">No</a>
        </div>
    </div>
        
</asp:Content>

