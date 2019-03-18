<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="APhoneFrontEnd.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="height: 550px">


        <h1 style="width: 282px; height: 53px; position:absolute; top: 49px; left: 462px;" class="auto-style1">Add Customer<br />
        </h1>
        <br/> 

        
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 397px; top: 217px; position: absolute; margin-bottom: 0px; bottom: -238px;" Text="Surname"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 398px; top: 259px; position: absolute" Text="DOB"></asp:Label>

        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 393px; top: 335px; position: absolute" Text="Street Name"></asp:Label>
        <asp:Label ID="lblHouseNumber" runat="server" style="z-index: 1; left: 395px; top: 373px; position: absolute" Text="House Number"></asp:Label>

        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 398px; top: 412px; position: absolute" Text="PostCode"></asp:Label>

        
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 616px; top: 210px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 618px; top: 168px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 616px; top: 248px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 614px; top: 286px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 616px; top: 324px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNumber" runat="server" style="z-index: 1; left: 616px; top: 364px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 618px; top: 405px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 403px; top: 530px; position: absolute; width: 70px; right: 787px" Text="Save" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 796px; top: 531px; position: absolute; width: 69px" Text="Back" OnClick="btnBack_Click" />
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 397px; top: 183px; position: absolute" Text="FirstName"></asp:Label>
            <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 398px; top: 297px; position: absolute" Text="PhoneNo"></asp:Label>
            </div>

</asp:Content>
