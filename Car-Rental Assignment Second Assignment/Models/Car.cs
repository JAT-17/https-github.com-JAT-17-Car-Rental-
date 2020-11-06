using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Assignment_Second_Assignment.Models
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public Car() //default Constructor
        {
            Make = "None";
            Model = "None";
            Price = 0M;
        }

        public Car( string make, string model, decimal price  ) //Primary Constructor
        {
            Make = make;
            Model = model;
            Price = price;
        }

        


    }
}