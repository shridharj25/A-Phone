<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="EditTariff.aspx.cs" Inherits="APhoneFrontEnd2.EditTariff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 558px">
    <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 880px; top: 491px; position: absolute; width: 70px; "  Text="Save"  />
                   
       <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 115px; top: 491px; position: absolute; width: 65px"  Text="Cancel" OnClick="btnCancel_Click"  />
        <asp:Label ID="lblTariffID" runat="server"  style="z-index: 1; left: 283px; top: 300px; position: absolute; width: 87px" Text="Tariff ID:"></asp:Label>
        <asp:TextBox ID="txtTariffID" runat="server" style="z-index: 1; left: 7px; top: 277px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTariffNetwork" runat="server"  style="z-index: 1; left: 427px; top: 283px; position: absolute; width: 79px; " Text="Tariff Network:"></asp:Label>

        <asp:TextBox ID="txtTariffNetwork" runat="server" style="z-index: 1; left: 147px; top: 277px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTariffCalls" runat="server"  style="z-index: 1; left: 563px; top: 302px; position: absolute; width: 70px; right: 652px;" Text="Tariff Calls:"></asp:Label>
        <asp:TextBox ID="txtTariffCalls" runat="server" style="z-index: 1; left: 286px; top: 276px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTariffTexts" runat="server"  style="z-index: 1; left: 702px; top: 280px; position: absolute; width: 69px; right: 514px;" Text="Tariff Texts:"></asp:Label>

        <asp:TextBox ID="txtTariffTexts" runat="server" style="z-index: 1; left: 427px; top: 276px; position: absolute"></asp:TextBox>
         <asp:Label ID="lblTariffData" runat="server"  style="z-index: 1; left: 850px; top: 299px; position: absolute; width: 70px; right: 365px;" Text="Tariff Data:"></asp:Label>

        <asp:TextBox ID="txtTariffData" runat="server" style="z-index: 1; left: 569px; top: 275px; position: absolute"></asp:TextBox>
      
        <asp:TextBox ID="txtTariffPrice" runat="server" style="z-index: 1; left: 710px; top: 272px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:Label ID="LblTariffUpfront" runat="server"  style="z-index: 1; left: 874px; top: 247px; position: absolute; width: 87px; height: 19px;" Text="Upfront Cost:"></asp:Label>
        <asp:TextBox ID="txtTariffUpfront" runat="server" style="z-index: 1; left: 855px; top: 274px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblTariffPrice" runat="server"  style="z-index: 1; left: 984px; top: 278px; position: absolute; width: 79px" Text="Monthly Price:"></asp:Label>

        

        </div>
</asp:Content>
