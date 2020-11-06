using Car_Rental_Assignment_Second_Assignment.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

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


            Selected = (List<CartItem>)Session["Rental"];

            decimal Total = 0;
            int NumDays;
            decimal Price;

               
            
            
            foreach (var item in Selected)
                {
                NumDays = item.NumOfDays;
                Price = item.Price;

                Total += NumDays * Price;
                
                //Table row declaered
                TableRow Row = new TableRow();
                //Table row declaered

                TableCell nameCellCarname = new TableCell();
                TableCell nameCellNumofDays = new TableCell();
                TableCell nameCellPrice = new TableCell();
                TableCell nameCellFromDate = new TableCell();
                TableCell nameCellToDate = new TableCell();
               TableCell nameCellRemoveItem = new TableCell();
                CheckBoxField nameCellRemoveItem1 = new CheckBoxField();

                //CheckBox nameCellRemoveItem = new CheckBox();

                nameCellCarname.Text = item.CarName;
                nameCellNumofDays.Text = Convert.ToString (item.NumOfDays);
                nameCellPrice.Text = Convert.ToString (item.Price);
                nameCellFromDate.Text = item.FromDate;
                nameCellToDate.Text = item.ToDate;
               // nameCellRemoveItem.Enabled = item.Remove; 
                //nameCellRemoveItem.Controls = nameCellRemoveItem1;
                // nameCellRemoveItem = Page.FindControl(nameCellRemoveItem1)




                // nameCellRemoveItem.Checked = item.Remove;



                Row.Cells.Add(nameCellCarname);
                Row.Cells.Add(nameCellNumofDays);
                Row.Cells.Add(nameCellPrice);
                Row.Cells.Add(nameCellFromDate);
                Row.Cells.Add(nameCellToDate);
                Row.Cells.Add(nameCellRemoveItem);
               // Row.Cells.Add(nameCellRemoveItem);
                // Row.Cells.Add(Controls.Add(nameCellRemoveItem1));

                // Row.Cells.Add(nameCellRemoveItem);


                this.RentalCartTable.Rows.Add(Row);

            }

         
            lbiRentalTotal.Text = Convert.ToString(Total);

         
        }
            protected decimal CalculateRentalListTotal(int numofdays, decimal price)
            {
                decimal Total = numofdays * price;

                return Total;

            }

        protected void SaveCartItem_Click(object sender, EventArgs e)
        {
            string dbconnection = ConfigurationManager.ConnectionStrings["GetWayCarRentalDBConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(dbconnection);
            sqlconn.Open();

            Selected = (List<CartItem>)Session["Rental"];

            foreach (var item in Selected) 
            {

                string sqlquery = "insert into [dbo].[CartItem] (days, carName,fromdate, toDate)  values (@NumOfDays, @CarName, @FromDate,@ToDate) ";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@NumOfDays",item.NumOfDays );
                sqlcomm.Parameters.AddWithValue("@CarName", item.CarName);
                sqlcomm.Parameters.AddWithValue("@FromDate", item.FromDate);
                sqlcomm.Parameters.AddWithValue("@ToDate", item.ToDate);

                sqlcomm.ExecuteNonQuery();
            }
            sqlconn.Close();
        }
    }
}