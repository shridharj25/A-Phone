<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="APhoneFrontEnd2.DeleteCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 564px">

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 688px; top: 284px; position: absolute" Text="Are you sure you want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 430px; top: 266px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 479px; top: 266px; position: absolute" Text="No" />

    </div>
</asp:Content>
