using System;

namespace APhoneLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data memeber for the FirstName property
        private string mFirstName;
        //private data memeber for the HouseNumber property
        private string mHouseNumber;
        //private data memeber for the DOB property
        private DateTime mDOB;
        //private data memeber for the PhoneNo property
        private string mPhoneNo;
        //private data memeber for the PostCode property
        private string mPostCode;
        //private data memeber for the StreetName property
        private string mStreetName;
        //private data memeber for the Surname property
        private string mSurname;

        //public property for the customer ID
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
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }
        public string HouseNumber
        {
            get
            {
                //return the private data
                return mHouseNumber;
            }
            set
            {
                //set the value of the private data member
                mHouseNumber = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the value of the private data member
                mDOB = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data member
                mPhoneNo = value;
            }
        }
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }
        public string StreetName
        {
            get
            {
                //return the private data
                return mStreetName;
            }
            set
            {
                //set the value of the private data member
                mStreetName = value;
            }
        }
        public string Surname
        {
            get
            {
                //return the private data
                return mSurname;
            }
            set
            {
                //set the value of the private data member
                mSurname = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", customerID);
            //execute  the stored procedure
            DB.Execute("sproc_CustomerTable_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mHouseNumber = Convert.ToString(DB.DataTable.Rows[0]["HouseNumber"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mStreetName = Convert.ToString(DB.DataTable.Rows[0]["StreetName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string houseNumber, string dOB, string phoneNo, string postCode, string streetName, string surname)
        {
            //create a string varibale to store the error
            String Error = "";
            //create a temorary variable to store data values
            DateTime DateTemp;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The house cannot be blank";
            }
            //if the First Name is greater than 15 characters
            if (firstName.Length > 15)
            {
                //record the error
                Error = Error + "The First Name cannot be more than 15 characters";
            }
            //if the HouseNumber is blank
            if (houseNumber.Length == 0)
            {
                //record the error
                Error = Error + "The HpuseNumber cannot be blank";
            }
            //if the HouseNumber is greater than 5 characters
            if (houseNumber.Length > 5)
            {
                //record the error
                Error = Error + "The House Number cannot be more than 5 characters";
            }
            try
            {
                //copy the DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date";
            }
            //if the postcode is blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The PostCode cannot be blank";
            }
            //if the PostCode is greater than 7 characters
            if (postCode.Length > 7)
            {
                //record the error
                Error = Error + "PostCode cannot be more than 7 characters";
            }
            //if the StreetName is blank
            if (streetName.Length == 0)
            {
                //record the error
                Error = Error + "The StreetName cannot be blank";
            }
            //if the StreetName is less than 3 characters
            if (streetName.Length < 3)
            {
                //record the error
                Error = Error + "The Street Name cannot be less than 3 characters";
            }
            //if the StreetName is greater than 10 characters
            if (streetName.Length > 10)
            {
                //record the error
                Error = Error + "The Street Name cannot be more than 10 characters";
            }
            //if the Surname is blank
            if (surname.Length == 0)
            {
                //record the error
                Error = Error + "The Surname cannot be blank";
            }

            //if the StreetName is greater than 10 characters
            if (surname.Length > 10)
            {
                //record the error
                Error = Error + "The surname cannot be more than 10 characters";
            }
            //return any error messages
            return Error;
        }
    }


}