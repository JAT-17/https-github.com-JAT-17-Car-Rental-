<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    
    
    <div>


        <h1> Chech out what we have in store for you!!!! </h1>
</div>
         
    


           <div class="row">
              
                 
            <div class="col-sm-5 ">
                 <img class="img-responsive car" src="Images/2019-toyota-corolla.jpg" />
             

     
    <h2> ID: 56RT7  <br />
        Name: 2019-Toyota-Corolla <br />
        Type: Sedan <br />
        Unit Price: $7500 per day<br />
         </h2>
    
    <asp:Button id="btnAddToCart" Text="ADD TO CART" runat="server"  OnClick="btnAddToCart_Click" />   
    <asp:DropDownList ID="ddlToyota" runat="server">
        <asp:ListItem>Select number of days</asp:ListItem>
        <asp:ListItem value="1"> 1 Day</asp:ListItem>
        <asp:ListItem value="2"> 2 Days</asp:ListItem>
        <asp:ListItem value="3"> 3 Days</asp:ListItem>
        <asp:ListItem value="4"> 4 Days</asp:ListItem>
        <asp:ListItem value="5"> 5 Day</asp:ListItem>
    </asp:DropDownList>
   From  <asp:TextBox ID="fromdatepicker1" runat="server" TextMode="Date"> </asp:TextBox>       
    to  
        <asp:TextBox ID="todatepicker1" runat="server" TextMode="Date"> </asp:TextBox>
        
 </div>   

  



             <div class="col-sm-5 ">   
             <img class="img-responsive car" src="Images/2019 Nissan.jpg" />
             
         

      
    <h2> ID: 72KG4  <br />
        Name: 2019-Nissan <br />
        Type: Sudan <br />
        Unit Price: $9500 per day<br />
         </h2>

        <asp:Button id="Button1" Text="ADD TO CART" runat="server"  OnClick="btnAddToCart_Click1" />   
    <asp:DropDownList ID="ddlNissan" runat="server">
        <asp:ListItem>Select number of days</asp:ListItem>
        <asp:ListItem value="1"> 1 Day</asp:ListItem>
        <asp:ListItem value="2"> 2 Days</asp:ListItem>
        <asp:ListItem value="3"> 3 Days</asp:ListItem>
        <asp:ListItem value="4"> 4 Days</asp:ListItem>
        <asp:ListItem value="5"> 5 Day</asp:ListItem>
    </asp:DropDownList>
   From  <asp:TextBox ID="fromdatepicker2" runat="server" TextMode="Date"> </asp:TextBox>       
    to  
        <asp:TextBox ID="todatepicker2" runat="server" TextMode="Date"> </asp:TextBox>
    
</div>
   
 </div>    


    <div class="row">
             <div class="col-sm-5 center">   
             <img class="img-responsive car" src="Images/Swift 2017.jpg" />
             </div>
         </div>

    <div class="row">  
    <h2> ID: 60TY6  <br />
        Name: 2017- Suzuki Swift <br />
        Unit Price: $6500 per day<br />
         </h2>
    </div>
       


    




</asp:Content>
