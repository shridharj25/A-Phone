<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="APhoneFrontEnd2.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="height: 550px; width: 1105px">

    <h1 style="width: 282px; height: 53px; position:absolute; top: 50px; left: 365px;" class="auto-style1">Add Customer<br />
        </h1>
    <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 518px; top: 148px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 518px; top: 195px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 517px; top: 268px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 515px; top: 319px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 516px; top: 359px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtHouseNumber" runat="server" style="z-index: 1; left: 518px; top: 405px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 517px; top: 445px; position: absolute"></asp:TextBox>
        <br/> 


        
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 629px; top: 148px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblHouseNumber" runat="server" style="z-index: 1; left: 619px; top: 478px; position: absolute" Text="House Number"></asp:Label>

        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 622px; top: 517px; position: absolute" Text="PostCode"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 624px; top: 315px; position: absolute" Text="DOB"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 624px; top: 390px; position: absolute" Text="PhoneNo"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 621px; top: 431px; position: absolute" Text="Street Name"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 629px; top: 195px; position: absolute" Text="Surname"></asp:Label>

            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 375px; top: 524px; position: absolute; right: 917px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 466px; top: 525px; position: absolute" Text="Cancel" />

            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 467px; top: 575px; position: absolute"></asp:Label>

            </div>
</asp:Content>
