<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MileStone1_1002284.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <br />   
   <div class="container-fluid">
        <div class="row bgTheme abtContentDiv">
            <div class="col-12">
                <h2>About Us</h2>
                <h6>Our History</h6>
                 <p class="bg-dark paragraphText nPadding">We are a fairly new Car Rental company, started in 2019.
                     We started as a idea thought of they three (3) college friends,
                     to offer a car rental service to Jamaicans, at affordable rates for everyone.
                     Our first location was in New Kingston, Jamaica, however, now we have successfully
                     launched operation in Monetgo Bay and Mandeville, to offer more Jamaicans great deals. We aspire 
                     to one day be in all 14 parishes.
                </p>
            </div>            
        </div>
    </div>
   
    <hr />
    
    <div class="container-fluid">
        <div class="row bgTheme abtContentDiv">
            <div class="col-12">
                <h6>Our Aim</h6>
                 <p class="bg-dark paragraphText nPadding">We aim to offer automobile rentals
                     for all Jamaicans, everyday of the week, at affordable
                rates. Choose a ride to match your style from our 3 classes, Luxury,
                Premium and Standard.
                </p>
            </div>
        </div>
    </div>
    
    <hr />
   <div class="container-fluid">
        <div class="row bgTheme abtContentDiv">
            <div class="col-12">
                <h6>Our Culture</h6>
                 <p class="bg-dark paragraphText nPadding">We pride ourselves in offering the best 
                     sercies and products to our customers. We believe that our customers are apart of 
                     our family and therefore deserve the best. Contact Us to find out how to become apart of 
                     our family.
                     <asp:CheckBox ID="CheckBox1" runat="server" />
                </p>
            </div>
        </div>
    </div>
    
</asp:Content>
