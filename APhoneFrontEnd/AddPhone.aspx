<%@ Page Title="" Language="C#" MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AddPhone.aspx.cs" Inherits="APhoneFrontEnd.AddPhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 561px">

        <asp:Label ID="lblMake" runat="server" style="z-index: 1; position: absolute; top: 140px; left: 609px;" Text="Make:"></asp:Label>
        <asp:Label ID="LblModel" runat="server" style="z-index: 1; position: absolute; top: 180px; left: 609px;" Text="Model:"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 220px; left: 609px;" Text="PhoneNo:"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; position: absolute; top: 260px; left: 609px;" Text="Price:"></asp:Label>
        <asp:Label ID="lblScreenSize" runat="server" style="z-index: 1; position: absolute; top: 300px; left: 609px;" Text="Screen Size:"></asp:Label>
        <asp:Label ID="lblCameraQuality" runat="server" style="z-index: 1; position: absolute; top: 340px; left: 609px;" Text="Camera Quality:"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 390px; left: 609px;" Text=""></asp:Label>

        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; position: absolute; top: 92px; left: 445px;"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; position: absolute; top: 132px; left: 445px;"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 172px; left: 445px;"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; position: absolute; top: 212px; left: 445px;"></asp:TextBox>
        <asp:TextBox ID="txtScreenSize" runat="server" style="z-index: 1; position: absolute; top: 252px; left: 445px;"></asp:TextBox>
        <asp:TextBox ID="txtCameraQuality" runat="server" style="z-index: 1; position: absolute; top: 292px; left: 445px;"></asp:TextBox>

        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; position: absolute; left: 330px; top: 395px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; position: absolute; left: 380px; top: 395px;" Text="Cancel" OnClick="btnCancel_Click" />


    </div>
</asp:Content>
