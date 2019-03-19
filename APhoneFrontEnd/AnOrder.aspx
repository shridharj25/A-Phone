<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AnOrder.aspx.cs" Inherits="APhoneFrontEnd.AnOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">
        <h1 style="width: 282px; height: 53px; position:absolute; top: 49px; left: 462px;" class="auto-style1">Add Order<br />
        </h1>
        <br/> 


        
          
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 146px; top: 523px; position: absolute; width: 123px;" Text="Add" />
        <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; left: 143px; top: 180px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 260px; top: 219px; position: absolute; width: 81px; text-align: left; margin-top: 8px;" Text="Firstname"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 258px; top: 257px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Surname"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 143px; top: 218px; position: absolute; width: 220px"></asp:TextBox>
         <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 257px; top: 296px; position: absolute; width: 82px; text-align: left; margin-top: 8px;" Text="Phone Make"></asp:Label>
        <asp:TextBox ID="txtPhoneMake" runat="server" style="z-index: 1; left: 143px; top: 255px; position: absolute; width: 220px"></asp:TextBox>
         <asp:Label ID="lblPhoneModel" runat="server" style="z-index: 1; left: 257px; top: 338px; position: absolute; width: 90px; text-align: left; margin-top: 8px;" Text="Phone Model"></asp:Label>
        <asp:TextBox ID="txtPhoneModel" runat="server" style="z-index: 1; left: 143px; top: 295px; position: absolute; width: 220px"></asp:TextBox>
         <asp:Label ID="lblPhonePrice" runat="server" style="z-index: 1; left: 258px; top: 377px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Price"></asp:Label>
        <asp:Label ID="lblTariffID" runat="server" style="z-index: 1; left: 257px; top: 412px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="TariffID"></asp:Label>
         <asp:Button ID="btnShowTariffs" runat="server" style="z-index: 1; left: 403px; top: 375px; position: absolute" Text="Show Tariffs" />
  <asp:DropDownList ID="ddlTariffList" runat="server" style="z-index: 1; left: 145px; top: 364px; position: absolute">
        </asp:DropDownList>
                <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 144px; top: 421px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 266px; top: 456px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Order Date"></asp:Label>





        
            </div>
</asp:Content>
