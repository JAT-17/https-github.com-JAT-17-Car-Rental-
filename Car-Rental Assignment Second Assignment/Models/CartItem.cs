using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Assignment_Second_Assignment.Models
{
    public class CartItem
    {
        public string CarName { get; set; }

        public int NumOfDays { get; set; }

        public decimal Price { get; set; }


        public CartItem() //Defualt Constructor
        {
            CarName = "None";
            NumOfDays = 0;
            Price = 0M;

        }

        public CartItem (string carname, int numofdays, decimal price ) //Primary Constructor
        {
            CarName = carname;
            NumOfDays = numofdays;
            Price = price;
        }


        public CartItem (CartItem CartItemObj) // Copy Constructor
        {
            CarName = CartItemObj.CarName;
            NumOfDays = CartItemObj.NumOfDays;
            Price = CartItemObj.Price;

        }
    }









}





