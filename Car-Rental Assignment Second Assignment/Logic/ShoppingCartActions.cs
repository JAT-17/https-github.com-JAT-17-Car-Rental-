using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Get_Away_Car_Rental.Models;

namespace Car_Rental_Assignment_Second_Assignment.Logic
{
    public class ShoppingCartActions : IDisposable

    {
        public string ShoppingCartId { get; set; }

        public const string CartSessionKey = "CartId";


    }
}