<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOrEditNews.aspx.cs" Inherits="NewsApp_Client.admin.AddOrEditNews" MasterPageFile="~/admin/Admin.Master"%>

<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
   Add/Edit News - News App
</asp:Content>

<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">Add news</h3>
        <hr class="text-primary" />
        <table class="table table-borderless my-3">
            <tr>
                <td style="width: 170px">Title</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="NTitle" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="TitleRequired" runat="server" ControlToValidate="NTitle" ErrorMessage="Title is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Source</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Source" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="SourceRequired" runat="server" ControlToValidate="Source" ErrorMessage="Source name is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Author</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Author" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="AuthorRequired" runat="server" ControlToValidate="Author" ErrorMessage="Author name is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Description</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Description" runat="server" TextMode="MultiLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DescriptionRequired" runat="server" ControlToValidate="Description" ErrorMessage="Description is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Url to news</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Url" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UrlRequired" runat="server" ControlToValidate="Url" ErrorMessage="Url is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Url to image</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="UrlToImage" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UrlToImageRequired" runat="server" ControlToValidate="UrlToImage" ErrorMessage="Url to image is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Select category</td>
                <td>
                    <asp:DropDownList ID="Category" runat="server" CssClass="form-select w-50"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button" runat="server" CssClass="btn btn-primary" Text="Add" OnClick="Button_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

