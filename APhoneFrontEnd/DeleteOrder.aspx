<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="DeleteOrder.aspx.cs" Inherits="APhoneFrontEnd.DeleteOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">
       
       <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this Order?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" height="26px" style="z-index: 1;" Text="No" width="59px" OnClick="btnNo_Click" />
        <br/> 


        
          
        





        
            </div>
</asp:Content>
