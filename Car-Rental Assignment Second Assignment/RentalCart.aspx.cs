using Car_Rental_Assignment_Second_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Rental_Assignment_Second_Assignment
{
    public partial class RentalCart : System.Web.UI.Page
    { 
        protected List<CartItem> Selected = new List<CartItem>();

        

        protected void Page_Load(object sender, EventArgs e)
        {
             DisplayRentalCart();
        }


        public void DisplayRentalCart()
        {
            
           
            Selected  = (List<CartItem>)Session["Rental"];

            string Name1 = "";
            string NumOfDays1 = "";
            string Price1 = "";
            string FromDate1 = "";
            string ToDate1 = "";

            foreach (var item in Selected  )
            {
                Name1 += item.CarName;
                NumOfDays1 += item.NumOfDays;
                Price1 += item.Price;
                FromDate1 += item.FromDate;
                ToDate1 += item.ToDate;
            }

            lbiCarName.Text = Name1;
            lbiNumOfDays.Text = NumOfDays1;
            lbiPrice.Text = Price1;
            lbiFromDate.Text = FromDate1;
            lbiToDate.Text = ToDate1;
            lbiRentalTotal.Text = CalculateRentalListTotal(Convert.ToInt32(NumOfDays1), Convert.ToInt32(Price1)).ToString("C",CultureInfo.CurrentCulture);
        }
            protected decimal CalculateRentalListTotal(int numofdays, decimal price)
            {
                decimal Total = numofdays * price;

                return Total;

            }


        
    }
}