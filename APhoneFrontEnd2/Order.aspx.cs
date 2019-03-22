using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APhoneFrontEnd2
{
    public partial class Order : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayOrders();
            }
        }

        void DisplayOrders()
        {
            //create an instance of the County Collection
            APhoneLibrary.clsOrderCollection Orders = new APhoneLibrary.clsOrderCollection();
            //set the data source to the list of counties in the collection
            lstOrders.DataSource = Orders.OrdersList;
            //set the name of the primary key
            lstOrders.DataValueField = "OrderID";
            //set the data field to display
            lstOrders.DataTextField = "OrderMadeBy";
            //bind the data to the list
            lstOrders.DataBind();
        }

        //event handler for the add button 
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 iunto the session object to indicate a new record
            Session["OrderId"] = -1;
            //Redirect to the data entry page 
            Response.Redirect("AnOrder.Aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 OrderID;
            //if a record has been selected from the list
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderID = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the session object
                Session["OrderID"] = OrderID;
                //redirect to the delete page
                Response.Redirect("DeleteOrder.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 OrderID;
            //if a record has been selected from the list
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                OrderID = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the session object
                Session["OrderID"] = OrderID;
                //redirect to the edit page
                Response.Redirect("AnOrder.aspx");
            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

     
    }
    
}