<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="UpdateCustomerDetails.aspx.cs" Inherits="APhoneFrontEnd2.UpdateCustomerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div style="height: 486px">
        

        <h1 style="width: 332px; height: 53px; position:absolute; top: 40px; left: 464px;" class="auto-style1">Edit Customer Details<br />
        </h1>
        <br/> 

        
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 399px; top: 222px; position: absolute" Text="DOB"></asp:Label>

        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 391px; top: 256px; position: absolute" Text="PhoneNo"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 388px; top: 298px; position: absolute" Text="Street Name"></asp:Label>
        <asp:Label ID="lblHouseNumber" runat="server" style="z-index: 1; left: 384px; top: 335px; position: absolute" Text="House Number"></asp:Label>

        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 386px; top: 371px; position: absolute" Text="PostCode"></asp:Label>

        
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 621px; top: 168px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 621px; top: 131px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 621px; top: 207px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 619px; top: 246px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 619px; top: 283px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNumber" runat="server" style="z-index: 1; left: 618px; top: 322px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 617px; top: 362px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 433px; top: 417px; position: absolute; width: 33px;" Text="OK" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 720px; top: 421px; position: absolute; width: 60px;" Text="Back" />

           <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 398px; top: 183px; position: absolute" Text="Surname"></asp:Label>
           <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 396px; top: 143px; position: absolute" Text="First Name"></asp:Label>

           <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 374px; top: 476px; position: absolute"></asp:Label>

        </div>
</asp:Content>