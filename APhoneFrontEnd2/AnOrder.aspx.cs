using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APhoneLibrary;

namespace APhoneFrontEnd2
{
    public partial class AnOrder : System.Web.UI.Page
    {

        Int32 OrderID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be processed
            OrderID = Convert.ToInt32(Session["OrderID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //populate  list 
                DisplayCustomerFirstName();
                DisplayCustomerSurname();
                DisplayPhoneMake();
                DisplayPhoneModel();
                DisplayTariffID();

                if (OrderID != -1)
                {
                    //  display the current data for the record
                    DisplayOrderDetails();
                }
            }


        }

        void DisplayTariffs()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsTariffCollection Tariffs = new APhoneLibrary.clsTariffCollection();
            //set the data source to the list of Tariffs in the collection
            ddlTariffList.DataSource = Tariffs.TariffList;
            //set the name of the primary key
            ddlTariffList.DataValueField = "TariffID";
            //set the data field to display
            ddlTariffList.DataTextField = "TariffID";
            //bind the data to the list
            ddlTariffList.DataBind();



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
            ddlPhoneMake.DataValueField = "PhoneId";
            //set the data field to display
            ddlPhoneMake.DataTextField = "Make";
            //bind the data to the list
            ddlPhoneMake.DataBind();
        }
        void DisplayPhoneModel()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsPhoneCollection PhoneModel = new APhoneLibrary.clsPhoneCollection();
            //set the data source to the list of Phone in the collection
            ddlPhoneModel.DataSource = PhoneModel.PhoneList;
            //set the name of the primary key
            ddlPhoneModel.DataValueField = "PhoneId";
            //set the data field to display
            ddlPhoneModel.DataTextField = "Model";
            //bind the data to the list
            ddlPhoneModel.DataBind();
        }
        void DisplayTariffID()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsTariffCollection Tariif = new APhoneLibrary.clsTariffCollection();
            //set the data source to the list of Phone in the collection
            ddlTariffList.DataSource = Tariif.TariffList;
            //set the name of the primary key
            ddlTariffList.DataValueField = "TariffID";
            //set the data field to display
            ddlTariffList.DataTextField = "TariffID";
            //bind the data to the list
            ddlTariffList.DataBind();
        }

       void Add()
       {
            {
                //create an instance of the Order
                clsOrderCollection Order = new clsOrderCollection();
      
                //validate the data on the web form
                String Error = Order.ThisOrder.Valid(txtOrderDate.Text, txtOrderMadeBy.Text, txtPrice.Text);
                //if the data is OK then add it to the object
                if (Error == "")
                {
                    //get the data entered by the user
                    Order.ThisOrder.CustomerID = Convert.ToInt32(ddlFirstName.SelectedValue);
                    Order.ThisOrder.CustomerID = Convert.ToInt32(ddlSurname.SelectedValue);
                    Order.ThisOrder.PhoneID = Convert.ToInt32(ddlPhoneMake.SelectedValue);
                    Order.ThisOrder.PhoneID = Convert.ToInt32(ddlPhoneModel.SelectedValue);
                    Order.ThisOrder.TariffID = Convert.ToInt32(ddlTariffList.SelectedValue);
                    Order.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                    Order.ThisOrder.OrderMadeBy = txtOrderMadeBy.Text;
                    Order.ThisOrder.TotalPrice = Convert.ToDecimal(txtPrice.Text);
                    //add the record
                    Order.Add();
                    //all done so redirect back to the main page
                    Response.Redirect("Order.aspx");
                }
                else
                {
                    //report an error
                    lblError.Text = "There were problems with the data entered " + Error;
                }
            }
       }

        void Update()
        
        {
                //create an instance of the Order
               APhoneLibrary.clsOrderCollection Order = new APhoneLibrary.clsOrderCollection();
                //clsPhoneCollection Order2 = new clsPhoneCollection();
                //validate the data on the web form
                String Error = Order.ThisOrder.Valid(txtOrderDate.Text, txtOrderMadeBy.Text, txtPrice.Text);
                //if the data is OK then add it to the object
                if (Error == "")
                {
                    //find the record to update
                    Order.ThisOrder.Find(OrderID);
                    //get the data entered by the user
                    Order.ThisOrder.CustomerID = Convert.ToInt32(ddlFirstName.SelectedValue);
                    Order.ThisOrder.CustomerID = Convert.ToInt32(ddlSurname.SelectedValue);
                    Order.ThisOrder.PhoneID = Convert.ToInt32(ddlPhoneMake.SelectedValue);
                    Order.ThisOrder.PhoneID = Convert.ToInt32(ddlPhoneModel.SelectedValue);
                    Order.ThisOrder.TariffID = Convert.ToInt32(ddlTariffList.SelectedValue);
                    Order.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                    Order.ThisOrder.OrderMadeBy = txtOrderMadeBy.Text;
                    Order.ThisOrder.TotalPrice = Convert.ToDecimal(txtPrice.Text);
                //add the record
                Order.Update();
                    //all done so redirect back to the main page
                    Response.Redirect("Order.aspx");
                }
                else
                {
                    //report an error
                    lblError.Text = "There were problems with the data entered " + Error;
                }
        }
        



        void DisplayOrderDetails()
        {
            //create an instance of the address book
            clsOrderCollection OrderDetails = new clsOrderCollection();
            //find the record to Update
            OrderDetails.ThisOrder.Find(OrderID);
            //display the data for this record
            txtOrderDate.Text = OrderDetails.ThisOrder.OrderDate.ToString();
            txtPrice.Text = OrderDetails.ThisOrder.TotalPrice.ToString();
            txtOrderMadeBy.Text = OrderDetails.ThisOrder.OrderMadeBy;
            ddlFirstName.SelectedValue = OrderDetails.ThisOrder.CustomerID.ToString();
            ddlSurname.SelectedValue = OrderDetails.ThisOrder.CustomerID.ToString();
            ddlPhoneMake.SelectedValue = OrderDetails.ThisOrder.TariffID.ToString();
            ddlPhoneModel.SelectedValue = OrderDetails.ThisOrder.TariffID.ToString();
            ddlTariffList.SelectedValue = OrderDetails.ThisOrder.TariffID.ToString();


        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (OrderID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }
    }
}