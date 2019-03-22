using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class AddTariff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            clsTariffCollection TariffBook = new clsTariffCollection();
            String Error = TariffBook.ThisTariff.Valid(txtTariffTexts.Text, txtTariffCalls.Text, txtTariffData.Text, txtTariffNetwork.Text, Convert.ToDecimal(txtTariffPrice.Text), Convert.ToDecimal(txtTariffUpfront.Text));
            if (Error == "")
            {
                TariffBook.ThisTariff.TariffTexts = txtTariffTexts.Text;
                TariffBook.ThisTariff.TariffCalls = txtTariffCalls.Text;
                TariffBook.ThisTariff.TariffData = txtTariffData.Text;
                TariffBook.ThisTariff.TariffNetwork = txtTariffNetwork.Text;
                TariffBook.ThisTariff.TariffPrice = Convert.ToDecimal(txtTariffPrice.Text);
                TariffBook.ThisTariff.TariffUpfront = Convert.ToDecimal(txtTariffUpfront.Text);
                TariffBook.Add();
            }
            else
            {
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("Tariff.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tariff.aspx");
        }
    }
}