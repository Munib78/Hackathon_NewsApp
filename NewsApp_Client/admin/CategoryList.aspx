<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="NewsApp_Client.admin.CategoryList" MasterPageFile="~/admin/Admin.Master"%>


<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
    Category List - News App
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">Category list</h3>
        <hr class="text-primary" />
        <a runat="server" href="AddOrEditCategory.aspx" class="btn btn-primary my-2">Add Category</a>
        <table class="table my-2">
            <thead>
                <tr>
                    <th width="100px" scope="col">#</th>
                    <th width="450px" scope="col">CATEGORY</th>
                    <th scope="col">ACTIONS</th>
                </tr>
            </thead>
            <tbody>
                <asp:PlaceHolder ID="ListOfCategoeies" runat="server"></asp:PlaceHolder>
            </tbody>
        </table>
    </div>
</asp:Content>
