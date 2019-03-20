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

                DisplayCustomerFirstName();
                DisplayCustomerSurname();
                DisplayPhoneMake();
                DisplayPhoneModel();


            }
           
           
        }

        void DisplayTariffs()
        {
            //    //create an instance of the County Collection
            //    APhoneLibrary.clsTariffCollection Tariffs = new APhoneLibrary.clsTariffCollection();
            //    //set the data source to the list of Tariffs in the collection
            //    ddlTariffList.DataSource = Tariffs.AllTariffs;
            //    //set the name of the primary key
            //    ddlTariffList.DataValueField = "TariffID";
            //    //set the data field to display
            //    ddlTariffList.DataTextField = "TariffID";
            //    //bind the data to the list
            //    ddlTariffList.DataBind();
            //}


        }
        void DisplayCustomerFirstName()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsCustomerCollection CustomerFirstName = new APhoneLibrary.clsCustomerCollection();
            //set the data source to the list of Customer in the collection
            ddlFirstName.DataSource = CustomerFirstName.CustomerList;
            //set the name of the primary key
            ddlFirstName.DataValueField = "CustomerID";
            //set the data field to display
            ddlFirstName.DataTextField = "FirstName";
            //bind the data to the list
            ddlFirstName.DataBind();
        }

        void DisplayCustomerSurname()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsCustomerCollection CustomerSurnameName = new APhoneLibrary.clsCustomerCollection();
            //set the data source to the list of Customer in the collection
            ddlSurname.DataSource = CustomerSurnameName.CustomerList;
            //set the name of the primary key
            ddlSurname.DataValueField = "CustomerID";
            //set the data field to display
            ddlSurname.DataTextField = "Surname";
            //bind the data to the list
            ddlSurname.DataBind();
        }
        void DisplayPhoneMake()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsPhoneCollection PhoneMake = new APhoneLibrary.clsPhoneCollection();
            //set the data source to the list of Phone in the collection
            ddlPhoneMake.DataSource = PhoneMake.PhoneList;
            //set the name of the primary key
            ddlPhoneMake.DataValueField = "PhoneID";
            //set the data field to display
            ddlPhoneMake.DataTextField = "PhoneMake";
            //bind the data to the list
            ddlPhoneMake.DataBind();
        }
        void DisplayPhoneModel()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsPhoneCollection PhoneModel = new APhoneLibrary.clsPhoneCollection();
            //set the data source to the list of Phone in the collection
            ddlPhoneMake.DataSource = PhoneModel.PhoneList;
            //set the name of the primary key
            ddlPhoneMake.DataValueField = "PhoneID";
            //set the data field to display
            ddlPhoneMake.DataTextField = "PhoneModel";
            //bind the data to the list
            ddlPhoneMake.DataBind();
        }
        void DisplayTariffID()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsTariffCollection Tariif = new APhoneLibrary.clsTariffCollection();
            //set the data source to the list of Phone in the collection
            ddlShowTariffs.DataSource = Tariif.TariffList;
            //set the name of the primary key
            ddlShowTariffs.DataValueField = "TariffID";
            //set the data field to display
            ddlShowTariffs.DataTextField = "TariffID";
            //bind the data to the list
            ddlShowTariffs.DataBind();
        }
    }
}