<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="MileStone1_1002284.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="container-fluid">
        <div class="row">
             <div class="col-sm-12 col-md-5">

             <h1>Shopping Cart</h1>
             
             </div>
        </div>
        <div class="row">
             <div class="col-sm-12 col-md-7">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" CssClass="myDataGrid" CellPadding="2" CellSpacing="2" Width="80%">       
                        <Columns>    
                             <asp:boundfield datafield="cCar.car_ID" headertext="Model ID"/>
                             <asp:boundfield datafield="cCar.car_Name" headertext="Car"/>
                             <asp:boundfield datafield="cCar.category" headertext="Category"/>
                             <asp:boundfield datafield="rDays" headertext="Days Rented"/>
                             <asp:boundfield datafield="sTotal" headertext="Sub Total"/>
                             <asp:TemplateField headertext="Remove">
                                 <ItemTemplate>
                                     <asp:CheckBox ID="delChkBx" runat="server" AutoPostBack="false"/>
                                 </ItemTemplate>
                             </asp:TemplateField>
                        </Columns>
                     <HeaderStyle CssClass="header" BackColor="#646464" Height="25px" ForeColor="White" BorderStyle="None" Font-Size="16px" />

                  </asp:GridView> 
                 <br/>
                 <asp:Button ID="btn_RemoveItem" runat="server" Text="Remove Item"  OnClick="btn_RemoveItem_Click" />
             </div>
            <div class="col-sm-12 col-md-5">
                <h3>Grand Total</h3>
                <asp:Label ID="lbl_GrandTotal" runat="server" Text="Grand Total: "></asp:Label>
                <asp:TextBox ID="tb_GrandTotal" ReadOnly="true" runat="server"></asp:TextBox>
                                
            </div>
        </div>

      
        
       
    </div>
</asp:Content>
