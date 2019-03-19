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

    }
}