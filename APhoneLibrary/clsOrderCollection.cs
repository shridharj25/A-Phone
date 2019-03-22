using System.Collections.Generic;
using System;

namespace APhoneLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrdersList = new List<clsOrder>();
        //private data member thisAddress
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
            

            ////Create an instance of the class i want to create
            //clsOrder TestItem = new clsOrder();
            ////setting its properties
            //TestItem.OrderID = 1;
            //TestItem.CustomerID = 1;
            //TestItem.PhoneID = 1;
            //TestItem.TariffID = 1;
            //TestItem.OrderMadeBy = "Jhon";
            //TestItem.OrderDate = DateTime.Now.Date;
            //TestItem.TotalPrice = 700;
            ////adding the item to the test list
            //mOrdersList.Add(TestItem);
            ////re initialise the object for some new data
            //TestItem = new clsOrder();
            //TestItem.OrderID = 2;
            //TestItem.CustomerID = 2;
            //TestItem.PhoneID = 2;
            //TestItem.TariffID = 1;
            //TestItem.OrderMadeBy = "Bob";
            //TestItem.OrderDate = DateTime.Now.Date;
            //TestItem.TotalPrice = 750;
            ////adding the item to the test list
            //mOrdersList.Add(TestItem);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                //creating an instance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //executing the stored procedure
                DB.Execute("sproc_OrderTable_SelectAll");
                PopulateArray(DB);
            }

            void PopulateArray(clsDataConnection DB)
            {
                //var for the index
                Int32 Index = 0;
                //Var to store the record count
                Int32 RecordCount = 0;
                //creating an instance of the data connection
                //clsDataConnection DB = new clsDataConnection();
                //executing the stored procedure
                //DB.Execute("sproc_OrderTable_SelectAll");
                //get the count of records
                RecordCount = DB.Count;
                //while there are records to process 
                while (Index < RecordCount)
                {
                    //create a blank order
                    clsOrder AnOrder = new clsOrder();
                    //read in the fields from the current record
                    AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                    AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    AnOrder.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                    AnOrder.TariffID = Convert.ToInt32(DB.DataTable.Rows[Index]["TariffID"]);
                    AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                    AnOrder.OrderMadeBy = Convert.ToString(DB.DataTable.Rows[Index]["OrderMadeBy"]);
                    AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);

                    //add the record to the private data member
                    mOrdersList.Add(AnOrder);
                    //point at the next record
                    Index++;

                }

            }
  

        //Public property for AllOrders
        public List<clsOrder> AllOrders
        {
            //getter sends the data to the requesing code 
            get
            {
                //return the count property of the private list
                return mAllOrders;
            }
            //setter accepts data from other objects
            set
            {
                //assigning the incoming value to the private data memeber
                mAllOrders = value;
            }
        }

        // Private data memeber for allOrders List
        private List<clsOrder> mAllOrders = new List<clsOrder>();
        //public property for Count
        //public int Count
        //{
        //    //getter sends data to requesting code
        //    get
        //    {
        //        //return the count property of the private list
        //        return mAllOrders.Count;
        //    }
        //    //setter accepts data from other objects
        //    set
        //    {

        //    }

        //}

       // List<clsOrder> mOrdersList = new List<clsOrder>();
        public List <clsOrder> OrdersList
        {
            //getter sends data to requesting code
            get
            {
                
                return mOrdersList;
            }
            //setter accepts data from other objects
            set
            {
                //set the private data
                mOrdersList = value;
            }

        }

        public int Count
        {
            //getter sends data to requesting code
            get
            {
                //return the count property of the private list
                return mOrdersList.Count;
            }
            //setter accepts data from other objects
            set
            {

            }

        }

        public clsOrder ThisOrder 
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

            public int Add()
            {
            //adds a new record to the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
           // set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@PhoneID", mThisOrder.PhoneID);
            DB.AddParameter("@TariffID", mThisOrder.TariffID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderMadeBy", mThisOrder.OrderMadeBy);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            //execute the query returning the primary key value
            return DB.Execute("sproc_OrderTable_Insert");

            //mThisOrder.OrderID = 6;
            //return mThisOrder.OrderID;
        }
        public void Delete()
        {
            //deletes the record pointed to by This Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_OrderTable_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@PhoneID", mThisOrder.PhoneID);
            DB.AddParameter("@TariffID", mThisOrder.TariffID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderMadeBy", mThisOrder.OrderMadeBy);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            //execute the query returning the primary key value
            DB.Execute("sproc_OrderTable_Update");

        }

        public void ReportByOrderMadeBy(string OrderMadeBy)
        {
            //filters the records based on a full or partial Name of who made the order
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the order made by parameter to the databse
            DB.AddParameter("@OrderMadeBy", OrderMadeBy);
            //execute the stored procedure
            DB.Execute("sproc_OrderTable_FilterByOrderMadeBy");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}

    
