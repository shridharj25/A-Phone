using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APhoneFrontEnd
{
    public partial class Tariff : System.Web.UI.Page
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
            APhoneLibrary.clsTariffCollection Tariffs = new APhoneLibrary.clsTariffCollection();
            lstTariff.DataSource = Tariffs.TariffList;
            lstTariff.DataValueField = "TariffID";
            lstTariff.DataTextField = "Network";
            lstTariff.DataBind();
        }
    }
}