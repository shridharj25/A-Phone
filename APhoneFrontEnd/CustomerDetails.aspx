<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="APhoneFrontEnd.CustomerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px; width: 1105px">

    <h1 style="width: 282px; height: 53px; position:absolute; top: 50px; left: 365px;" class="auto-style1">Customer Details<br />
        </h1>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 519px; top: 178px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 518px; top: 225px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 517px; top: 268px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 515px; top: 319px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 516px; top: 359px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtHouseNumber" runat="server" style="z-index: 1; left: 518px; top: 405px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 517px; top: 445px; position: absolute"></asp:TextBox>
        <br/> 


        
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 621px; top: 228px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 619px; top: 478px; position: absolute" Text="House Number"></asp:Label>

        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 622px; top: 517px; position: absolute" Text="PostCode"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 628px; top: 340px; position: absolute" Text="DOB"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 624px; top: 390px; position: absolute" Text="PhoneNo"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 621px; top: 431px; position: absolute" Text="Street Name"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 622px; top: 295px; position: absolute" Text="Surname"></asp:Label>

            <asp:Button ID="btnPrevious" runat="server" style="z-index: 1; left: 266px; top: 519px; position: absolute" Text="Previous" />

            <asp:Button ID="btnNext" runat="server" style="z-index: 1; left: 722px; top: 518px; position: absolute" Text="Next" />
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 715px; top: 265px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
    <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 720px; top: 358px; position: absolute" Text="Delete" />
    <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 718px; top: 316px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />

            </div>
</asp:Content>
