<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="MileStone1_1002284.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    
    <br />
    <div class="container-fluid">
        <h2>Admin Panel</h2>
        <h4>Register a new Car</h4>

    </div>

    <div class="container-fluid">

        
        <div class="row">

            <div class="col-7">

                <div class="row">
                    <div class="col-2">
                         <asp:Label ID="lbl_CarName" runat="server" Text="Car Name:"></asp:Label>
                    </div>
                    <div class="col-10">
                         <asp:TextBox ID="txt_CarName" runat="server"></asp:TextBox>
                         
                    </div>
                </div>

                <div class="row">
                    <div class="col-2">
                         <asp:Label ID="lbl_CarID" runat="server" Text="Car ID:"></asp:Label>
                    </div>
                    <div class="col-10">
                         <asp:TextBox ID="txt_CarID" runat="server"></asp:TextBox>
                                       </div>
                </div>

                <div class="row">
                    <div class="col-2">
                         <asp:Label ID="lbl_Description" runat="server" Text="Description:"></asp:Label>
                    </div>
                    <div class="col-10">
                         <asp:TextBox ID="txt_Description" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-2">
                         <asp:Label ID="lbl_ImageUrl" runat="server" Text="Image:"></asp:Label>
                    </div>
                    <div class="col-8">
                         <asp:TextBox ID="txt_ImageUrl" runat="server" Enabled="false"></asp:TextBox>
                        <asp:FileUpload ID="fileUpload" runat="server"/>
                                </div>
                    <div class="col-2">
                        
                        <asp:Button ID="btn_SelectImage" runat="server" Text="Select Image" OnClick="btn_SelectImage_Click" />
                    </div>
                </div>

                 <div class="row">
                    <div class="col-2">
                         <asp:Label ID="lbl_Category" runat="server" Text="Category:"></asp:Label>
                    </div>
                    <div class="col-10">
                         <asp:DropDownList ID="ddl_Category" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <br />              
               
               

                <asp:Button ID="btn_AddCar" runat="server" Text="Add Car" OnClick="btn_AddCar_Click" />
            </div>

            <div class="col-5">
                <asp:Label ID="lbl_SelectCar" runat="server" Text="Select Car:"></asp:Label>
                <asp:DropDownList ID="ddl_Cars" runat="server"></asp:DropDownList>
                <asp:Button ID="btn_DeleteCar" runat="server" Text="Delete" OnClick="btn_DeleteCar_Click" />
                <asp:Button ID="btn_LoadCar" runat="server" Text="Update" OnClick="btn_LoadCar_Click" />
            </div>
        </div>
        <div class="row">
             <div class="col-2">
                 
                 
             </div>

        </div>




    </div>




</asp:Content>
