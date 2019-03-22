using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd
{
    public partial class EditTariff : System.Web.UI.Page
    {
        Int32 TariffID;
        protected void Page_Load(object sender, EventArgs e)
        {
            TariffID = Convert.ToInt32(Session["TariffID"]);
            if (IsPostBack == false)
            {
              if (TariffID != -1)
              {
                    DisplayTariffs();
              }
            }
        }

        void DisplayTariffs()
        {
            clsTariffCollection TariffBook = new clsTariffCollection();
            TariffBook.ThisTariff.Find(TariffID);
            txtTariffTexts.Text = TariffBook.ThisTariff.TariffTexts;
            txtTariffCalls.Text = TariffBook.ThisTariff.TariffCalls;
            txtTariffData.Text = TariffBook.ThisTariff.TariffData;
            txtTariffNetwork.Text = TariffBook.ThisTariff.TariffNetwork;
            txtTariffPrice.Text = Convert.ToString(TariffBook.ThisTariff.TariffPrice);
            txtTariffUpfront.Text = Convert.ToString(TariffBook.ThisTariff.TariffUpfront);
        }

        void Update()
        {
            clsTariffCollection TariffBook = new clsTariffCollection();
            String Error = TariffBook.ThisTariff.Valid(txtTariffTexts.Text, txtTariffCalls.Text, txtTariffData.Text, txtTariffNetwork.Text, Convert.ToDecimal(txtTariffPrice.Text), Convert.ToDecimal(txtTariffUpfront.Text));
            if (Error == "")
            {
                TariffBook.ThisTariff.Find(TariffID);
                TariffBook.ThisTariff.TariffTexts = txtTariffTexts.Text;
                TariffBook.ThisTariff.TariffCalls = txtTariffCalls.Text;
                TariffBook.ThisTariff.TariffData = txtTariffData.Text;
                TariffBook.ThisTariff.TariffNetwork = txtTariffNetwork.Text;
                TariffBook.ThisTariff.TariffPrice = Convert.ToDecimal(txtTariffTexts.Text);
                TariffBook.ThisTariff.TariffUpfront = Convert.ToDecimal(txtTariffTexts.Text);
                TariffBook.Update();
                Response.Redirect("Tariff.aspx");
            }
            else
            {
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (TariffID == -1)
            {
                Add();
            }
            else
            {
                Update();
            }
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tariff.aspx");
        }
    }
}