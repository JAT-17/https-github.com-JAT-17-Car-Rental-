using Car_Rental_Assignment_Second_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Rental_Assignment_Second_Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<CartItem> Rentals = new List<CartItem>(); //This is for adding more than one item to the cart


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Rental"] != null)
            {
                Rentals = (List<CartItem>) Session["Rental"];

            }




        }


        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            

                   CartItem ItemSelected = new CartItem("Toyota", Convert.ToInt32(ddlToyota.SelectedValue), 7500M, Convert.ToString(fromdatepicker1.Text) , Convert.ToString(todatepicker1.Text));

                                            //Adding this rental car to the list 
            Rentals.Add(ItemSelected);

            Session["Rental"] = Rentals;
            Response.Redirect("RentalCart.aspx");
        }

        protected void btnAddToCart_Click1(object sender, EventArgs e)
        {
            CartItem ItemSelected2 = new CartItem("Nissan", Convert.ToInt32(ddlNissan.SelectedValue), 9500M, Convert.ToString(fromdatepicker2.Text), Convert.ToString(todatepicker2.Text));

            //Adding this rental car to the list 
            Rentals.Add(ItemSelected2);

            Session["Rental"] = Rentals;
            Response.Redirect("RentalCart.aspx");




        }

    }

}