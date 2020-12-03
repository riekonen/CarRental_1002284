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
    </div>

        <br />

         <asp:ListView ID="CarsList" runat="server" DataKeyNames="CarID" ItemType="MileStone1_1002284.Models.Car" 
             ClientIDMode="Predictable" ClientIDRowSuffix="CarID" GroupItemCount="3" ItemPlaceholderID="itemPlaceholder" GroupPlaceholderID="groupPlaceholder" >
                <LayoutTemplate>
                    <div class="container-fluid" runat="server" id="groupPlaceholder">
                        
                    </div>

                </LayoutTemplate>
                <GroupTemplate>
                    <div class="row nPadding"  >                        
                        
                       <asp:PlaceHolder  runat="server" id="itemPlaceholder">

                       </asp:PlaceHolder>
                        
                    </div>
                        
                   
                </GroupTemplate>
                

                <ItemTemplate>

                    <div class="col-md-4">
                        <div class="card cardStyle">
                             <img class="card-img-top" runat="server" src='<%# "images/"+Item.imageUrl %>'/>
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-sm-6">
                                           <h5> <asp:Label ID="lbl_Category" runat="server" Text='<%# ""+Item.Category %>'></asp:Label></h5>
                                            <asp:Label ID="lbl_CarName" runat="server" Text='<%# ""+Item.CarName %>'></asp:Label>
                                        </div>
                                        <div class="col-sm-6 cardPricing">
                                            <a href="Products.aspx" class="btn stretched-link card-text ">From <%#"$"+Item.Price.UnitPrice %> JMD/day</a>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>

                </ItemTemplate>
        </asp:ListView>


        <br />
        <br />



    <%--  --%>
</asp:Content>
