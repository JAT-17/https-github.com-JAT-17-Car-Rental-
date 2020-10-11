<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentalCart.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.RentalCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="container">
        <div class="row">  
            <div class="col-md-8">  
                <div class="jumbotron ShoppingCartShell"> 
                    
                            <h1 class="lead-title-RentalCartPage">Rental Cart</h1>   
<asp:Table ID="RentalCartTable" runat="server">                    
      <asp:TableRow>
                    <asp:TableHeaderCell> Item   &nbsp;&nbsp; |   </asp:TableHeaderCell>
                    <asp:TableHeaderCell> &nbsp;&nbsp;Number of days &nbsp;&nbsp;  |   </asp:TableHeaderCell>
                    <asp:TableHeaderCell> Price Per day ($)      </asp:TableHeaderCell>
     </asp:TableRow>

     <asp:TableRow>
                    <asp:TableCell>
                        <asp:Literal ID="lbiCarName" runat="server"></asp:Literal>
                    </asp:TableCell>
                    
                    <asp:TableCell>
                        <asp:Literal ID="lbiNumOfDays" runat="server"></asp:Literal>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:Literal ID="lbiPrice" runat="server"></asp:Literal>
                    </asp:TableCell>
     </asp:TableRow>               
</asp:Table>
            
                    <h3> Rental Total: </h3>
                    <asp:Label id="lbiRentalTotal" runat="server" Text="" ></asp:Label>


               </div>
            </div>       
        </div> 
    </div>





</asp:Content>
