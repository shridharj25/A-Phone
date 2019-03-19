<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="APhoneFrontEnd.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">

        <br/> 


        
            <asp:ListBox ID="lstOrders" runat="server" style="z-index: 1; left: 97px; top: 159px; position: absolute; height: 232px; width: 220px"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 94px; top: 476px; position: absolute" Text="Apply" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 156px; top: 477px; position: absolute" Text="Add" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 235px; top: 478px; position: absolute" Text="Display All" />
        <asp:TextBox ID="txtOrderMadeBy" runat="server" style="z-index: 1; left: 95px; top: 435px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblOrderMadeBy" runat="server" style="z-index: 1; left: 345px; top: 448px; position: absolute; width: 221px; text-align: left; margin-top: 8px;" Text="Please Enter Name  "></asp:Label>


        
            </div>
</asp:Content>
