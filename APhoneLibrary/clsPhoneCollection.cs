using System.Collections.Generic;
using System;

namespace APhoneLibrary
{
    public class clsPhoneCollection
    {
        //private data member for this phone
        clsPhone mThisPhone = new clsPhone();

        //private data member for the list
        List<clsPhone> mPhoneList = new List<clsPhone>();

        //public property for the phone list
        public List<clsPhone> PhoneList
        {
            get
        
            {
                //return the private data 
                return mPhoneList;
            }
            set
        
            {
                //set the private data
                mPhoneList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mPhoneList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisPhone
        public clsPhone ThisPhone
        {
            get
            {
                //return the private data
                return mThisPhone;
            }
            set
            {
                //set the private data
                mThisPhone = value;
            }
        }

        public clsPhoneCollection()
        {
            //var to store index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_PhoneTable_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank phone
                clsPhone APhone = new clsPhone();
                //read in the fields from the current record
                APhone.PhoneId = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneId"]);
                APhone.Make = Convert.ToString(DB.DataTable.Rows[Index]["PhoneMake"]);
                APhone.Model = Convert.ToString(DB.DataTable.Rows[Index]["PhoneModel"]);
                APhone.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                APhone.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                APhone.ScreenSize = Convert.ToString(DB.DataTable.Rows[Index]["ScreenSize"]);
                APhone.CameraQuality = Convert.ToString(DB.DataTable.Rows[Index]["CameraQuality"]);
                //add the record to the private data member
                mPhoneList.Add(APhone);
                //point to the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisPhone
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sotred procedure
            DB.AddParameter("@PhoneMake", mThisPhone.Make);
            DB.AddParameter("@PhoneModel", mThisPhone.Model);
            DB.AddParameter("@PhoneNo", mThisPhone.PhoneNo);
            DB.AddParameter("@Price", mThisPhone.Price);
            DB.AddParameter("@ScreenSize", mThisPhone.ScreenSize);
            DB.AddParameter("@CameraQuality", mThisPhone.CameraQuality);
            //execute the stored procedure returning the primary key
            return DB.Execute("sproc_PhoneTable_Add");
        }
    }
}