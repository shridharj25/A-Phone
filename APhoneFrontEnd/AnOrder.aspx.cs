using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{

    public partial class AnOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayTariffs();
            }
        }

        void DisplayTariffs()
        {
            //create an instance of the County Collection
           // APhoneLibrary.clsTariffCollection Tariffs = new APhoneLibrary.clsTariffCollection();
            //set the data source to the list of Tariffs in the collection
           // ddlTariffList.DataSource = Tariffs.AllCounties;
            //set the name of the primary key
            ddlTariffList.DataValueField = "TariffID";
            //set the data field to display
            ddlTariffList.DataTextField = "TariffID";
            //bind the data to the list
            ddlTariffList.DataBind();
        }
    }

}