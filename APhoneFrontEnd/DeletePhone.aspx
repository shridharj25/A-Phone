<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="DeletePhone.aspx.cs" Inherits="APhoneFrontEnd.DeletePhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="height: 561px">
            <asp:Label ID="lblAreYouSure" runat="server" style="z-index: 1; position: absolute; top: 140px; left: 609px;" Text="Are you sure you want to delete this phone?"></asp:Label>

            <asp:Button ID="btnYes" runat="server" style="z-index: 1; position: absolute; left: 330px; top: 120px; width: 50px;" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; position: absolute; left: 400px; top: 120px; width: 50px;" Text="No" OnClick="btnNo_Click" />

        </div>
</asp:Content>
