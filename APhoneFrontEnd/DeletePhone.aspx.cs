using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class DeletePhone : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 PhoneId;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the phone to deleted from the session object
            PhoneId = Convert.ToInt32(Session["PhoneID"]);
        }

        void DeleteSelectedPhone()
        {
            //create an instance of the phone book
            clsPhoneCollection PhoneBook = new clsPhoneCollection();
            //find the record to delete
            PhoneBook.ThisPhone.Find(PhoneId);
            //delete the record
            PhoneBook.Delete();
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteSelectedPhone();
            //redirect to the default
            Response.Redirect("Default.aspx");
        }
    }
}