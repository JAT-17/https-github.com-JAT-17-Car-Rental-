<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





 <div class="container" id="loginContainer">
        <div class="row">  
            <div class="col-md-4">  
                <div class="jumbotron" id="loginShell"> 

<div>
    <asp:Literal ID="UserName" runat="server"> User Name</asp:Literal> <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Literal ID="Password" runat="server"> Password </asp:Literal> <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
</div>


                </div>
            </div>       
        </div> 
    </div>


</asp:Content>



