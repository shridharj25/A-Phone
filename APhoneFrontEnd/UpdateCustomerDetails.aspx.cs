using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class EditCustomerDetails : System.Web.UI.Page
    {
        //variable store the primary key with page level scope
        Int32 CustomerID;
        //event handler for the page load event 
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customers to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            if (IsPostBack == false)
            {
              
                //if this is not a new record 
                if (CustomerID != -1)
                {
                    //display the current data for the record
                    DisplayCustomerDetails();
                }
            }
        }

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

        //function for updating records
        void Update()
        {
            //create an instance of the customer book
            APhoneLibrary.clsCustomerCollection CustomerBook = new APhoneLibrary.clsCustomerCollection();
            //validate the data on the web form
            String Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtHouseNumber.Text, txtDOB.Text, txtPhoneNo.Text, txtPostCode.Text, txtStreetName.Text, txtSurname.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerBook.ThisCustomer.HouseNumber = txtHouseNumber.Text;
                CustomerBook.ThisCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
                CustomerBook.ThisCustomer.PhoneNo = txtPhoneNo.Text;
                CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.StreetName = txtStreetName.Text;
                CustomerBook.ThisCustomer.Surname = txtSurname.Text;
                //update the record
                CustomerBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("Default.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }



        void DisplayCustomerDetails()
        {
            //create an instance of the customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //display the data for this record
            txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
            txtSurname.Text = CustomerBook.ThisCustomer.Surname;
            txtDOB.Text = CustomerBook.ThisCustomer.DOB.ToString();
            txtPhoneNo.Text = CustomerBook.ThisCustomer.PhoneNo;
            txtStreetName.Text = CustomerBook.ThisCustomer.StreetName;
            txtHouseNumber.Text = CustomerBook.ThisCustomer.HouseNumber;
            txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        }
        
        //event handler for the OK button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CustomerID == -1)

            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }
    }
}