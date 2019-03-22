<%@ Page Title="" MasterPageFile="~/APhone.Master" Language="C#" AutoEventWireup="true" CodeBehind="Tariff.aspx.cs" Inherits="APhoneFrontEnd.Tariff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 558px">
    <asp:Button ID="btnSelect" runat="server" style="z-index: 1; left: 880px; top: 491px; position: absolute; width: 70px; "  Text="Select"  />
                   
       <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 115px; top: 491px; position: absolute; width: 65px"  Text="Cancel"  />
       

        <asp:Label ID="lblFilter" runat="server" style=" position: absolute; top: 198px; left: 310px;" Text="Filter By Network?"></asp:Label>
       

        <asp:TextBox ID="txtFilter" runat="server" style=" position: absolute; top: 187px; left: 57px;"></asp:TextBox>
       

        <asp:Button ID="btnApply" runat="server" style=" position: absolute; top: 230px; left: 74px;" Text="Apply FIlter" OnClick="btnApply_Click" />

       <asp:Button ID="btnReset" runat="server" style=" position: absolute; top: 276px; left: 75px;" Text="Reset FIlter" OnClick="btnReset_Click" />

       <asp:ListBox ID="lstTariff" runat="server" Height="416px" Width="525px"></asp:ListBox>
       

        <asp:Button ID="btnAdd" runat="server" style=" position: absolute; top: 490px; left: 368px;" Text="Add" OnClick="btnAdd_Click" />
       

        <asp:Button ID="btnDelete" runat="server" style=" position: absolute; top: 490px; left: 544px;" Text="Delete" OnClick="btnDelete_Click" />
       

        <asp:Label ID="lblError" runat="server" style=" position: absolute; top: 495px; left: 595px;" Text="lblError"></asp:Label>
       

        <asp:Button ID="btnEdit" runat="server" style=" position: absolute; top: 490px; left: 460px;" Text="Edit" OnClick="btnEdit_Click" />
       

        </div>
</asp:Content>