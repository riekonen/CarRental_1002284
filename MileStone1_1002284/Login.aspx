<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MileStone1_1002284.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <br />
     <br />
    <div class="container-fluid">
        <h2>Login</h2>
        <h4>Enter your credentials</h4>

    </div>
    <asp:Label ID="lbl_UserName" runat="server" Text="User Name"></asp:Label> <asp:TextBox ID="txt_UserName" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label><asp:TextBox ID="txt_Password" runat="server" TextMode="Password"></asp:TextBox>

    <asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click" />


    <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
            <p>
               <asp:Literal runat="server" ID="StatusText" />
            </p>
         </asp:PlaceHolder>

    <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="false">
            <div>
               <div>
                  <asp:Button runat="server" OnClick="SignOut" Text="Log out" />
               </div>
            </div>
         </asp:PlaceHolder>
   







</asp:Content>
