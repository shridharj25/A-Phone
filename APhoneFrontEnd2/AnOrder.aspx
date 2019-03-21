<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AnOrder.aspx.cs" Inherits="APhoneFrontEnd2.AnOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">
        <h1 style="width: 282px; height: 53px; position:absolute; top: 49px; left: 462px;" class="auto-style1">Add Order<br />
        </h1>
        <br/> 


        
          
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 146px; top: 523px; position: absolute; width: 123px;" Text="Add" />
        
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 260px; top: 219px; position: absolute; width: 81px; text-align: left; margin-top: 8px;" Text="Firstname"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 258px; top: 257px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Surname"></asp:Label>
         <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 257px; top: 296px; position: absolute; width: 82px; text-align: left; margin-top: 8px;" Text="Phone Make"></asp:Label>
         <asp:Label ID="lblPhoneModel" runat="server" style="z-index: 1; left: 257px; top: 338px; position: absolute; width: 90px; text-align: left; margin-top: 8px;" Text="Phone Model"></asp:Label>
         <asp:Label ID="lblPhonePrice" runat="server" style="z-index: 1; left: 258px; top: 377px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Price"></asp:Label>
        <asp:Label ID="lblTariffID" runat="server" style="z-index: 1; left: 257px; top: 410px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="TariffID"></asp:Label>
        
  <asp:DropDownList ID="ddlTariffList" runat="server" style="z-index: 1; left: 145px; top: 364px; position: absolute">
        </asp:DropDownList>
                <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 144px; top: 421px; position: absolute; width: 220px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 143px; top: 335px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 266px; top: 456px; position: absolute; width: 61px; text-align: left; margin-top: 8px;" Text="Order Date"></asp:Label>

         <asp:DropDownList ID="ddlFirstName" runat="server" style="z-index: 1; left: 143px; top: 177px; width: 100px; position: absolute"></asp:DropDownList>
         <asp:DropDownList ID="ddlSurname" runat="server" style="z-index: 1; left: 143px; top: 218px; width: 100px; position: absolute"></asp:DropDownList>
         <asp:DropDownList ID="ddlPhoneMake" runat="server" style="z-index: 1; left: 143px; top: 255px; width: 100px; position: absolute"></asp:DropDownList>
         <asp:DropDownList ID="ddlPhoneModel" runat="server" style="z-index: 1; left: 143px; top: 295px; width: 100px; position: absolute"></asp:DropDownList>
         <asp:DropDownList ID="ddlShowTariffs" runat="server" style="z-index: 1; left: 143px; top: 364px; width: 100px; position: absolute"></asp:DropDownList>





        
            </div>
</asp:Content>