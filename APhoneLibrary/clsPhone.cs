using System;

namespace APhoneLibrary
{
    public class clsPhone
    {
        //private data member for all attributes
        private int mPhoneId;
        private string mMake;
        private string mModel;
        private string mPhoneNo;
        private string mPrice;
        private string mScreenSize;
        private string mCameraQuality;

        //public property for phone id
        public int PhoneId
        {
            get
            {
                //return the private data
                return mPhoneId;
            }
            set
            {
                //set the private data
                mPhoneId = value;
            }
        }

        //public property for make
        public string Make
        {
            get
            {
                //return the private data
                return mMake;
            }
            set
            {
                //set the private data
                mMake = value;
            }
        }

        //public property for model
        public string Model
        {
            get
            {
                //return the private data
                return mModel;
            }
            set
            {
                //set the private data
                mModel = value;
            }
        }

        //public property for phone number
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the private data
                mPhoneNo = value;
            }
        }

        //public property for price
        public string Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //public property for Screen size
        public string ScreenSize
        {
            get
            {
                //return the private data
                return mScreenSize;
            }
            set
            {
                //set the private data
                mScreenSize = value;
            }
        }

        //public property for camera quality
        public string CameraQuality
        {
            get
            {
                //return the private data
                return mCameraQuality;
            }
            set
            {
                //set the private data
                mCameraQuality = value;
            }
        }

        public bool Find(int phoneId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the phone id to search for
            DB.AddParameter("@PhoneId", phoneId);
            //execute the stored procedure
            DB.Execute("sproc_PhoneTable_FilterByPhoneId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPhoneId = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneId"]);
                mMake = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mScreenSize = Convert.ToString(DB.DataTable.Rows[0]["ScreenSize"]);
                mCameraQuality = Convert.ToString(DB.DataTable.Rows[0]["CameraQuality"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
    }
}