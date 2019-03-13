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
            //set the private data memebr to test the data value
            mOrderID = 5;
            mCustomerID = 1;
            mPhoneID = 1;
            mTariffID = 1;
            mTotalPrice = 700;
            mOrderMadeBy = "Jhon";
            mOrderDate = Convert.ToDateTime("12/01/2009");
            //always return true
            return true;
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
