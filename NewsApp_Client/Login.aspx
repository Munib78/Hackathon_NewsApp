<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewsApp_Client.Login" MasterPageFile="~/User.Master"  %>

<asp:Content ID="title" ContentPlaceHolderID="Title" runat="server">

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="Body" runat="server">
    <div class="container">
        <h3 class="my-3">Login to continue</h3>
        <hr class="text-primary" />
        <table class="table table-borderless my-3">
            <tr>
                <td style="width: 170px"></td>
                <td class="d-flex align-items-center" >
                    <asp:Label ID="LoginError" runat="server" ForeColor="#FF3300" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Email" runat="server" TextMode="SingleLine" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="Email is required is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td class="d-flex align-items-center" >
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control w-50 me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <th>&nbsp;</th>
                <td>
                    <asp:Button ID="LoginBtn" runat="server" CssClass="btn btn-primary" Text="Login" OnClick="Login_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
