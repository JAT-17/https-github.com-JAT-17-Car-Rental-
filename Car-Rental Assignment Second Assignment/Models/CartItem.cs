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

        public string FromDate { get; set; }

        public string ToDate { get; set; }
        public string V1 { get; }
        public int V2 { get; }
        public decimal V3 { get; }
        public DateTime DateTime { get; }
        public string V4 { get; }

        public CartItem() //Defualt Constructor
        {
            CarName = "None";
            NumOfDays = 0;
            Price = 0M;
            FromDate = "01/01/2000";
            ToDate = "01/12/2000";


        }

        public CartItem (string carname, int numofdays, decimal price, string formdate, string todate) //Primary Constructor
        {
            CarName = carname;
            NumOfDays = numofdays;
            Price = price;
            FromDate = formdate;
            ToDate = todate;
        }


        public CartItem (CartItem CartItemObj) // Copy Constructor
        {
            CarName = CartItemObj.CarName;
            NumOfDays = CartItemObj.NumOfDays;
            Price = CartItemObj.Price;
            FromDate = CartItemObj.FromDate;
            ToDate = CartItemObj.ToDate;

        }

        public CartItem(string v1, int v2, decimal v3, DateTime dateTime, string v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            DateTime = dateTime;
            V4 = v4;
        }
    }









}





