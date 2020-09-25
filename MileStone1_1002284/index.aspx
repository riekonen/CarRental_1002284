<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MileStone1_1002284.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<div class="container-fluid">
    
   <div id="slides" class="carousel slide" data-ride="carousel">
        <ul class="carousel-indicators">
            <li data-target="#slides" data-slide-to="0" class="active"></li>
           <li data-target="#slides" data-slide-to="1"></li>    
        </ul>

        <div class="carousel-inner">
                         
        <div class="carousel-item active">
            

            <div class="container containerText">
                <div class="row rowText">
                     <div class="col-12 my-auto">
                        <h1>Chez Rentals</h1>
                        <p>We offer Jamaicans automobile rentals everyday of the week, at affordable
                            rates.
                        </p>
                         <a href="Products.aspx" class="btn btn-md btn-primary">View Now </a>
                    </div>
               </div>
            </div>                            
        </div>  
    
    <div class="carousel-item">        
            <div class="container containerText">
            <div class="row rowText">
                     <div class="col-12 my-auto">
                        <p>Choose a ride to match your style from our 3 classes, Luxury,
                            Premium and Standard.
                        </p>
                         <a href="Products.aspx" class="btn btn-lg btn-primary">View Now </a>
                    </div>
               </div>
                
            </div>                           
    </div> 
       
    </div>
              
      
    </div>
  </div>
        
        <br />        

    <div class="container-fluid fixedBg nPadding">        
       
       <div class="row text-center">
           <div class="col-12">
               <h1 class="displayText">Featured Rentals</h1>
           </div>
       </div>

        <br />

       <div class="row nPadding" >
            
           <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/hondacivic.png" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Luxury</h4>
                                <h6>Honda Civic</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $10,000 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        
            
            <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/markx.png" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Premium</h4>
                                <h6>Toyota Mark X</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $7,500 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


           <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/axio.png" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Standard</h4>
                                <h6>Toyota Axio</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $5,000 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 

        </div>

        <div class="row nPadding">
            
            <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/benz.png" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Luxury</h4>
                                <h6>2018 C-Class Benz</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $5,000 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/hondafit.png" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Standard</h4>
                                <h6>Honda Fit</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $5,000 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
        
        
            <div class="col-md-4">
                <div class="card cardStyle">
                    <img class="card-img-top" src="images/vitz.jpg" />
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6 nPadding">
                                <h4 class="card-title">Standard</h4>
                                <h6>Toyota Vitz</h6>
                            </div>
                            <div class="col-sm-6 cardPricing">
                               <a href="Products.aspx" class="btn stretched-link card-text ">From $5,000 JMD/day</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
        </div>



    </div>








    <%--  --%>
</asp:Content>
