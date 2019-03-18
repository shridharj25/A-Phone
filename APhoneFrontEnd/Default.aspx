<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="APhoneFrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="height: 561px">
                <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 94px; top: 159px; position: absolute; height: 232px; width: 220px"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 94px; top: 476px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 235px; top: 478px; position: absolute" Text="Display All" />
        <asp:TextBox ID="txtPhoneMake" runat="server" style="z-index: 1; left: 95px; top: 440px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 345px; top: 456px; position: absolute; width: 221px; text-align: left" Text="Please Enter A Phone Make"></asp:Label>

        </div>

</asp:Content>
