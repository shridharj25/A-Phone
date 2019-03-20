using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APhoneFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed 
            if(IsPostBack == false)

        {
                //update the list box
                DisplayPhones();
            }
        }

        void DisplayPhones()
        {
            //create an instance of the phone collection
            APhoneLibrary.clsPhoneCollection Phones = new APhoneLibrary.clsPhoneCollection();
            //set the data source to the list of phones in the collection
            lstPhones.DataSource = Phones.PhoneList;
            //set the name of the primary key
            lstPhones.DataValueField = "PhoneId";
            //set the data field to display
            lstPhones.DataTextField = "Model";
            //bind the data to the list
            lstPhones.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["PhoneId"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddPhone.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store primary key valueof the record to be delete
            Int32 PhoneId;
            //if a record has been selected from the list
            if (lstPhones.SelectedIndex != -1)
            {
                //get the primary key value of the record to be deleted 
                PhoneId = Convert.ToInt32(lstPhones.SelectedValue);
                //store the data in the session object
                Session["PhoneID"] = PhoneId;
                //redirect to the delete page
                Response.Redirect("DeletePhone.aspx");
            }
            else //if no record is selected
            {
                //display an error
                lblError.Text = "Please select a reord to delete from the list";
            }
        }
    }
}