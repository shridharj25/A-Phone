using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APhoneLibrary
{
    public class clsOrder
    {
        //public variable for OrderDate
        private DateTime mOrderDate;
        //private variable to store Order
        private Int32 mOrderID;
        //public variable for OrderrMadeBy
        private string mOrderMadeBy;
        //public variable for OrderDueDate
        //public DateTime OrderDueDate { get; set; }
        //public variable for CustomerID
        private Int32 mCustomerID;
        //public variable for OrderID
        private Int32 mPhoneID;
        //public variable for TariffID
        private Int32 mTariffID;
        //private variable for TariffID
        private Decimal mTotalPrice;

        public bool Find(int OrderID)
        {
            ////set the private data memebr to test the data value
            //mOrderID = 5;
            //mCustomerID = 1;
            //mPhoneID = 1;
            //mTariffID = 1;
            //mTotalPrice = 700;
            //mOrderMadeBy = "Jhon";
            //mOrderDate = Convert.ToDateTime("12/01/2009");
            ////always return true
            //return true;

            //creating an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //executing the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero)
            if (DB.Count ==1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                mTariffID = Convert.ToInt32(DB.DataTable.Rows[0]["TariffID"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mOrderMadeBy = Convert.ToString(DB.DataTable.Rows[0]["OrderMadeBy"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        //public property for the OrderID
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
        //public property for the OrderDate
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }
        //public property for the OrderID
       
        public string OrderMadeBy
        {
            get
            {
                //return the private data
                return mOrderMadeBy;
            }
            set
            {
                //set the value of the private data member
                mOrderMadeBy = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        public int PhoneID
        {
            get
            {
                //return the private data
                return mPhoneID;
            }
            set
            {
                //set the value of the private data member
                mPhoneID = value;
            }
        }
        public int TariffID
        {
            get
            {
                //return the private data
                return mTariffID;
            }
            set
            {
                //set the value of the private data member
                mTariffID = value;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }
            set
            {
                //set the value of the private data member
                mTotalPrice = value;
            }
        }

        public string Valid(string orderDate, string orderMadeBy, string totalPrice, string orderID, string customerID, string phoneID, string tariffID)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //If the ordermadeby is blank
            if (orderMadeBy.Length == 0)
            {
                //record the error
                Error = Error + "The OrderMadeBy may not be blank :";
            }
            //if the OrderMadeBy is greater than 50
            if (orderMadeBy.Length > 50)
            {
                Error = Error + "The OrderMadeBy must be less than 50: ";
            }
            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            try
            {
                Int32 OrderIDTemp = Convert.ToInt32(orderID);
                if(OrderIDTemp == 0)
                {
                    //restore the error
                    Error = Error + "The OrderID cannot be blank";
                }

            }
            catch
            {
                Error = Error + "The OrderID is not a number";
            }
            //return any error messages
            return Error;
        }

    }



          
   

        //public string Valid(string someOrderMadeby)
        //{
        //    //string variable to store the error message
        //    string Error = "";
        //    //if the name of the OrderMadeby is more than 20
        //    if (someOrderMadeby.Length > 21)

        //    {
        //        //return blank string
        //        Error = "The Order Made By cannot have more than 20 Characters";
        //    }
        //    if (someOrderMadeby.Length == 0)
        //    {
        //        //return an error message
        //        Error = "The Order Made By cannot be blank!";
        //    }

        //    return Error;
        //}

        //public string ValidPhoneOrderMax(string someOrderMadeby)
        //{
        //    //string variable to store the error message
        //    string Error = "";
        //    //if the name of the OrderMadeby is more than 20
        //    if (someOrderMadeby.Length > 50)

        //    {
        //        //return blank string
        //        Error = "The Order Made By cannot have more than 20 Characters";
        //    }
        //    if (someOrderMadeby.Length == 0)
        //    {
        //        //return an error message
        //        Error = "The Order Made By cannot be blank!";
        //    }

        //    return Error;
        //}

        //public string ValidOrderPrice(decimal someOrderPrice)
        //{
        //    //string variable to store the error message
        //    string Error = "";
        //    //if the name of the OrderMadeby is more than 1100
        //    if (someOrderPrice > 1100)

        //    {
        //        //return blank string
        //        Error = "The Order Price cannot be more than 1100";
        //    }
        //    if (someOrderPrice == 0)
        //    {
        //        //return an error message
        //        Error = "The Order Price cannot be blank!";
        //    }

        //    return Error;
        //}


    
}
