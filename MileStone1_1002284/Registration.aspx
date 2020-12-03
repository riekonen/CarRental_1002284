<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MileStone1_1002284.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />

    <asp:Label ID="lbl_userName" runat="server" Text="Enter a User Name"></asp:Label> <asp:TextBox ID="txt_userName" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_Password" runat="server" Text="Enter a Password"></asp:Label><asp:TextBox ID="txt_Password" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_confirmPassword" runat="server" Text="Confirm Password"></asp:Label><asp:TextBox ID="txt_confirmPassword" runat="server"></asp:TextBox>
    <asp:Button ID="btn_Register" runat="server" Text="Register" OnClick="btn_Register_Click" />
</asp:Content>
