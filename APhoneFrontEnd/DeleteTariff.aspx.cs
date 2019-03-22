using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class DeleteTariff : System.Web.UI.Page
    {
        Int32 TariffID;
        protected void Page_Load(object sender, EventArgs e)
        {
            TariffID = Convert.ToInt32(Session["TariffID"]);
        }

        void TariffDelete()
        {
            clsTariffCollection TariffBook = new clsTariffCollection();
            TariffBook.ThisTariff.Find(TariffID);
            TariffBook.Delete();
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            TariffDelete();
            Response.Redirect("Tariff.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tariff.aspx");
        }
    }
}