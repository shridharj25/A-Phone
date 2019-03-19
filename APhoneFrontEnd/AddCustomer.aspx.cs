using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        Int32 CustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the Customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //validate the data on the web form
            String Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtSurname.Text, txtPhoneNo.Text, txtStreetName.Text, txtHouseNumber.Text, txtPostCode.Text, txtDOB.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerBook.ThisCustomer.Surname = txtSurname.Text;
                CustomerBook.ThisCustomer.PhoneNo = txtPhoneNo.Text;
                CustomerBook.ThisCustomer.StreetName = txtStreetName.Text;
                CustomerBook.ThisCustomer.HouseNumber = txtHouseNumber.Text;
                CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
                //add the record
                CustomerBook.Add();
                //all done so redirect back to the main page
                Response.Redirect("Default.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
    }
}