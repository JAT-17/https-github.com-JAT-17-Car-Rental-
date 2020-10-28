<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomError.aspx.cs" Inherits="Car_Rental_Assignment_Second_Assignment.CustomError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>   An error has occured!!</h1>

    
        <h2>

            An unexpected error has occured. The administrator as been notified.
        </h2>
    <p>
        <asp:HyperLink   id="inkhome" runat="server"  NavigateURL="~/Default.aspx" >Return to home page</asp:HyperLink>

    </p>
  
</asp:Content>
