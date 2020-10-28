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
       // protected List<CartItem> additem = new List<CartItem>();


        protected void Page_Load(object sender, EventArgs e)
        {
            


            DisplayRentalCart();
        }






        public void DisplayRentalCart()
        {

            if (Session["Rental"] != null)
            {
               // List<CartItem> Selected = Session["Rental"] as List<CartItem>;
               // Selected.Add((CartItem)Session["Rental"]);
                //Session["Rental"] = Selected;

                // Selected = Convert.ToString(Selected);

            }


            //  additem = (List<CartItem>)Session["Rental"];
            Selected = (List<CartItem>)Session["Rental"];

                decimal Total = 0;
            int NumDays;
            decimal Price;

               
            
            
            foreach (var item in Selected)
                {
                NumDays = item.NumOfDays;
                Price = item.Price;

                Total += NumDays * Price;
                
                // Name1 += item.CarName;
                    //NumOfDays1 += item.NumOfDays;
                    //Price1 += item.Price;
                    //FromDate1 += item.FromDate;
                    //ToDate1 += item.ToDate;
                TableRow Row = new TableRow();
                TableCell nameCellCarname = new TableCell();
                TableCell nameCellNumofDays = new TableCell();
                TableCell nameCellPrice = new TableCell();
                TableCell nameCellFromDate = new TableCell();
                TableCell nameCellToDate = new TableCell();

                nameCellCarname.Text = item.CarName;
                nameCellNumofDays.Text = Convert.ToString (item.NumOfDays);
                nameCellPrice.Text = Convert.ToString (item.Price);
                nameCellFromDate.Text = item.FromDate;
                nameCellToDate.Text = item.ToDate;

                Row.Cells.Add(nameCellCarname);
                Row.Cells.Add(nameCellNumofDays);
                Row.Cells.Add(nameCellPrice);
                Row.Cells.Add(nameCellFromDate);
                Row.Cells.Add(nameCellToDate);

               // Name1 += Row.Cells.Add(new TableCell());
               // NumOfDays1 += Row.Cells.Add(new TableCell());
               // Price1 += Row.Cells.Add(new TableCell());
               //FromDate1 += Row.Cells.Add(new TableCell());
               //ToDate1 += Row.Cells.Add(new TableCell());

                // RowCell.Controls.Add(Name1 += item.CarName);

                // Name1 = Row.Cells.Add(TableCell RowCell(item.CarName));



                this.RentalCartTable.Rows.Add(Row);

                //Row.Cells.Add(new TableCell() )
                // this.RentalCartTable.Rows.Add(new TableRow()) 
            }

         
            lbiRentalTotal.Text = Convert.ToString(Total);

         
        }
            protected decimal CalculateRentalListTotal(int numofdays, decimal price)
            {
                decimal Total = numofdays * price;

                return Total;

            }


        
    }
}