<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

<div class="container">
       
    <div class="row">
            <div class="col-md-4">
                <img src="Images/man-holding-keys-png.png" class="img-responsive"  id="Man_with_key"/>
            </div>
        
        <div class="col-md-8">
               <asp:Image ID="Icon" runat="server" ImageUrl="../Images/logo.png" class="img-responsive" />
    
                    <p class="About_us_info">We are a jamaican owned company established on March 17, 2010.
                        Apart from our Head Office location at 237 W.I, 6 Old Hope Rd, Kingston  
                        we have two other offices which are conveniently located in-terminal at the international airports each located in Kingston,
                        the island’s capital and in Ocho Rios, a major tourist destination on the north coast.
                    </p>
             </div>
         </div>

</asp:Content>
