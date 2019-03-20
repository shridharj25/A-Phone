using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APhoneFrontEnd
{
    public partial class Customer : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first timr the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomers();
            }

        }

        void DisplayCustomers()
        {
            //create an instance of the customer collection
            APhoneLibrary.clsCustomerCollection Customers = new APhoneLibrary.clsCustomerCollection();
            //set the data source to the list of customers in the collection
            lstCustomers.DataSource = Customers.CustomerList;
            //set the name of the primary key
            lstCustomers.DataValueField = "CustomerID";
            //set the data field to display
            lstCustomers.DataValueField = "Surname";
            //bind the data to the list
            lstCustomers.DataBind();

        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CusomterID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddCustomer.aspx");
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}