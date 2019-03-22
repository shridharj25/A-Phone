<%@ Page Title="" MasterPageFile="~/APhone.Master" Language="C#" AutoEventWireup="true" CodeBehind="DeleteTariff.aspx.cs" Inherits="APhoneFrontEnd.DeleteTariff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 558px">
    <asp:Button ID="btnAccept" runat="server" style="z-index: 1; left: 524px; top: 258px; position: absolute; width: 70px; "  Text="Accept" OnClick="btnAccept_Click"  />
                   
       <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 329px; top: 257px; position: absolute; width: 65px"  Text="Cancel" OnClick="btnCancel_Click"  />
        <asp:Label ID="lblDeleteTariff" runat="server"  style="z-index: 1; left: 436px; top: 269px; position: absolute; width: 614px" Text="Are You Sure You Want To Delete This Tariff???:"></asp:Label>

        </div>
</asp:Content>