<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="MileStone1_1002284.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <div class="container-fluid">
         
         <%--First Row--%>
         
        <div class="row abtContentDiv">
            <div class="col-sm-12 col-md-5">
                <img class="img-fluid" src="images/hondacivic.png" />
            </div>
            <div class="col-sm-12 col-md-7 bgTheme">
                <div class="row">
                    <div class="col-4 displayText">
                        <h1>Luxury</h1>
                        <h3>Honda Civic</h3>                   
                        <h6>LXHC01</h6>
                    </div>

                    <div class="col-3">
                        <div class="cardPricing">
                             <p> $10,000 JMD/day</p>
                        </div>                    
                    </div>

                    <div class="col-2">
                        <div class="row">
                            <asp:Label ID="lbl_RentFor01" runat="server" Text="Rent For"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:DropDownList ID="ddl_DaysRented01" runat="server"></asp:DropDownList>
                        </div>
                        <div class="row">
                            <asp:Label ID="lbl_Days01" runat="server" Text="Day/s"></asp:Label>

                        </div>
                    </div>

                    <div class="col-3">
                        <div class="row">
                           <asp:Button ID="btn_AddCart01" runat="server" OnClick="btn_AddCart01_Click" Text="Add to Cart"/>
                        </div> 
                        <div class="row">
                         <asp:Label ID="lbl_AddedCart01" runat="server" Text="Added to Cart" BackColor="Green" Visible="false"></asp:Label>    
                        </div>
                    </div>


                </div>

                <div class="row paragraphText nPadding bg-dark">

                 <p>The 2019 Honda Civic is a luxurious machine offering style, comfort and grace. 
                    It boasts a clean, spacious interior, comfortably seating 3 passengers. It comes with 
                     a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among 
                     other awesome specs. Pulling up n this sweet ride will definitely turn heads. Contact Us for more Details.
                </p>
                </div>

            </div>
        </div>

           <%--Second Row--%>


         <div class="row abtContentDiv">
            <div class="col-sm-12 col-md-5">
                <img class="img-fluid" src="images/markx.png" />
            </div>
            <div class="col-sm-12 col-md-7 bgTheme">
                <div class="row">
                    <div class="col-4 displayText">
                        <h1>Premium</h1>
                        <h3>Toyota Mark X</h3>
                        <h6>PMTX01</h6>
                    </div>

                    <div class="col-3">
                        <div class="cardPricing">
                             <p> $7,500 JMD/day</p>
                        </div>
                    
                    </div>
                    <div class="col-2">
                        <div class="row">
                            <asp:Label ID="lbl_RentFor02" runat="server" Text="Rent For"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:DropDownList ID="ddl_DaysRented02" runat="server"></asp:DropDownList>
                        </div>
                        <div class="row">
                            <asp:Label ID="lbl_Days02" runat="server" Text="Day/s"></asp:Label>

                        </div>
                    </div>

                    <div class="col-3">
                        <div class="row">
                           <asp:Button ID="btn_AddCart02" runat="server" OnClick="btn_AddCart02_Click" Text="Add to Cart"/>
                        </div> 
                        <div class="row">
                         <asp:Label ID="lbl_AddedCart02" runat="server" Text="Added to Cart" BackColor="Green" Visible="false"></asp:Label>    
                        </div>
                    </div>

                   

                    


                </div>

                <div class="row paragraphText nPadding bg-dark">

                 <p>Stepping in the Toyota Mark X feels like a world of premium. Premium interior, premium ride comfort,
                     premium experience. It comfortably seats 3 passengers and comes with a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among 
                     other awesome specs.Contact Us for more Details.
                </p>
                </div>

            </div>
        </div>


          <%--Third Row--%>


         <div class="row abtContentDiv">
            <div class="col-sm-12 col-md-5">
                <img class="img-fluid" src="images/axio.png" />
            </div>
            <div class="col-sm-12 col-md-7 bgTheme">
                <div class="row">
                    <div class="col-4 displayText">
                        <h1>Standard</h1>
                        <h3>Toyota Axio</h3>
                        <h6>SDTA01</h6>
                    </div>

                    <div class="col-3">
                        <div class="cardPricing">
                             <p> $5,000 JMD/day</p>
                        </div>
                    
                    </div>
                    <div class="col-2">
                        <div class="row">
                            <asp:Label ID="lbl_RentFor03" runat="server" Text="Rent For"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:DropDownList ID="ddl_DaysRented03" runat="server"></asp:DropDownList>
                        </div>
                        <div class="row">
                            <asp:Label ID="lbl_Days03" runat="server" Text="Day/s"></asp:Label>

                        </div>
                    </div>

                      <div class="col-3">
                        <div class="row">
                           <asp:Button ID="btn_AddCart03" runat="server" OnClick="btn_AddCart03_Click" Text="Add to Cart"/>
                        </div> 
                        <div class="row">
                         <asp:Label ID="lbl_AddedCart03" runat="server" Text="Added to Cart" BackColor="Green" Visible="false"></asp:Label>    
                        </div>
                    </div>

                </div>

                <div class="row paragraphText nPadding bg-dark">

                 <p>There is nothing like crusing in comfort, which is an experience you can live in the Toyota Axio
                     . This 4 door sedan offers a clean cut, smooth sailing ride experience at a ridulously awesome rate
                     It comes standard with spacious interior, comfortably seating 3 passengers, a Radio/CD/Bluetooth player, MP3 interface, GPS Navagiation, fully A/C, automatic transmission among 
                     other awesome specs. Contact Us for more Details.
                </p>
                </div>

            </div>
        </div>




    </div>


</asp:Content>
