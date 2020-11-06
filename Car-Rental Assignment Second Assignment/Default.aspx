<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment._Default" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div class="container">
        <div class="row">  
            <div class="col-md-12">  
                <div class="jumbotron">
                         
                    
                    <asp:Image id="Main_image"  runat="server" ImageUrl="../Images/Honda.png" class="img-responsive" />
                   
                            
                            <h1 class="lead-title">GetAway Car-Rental</h1>
                                    <h2 class="lead">Drive out with a secure and comfortable ride</h2>
                                    <p class="lead">We ensure excellent customer service and 24/7 feedback to our valued customer</p>
                                    <a class="btn btn-default btn-lg main_button_to_products" href="Products.aspx"> <strong>Check out your products &raquo;</strong></a>                             
                            
                    </div>
            </div>       
        </div> 
</div>


    <%--  --%>
   
</asp:Content>
