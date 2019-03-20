<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="APhoneFrontEnd.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">

        <br/> 
        
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 95px; top: 488px; position: absolute; width: 95px;" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 228px; top: 488px; position: absolute; width: 93px;" Text="Display All" />
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 95px; top: 440px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 345px; top: 456px; position: absolute; width: 221px; text-align: left" Text="Please Enter a Surname"></asp:Label>


        
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; top: 117px; position: absolute; height: 234px; width: 288px; left: 60px"></asp:ListBox>


        
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 32px; top: 533px; position: absolute; width: 93px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 160px; top: 533px; position: absolute; width: 93px;" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 288px; top: 533px; position: absolute; width: 93px;" Text="Delete" />


        
      </div>
</asp:Content>
