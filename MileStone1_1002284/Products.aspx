<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="MileStone1_1002284.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">

      /*  window.onbeforeunload = function (e) {
            PageMethods.SaveData(onSucess, onError);
            function onSucess() {
                alert("workin");
            }
            function onError() {
                alert("not workin");
            }
        }*/

        $(document).ready(function e () {
            $("input[id*=txtDatePicker]").datepicker(
                {
                    showOn: "button",
                    buttonImage: "images/calender.png",
                    buttonImageOnly: true,
                    buttonText: "Select",
                    dateFormat: 'dd / mm / yy',
                    changeMonth: true,
                    changeYear: true,
                    yearRange: '2020:2100'

                });
        });

        jQuery('.imgButton').datepicker();


    </script>

    <br />
   
     

    <asp:ListView ID="ProductsList" runat="server" DataKeyNames="CarID" ItemType="MileStone1_1002284.Models.Car" ClientIDMode="Predictable" ClientIDRowSuffix="CarID">
        <LayoutTemplate>
            <div runat="server" id="itemPlaceholder" class="container-fluid" >

            </div>

        </LayoutTemplate>
        
        <ItemTemplate>
            
            <div class="row abtContentDiv">
            <div class="col-sm-12 col-md-4">
               
                <img class="img-fluid" runat="server" src='<%# "images/"+Item.imageUrl %>' />
            </div>
            <div class="col-sm-12 col-md-8 bgTheme">
                <div class="row">
                    <div class="col-3 displayText">
                        <div class="row">
                           <h3> <asp:Label ID="lbl_Category"  runat="server" Text='<%# ""+Item.Category %>'></asp:Label></h3>
                        </div>
                        <div class="row">
                          <h5>  <asp:Label ID="lbl_CarName"  runat="server" Text='<%# ""+Item.CarName %>'></asp:Label></h5>
                        </div>
                         <div class="row">
                            <h6><asp:Label ID="lbl_CarID"  runat="server" Text='<%# ""+Item.CarID %>'></asp:Label></h6>
                         </div>
                    </div>

                    <div class="col-3">
                        <div class="cardPricing">
                              <asp:Label ID="lbl_Price" runat="server" Text='<%# "From $"+Item.Price.UnitPrice+" JMD/day" %>' ></asp:Label>
                        </div>                    
                    </div>

                    <div class="col-2">
                        <div class="row">
                            <asp:Label ID="lbl_SelectStartDate" runat="server" Text="Start Date"></asp:Label>
                        </div>
                        <div class="row">
                            <div class="col-2">
                                <asp:Button Enabled="false" ID="btn_Calender1" runat="server" Text="Select"  CommandArgument='<%# ""+Item.CarID %>' OnClick="calenderBtn_clicked" />
                            </div>
                            <div class="col-10">
                                <asp:Calendar ID="calender1" runat="server" Visible="false" OnSelectionChanged="Selection_changed" SelectionMode="Day"  OnDayRender="Calender1_DayRender"></asp:Calendar>
                            </div>
                        </div>
                    </div>

                    <div class="col-2">
                        <div class="row">
                            <asp:Label ID="lbl_SelectEndDate" runat="server" Text="End Date"></asp:Label>
                        </div>
                        <div class="row">
                            <div class="col-2">
                                <asp:Button Enabled="false" ID="btn_Calender2" runat="server" Text="Select"  CommandArgument='<%# ""+Item.CarID %>' OnClick="calenderBtn_clicked"  />
                            </div>
                            <div class="col-10">
                                <asp:Calendar ID="calendar2" runat="server" Visible="false" OnSelectionChanged="Selection2_changed" SelectionMode="Day"  OnDayRender="Calender2_DayRender"></asp:Calendar>
                            </div>
                        </div>
                    </div>



                    <div class="col-2">
                        <div class="row">
                           <asp:Button ID="btn_AddCart" runat="server" CommandArgument='<%# ""+Item.CarID %>' OnClick="btn_AddCart_Click" Text="Add to Cart"/>
                        </div> 
                        <div class="row">
                         <asp:Label ID="lbl_AddedCart" runat="server" Text="Added to Cart" BackColor="Green" Visible="false"></asp:Label>    
                        </div>
                    </div>


                </div>

                <div class="row paragraphText nPadding bg-dark">

                    <p><asp:Label ID="lbl_Description" runat="server" Text='<%# ""+Item.Description %>'></asp:Label></p>
                </div>

            </div>
        </div>




        </ItemTemplate>        


    </asp:ListView>



</asp:Content>
