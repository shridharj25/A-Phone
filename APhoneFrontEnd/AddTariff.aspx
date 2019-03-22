<%@ Page Title=""Language="C#"  MasterPageFile="~/APhone.Master" AutoEventWireup="true" CodeBehind="AddTariff.aspx.cs" Inherits="APhoneFrontEnd.AddTariff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 558px">
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 155px; top: 490px; position: absolute; width: 70px; "  Text="Add" OnClick="btnAdd_Click"  />
                   
       <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 333px; top: 488px; position: absolute; width: 65px"  Text="Cancel" OnClick="btnCancel_Click" />
        <%--<asp:Label ID="lblTariffID" runat="server"  style="z-index: 1; left: 372px; top: 145px; position: absolute; width: 87px" Text="Tariff ID:"></asp:Label>--%>
        <%--<asp:TextBox ID="txtTariffID" runat="server" style="z-index: 1; left: 223px; top: 92px; position: absolute"></asp:TextBox>--%>
        <asp:Label ID="lblTariffNetwork" runat="server"  style="z-index: 1; left: 370px; top: 363px; position: absolute; width: 79px; " Text="Tariff Network:"></asp:Label>

        <asp:TextBox ID="txtTariffNetwork" runat="server" style="z-index: 1; left: 225px; top: 319px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTariffCalls" runat="server"  style="z-index: 1; left: 380px; top: 234px; position: absolute; width: 70px; right: 835px;" Text="Tariff Calls:"></asp:Label>
        <asp:TextBox ID="txtTariffCalls" runat="server" style="z-index: 1; left: 226px; top: 181px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTariffTexts" runat="server"  style="z-index: 1; left: 377px; top: 272px; position: absolute; width: 69px; right: 839px;" Text="Tariff Texts:"></asp:Label>

        <asp:TextBox ID="txtTariffTexts" runat="server" style="z-index: 1; left: 225px; top: 230px; position: absolute"></asp:TextBox>
         <asp:Label ID="lblTariffData" runat="server"  style="z-index: 1; left: 375px; top: 331px; position: absolute; width: 70px; right: 840px;" Text="Tarrif Data:"></asp:Label>

        <asp:TextBox ID="txtTariffData" runat="server" style="z-index: 1; left: 225px; top: 278px; position: absolute"></asp:TextBox>
      
        <asp:Label ID="lblTariffPrice" runat="server"  style="z-index: 1; left: 368px; top: 429px; position: absolute; width: 79px" Text="Monthly Price:"></asp:Label>

        <asp:TextBox ID="txtTariffPrice" runat="server" style="z-index: 1; left: 228px; top: 388px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblTariffUpfront" runat="server"  style="z-index: 1; left: 372px; top: 190px; position: absolute; width: 87px" Text="Upfront Cost:"></asp:Label>
        <asp:TextBox ID="txtTariffUpfront" runat="server" style="z-index: 1; left: 226px; top: 139px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 268px; left: 756px; width: 151px;" Text=""></asp:Label>

        </div>
</asp:Content>