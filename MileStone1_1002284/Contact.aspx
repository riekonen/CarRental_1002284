<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MileStone1_1002284.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div class="container-fluid">
   <div class="row bgTheme abtContentDiv">
      <div class="col-sm-12 col-md-4 bg-dark nPadding displayText">
            <h2>Contact Us</h2>
            <h5>Main Office</h5>
            <address class="paragraphText">
                61 Terence Drive Way<br />
                New Kingston, JA<br />
                <abbr title="Phone">P:</abbr>
                876.321.4567
             </address>
      </div>
       <div class="col-sm-12 col-md-4 bg-dark nPadding">
            <h5> Montego Bay Location</h5>
            <address class="paragraphText">
                54 Queen Street<br />
                Montego Bay, JA<br />
                <abbr title="Phone">P:</abbr>
                876.789.1234
             </address>
      </div>
       <div class="col-sm-12 col-md-4 bg-dark nPadding">
            
            <h5>Mandeville Location</h5>
            <address class="paragraphText">
                22 Caledonia Rd<br />
                Mandeville, JA<br />
                <abbr title="Phone">P:</abbr>
                876.123.0007
             </address>
      </div>
   </div>
   <div class="row bgTheme abtContentDiv">
      <div class="col-12 nPadding">
         <address>
            <strong>Email:</strong>   <a href="mailto:Support@example.com">chezrentals@gmail.com</a><br />
            <strong>Information:</strong> <a href="mailto:Marketing@example.com">info@chezrentals.com</a>
        </address>
      </div>
    </div>
</div>

</asp:Content>
