<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOrEditCategory.aspx.cs" Inherits="NewsApp_Client.admin.AddOrEditCategory"  MasterPageFile="~/admin/Admin.Master"%>


<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">
    Add/Edit Category - News App
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">Add category</h3>
        <hr class="text-primary" />
        <table class="table table-borderless my-3">
            <tr>
                <td style="width: 170px">Category</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="CategoryName" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="CategoryRequired" runat="server" ControlToValidate="CategoryName" ErrorMessage="Category name is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <th>&nbsp;</th>
                <td>
                    <asp:Button ID="Button" runat="server" CssClass="btn btn-primary" Text="Add" OnClick="Button_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

