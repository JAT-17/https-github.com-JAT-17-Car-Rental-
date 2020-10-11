using Car_Rental_Assignment_Second_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Rental_Assignment_Second_Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<CartItem> Rentals = new List<CartItem>(); //This is for adding more than one item to the cart

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }


        protected void btnAddToCart_Click (object sender, EventArgs e)
        {
            CartItem ItemSelected = new CartItem("Toyota", Convert.ToInt32(ddlToyota.SelectedValue), 7500M);

            //Adding this rental car to the list 
            Rentals.Add(ItemSelected);

            Session["Rental"] = Rentals;
            Response.Redirect("RentalCart.aspx");
        }
    }
}