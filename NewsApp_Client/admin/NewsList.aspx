<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="NewsApp_Client.admin.NewsList" MasterPageFile="~/admin/Admin.Master"%>


<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
    News List - News App
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">News list</h3>
        <hr class="text-primary" />
        <a runat="server" href="AddOrEditNews.aspx" class="btn btn-primary my-2">Add News</a>
        <table class="table my-2">
            <thead>
                <tr>
                    <th>#</th>
                    <th width="350px">TITLE</th>
                    <th>SOURCE</th>
                    <th>AUTHOR</th>
                    <th>PUBLISHED ON</th>
                    <th>CATEGORY</th>
                    <th>ACTIONS</th>
                </tr>
            </thead>
            <tbody>
                <asp:PlaceHolder ID="ListOfNews" runat="server"></asp:PlaceHolder>
            </tbody>
        </table>
    </div>
</asp:Content>

