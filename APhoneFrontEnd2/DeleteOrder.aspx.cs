using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd2
{
    public partial class DeleteOrder : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            OrderID = Convert.ToInt32(Session["OrderID"]);
        }

        //event handler for the yes button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            OrderDelete();
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }

        //event handler for the no button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }

        void OrderDelete()
        {
            //function to delete the selected record

            //create a new instance of the address book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //find the record to delete
            OrderBook.ThisOrder.Find(OrderID);
            //delete the record
            OrderBook.Delete();
        }
    }
}