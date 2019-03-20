using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class DeleteCustomer : System.Web.UI.Page

    {
        //var to store the primary key value of the record to be delete
        Int32 CustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        void DeleteCustomers()
        {
            //function to delete the selected record

            //create a new instance of the customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //findthe record to delete
            CustomerBook.ThisCustomer.Find(CustomerID);
            //delete the record
            CustomerBook.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCustomers();
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
    }
}