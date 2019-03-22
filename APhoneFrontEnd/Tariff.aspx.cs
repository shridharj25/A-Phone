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
            lstTariff.DataTextField = "TariffNetwork";
            lstTariff.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["TariffID"] = -1;
            Response.Redirect("AddTariff.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 TariffID;
            if (lstTariff.SelectedIndex != -1)
            {
                TariffID = Convert.ToInt32(lstTariff.SelectedValue);
                Session["TariffID"] = TariffID;
                Response.Redirect("DeleteTariff.aspx");
            }
            else
            {
                lblError.Text = "Please Select A Record to Delete From The List";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 TariffID;
            if (lstTariff.SelectedIndex != -1)
            {
                TariffID = Convert.ToInt32(lstTariff.SelectedValue);
                Session["TariffID"] = TariffID;
                Response.Redirect("EditTariff.aspx");
            }
            else
            {
                lblError.Text = "Please Select a record from the list to edit";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}