<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentalCart.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.RentalCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="container" id="RentalCartContainer">
        <div class="row">  
            <div class="col-md-6">  
                <div class="jumbotron" id="ShoppingCartShell"> 
                    
                            <h1 class="lead-title-RentalCartPage">Rental Cart</h1>   
<asp:Table ID="RentalCartTable" runat="server">                    
      <asp:TableRow>
                    <asp:TableHeaderCell>Car &nbsp;&nbsp;&nbsp;&nbsp;|</asp:TableHeaderCell>
                    <asp:TableHeaderCell>&nbsp; Days &nbsp;|</asp:TableHeaderCell>
                    <asp:TableHeaderCell> &nbsp; Cost Per day &nbsp;|</asp:TableHeaderCell>
                    <asp:TableHeaderCell>&nbsp; From &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;|</asp:TableHeaderCell>
                    <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp; To &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| </asp:TableHeaderCell>
     </asp:TableRow>

     <asp:TableRow>
                    <asp:TableCell>
                        <asp:Literal ID="lbiCarName" runat="server"></asp:Literal>&nbsp
                    </asp:TableCell>
                    
                    <asp:TableCell>
                       &nbsp;&nbsp;&nbsp; <asp:Literal  ID="lbiNumOfDays" runat="server"></asp:Literal>&nbsp
                    </asp:TableCell>

                    <asp:TableCell>
                       &nbsp;&nbsp;&nbsp;&nbsp; <asp:Literal ID="lbiPrice" runat="server"></asp:Literal>&nbsp
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:Literal ID="lbiFromDate" runat="server"> </asp:Literal>&nbsp
                    </asp:TableCell>
         
                    <asp:TableCell>
                      &nbsp;  <asp:Literal ID="lbiToDate" runat="server"></asp:Literal>&nbsp
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
