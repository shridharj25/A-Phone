using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class AddPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            //create an instance of the Phone book
            clsPhoneCollection PhoneBook = new clsPhoneCollection();
            //validate the data on the web form
            String Error = PhoneBook.ThisPhone.Valid(txtMake.Text, txtModel.Text, txtPhoneNo.Text, txtPrice.Text, txtScreenSize.Text, txtCameraQuality.Text);
            //if the data is okay then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                PhoneBook.ThisPhone.Make = txtMake.Text;
                PhoneBook.ThisPhone.Model = txtModel.Text;
                PhoneBook.ThisPhone.PhoneNo = txtPhoneNo.Text;
                PhoneBook.ThisPhone.Price = txtPrice.Text;
                PhoneBook.ThisPhone.ScreenSize = txtScreenSize.Text;
                PhoneBook.ThisPhone.CameraQuality = txtCameraQuality.Text;
                //add the record
                PhoneBook.Add();
                //all done so redirect to default
                Response.Redirect("Default.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect to default
            Response.Redirect("Default.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}