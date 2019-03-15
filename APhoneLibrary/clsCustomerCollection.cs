using System;
using APhoneLibrary;
using System.Collections.Generic;

namespace APhoneLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer { get; set; }

        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_CustomerTable_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.HouseNumber = Convert.ToString(DB.DataTable.Rows[Index]["HouseNumber"]);
                ACustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.StreetName = Convert.ToString(DB.DataTable.Rows[Index]["StreetName"]);
                ACustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }



    }
}