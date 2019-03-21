<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="APhoneFrontEnd2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="height: 561px">
        <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 384px; top: 457px; position: absolute; width: 221px; text-align: left" Text="Please Enter A Phone Make"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 616px; top: 417px; position: absolute; text-align: left" Text=""></asp:Label>


        <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 94px; top: 159px; position: absolute; height: 232px; width: 220px"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 94px; top: 476px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 235px; top: 476px; position: absolute" Text="Display All" />
        <asp:TextBox ID="txtPhoneMake" runat="server" style="z-index: 1; left: 95px; top: 440px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 94px; top: 516px; position: absolute; width: 49px;" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 154px; top: 516px; position: absolute; width: 49px;" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 214px; top: 516px; position: absolute; width: 54px;" Text="Delete" OnClick="btnDelete_Click" />


        </div>
</asp:Content>
