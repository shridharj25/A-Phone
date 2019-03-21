<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="Tariff.aspx.cs" Inherits="APhoneFrontEnd2.Tariff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 558px">
    <asp:Button ID="btnSelect" runat="server" style="z-index: 1; left: 880px; top: 491px; position: absolute; width: 70px; "  Text="Select"  />
                   
       <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 115px; top: 491px; position: absolute; width: 65px"  Text="Cancel"  />
       

       <asp:ListBox ID="lstTariff" runat="server" Height="416px" Width="525px"></asp:ListBox>
       

        <asp:Button ID="btnAdd" runat="server" style=" position: absolute; top: 490px; left: 368px;" Text="Add" OnClick="btnAdd_Click" />
       

        </div>
</asp:Content>