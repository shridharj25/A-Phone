using System.Collections.Generic;

namespace APhoneLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the allCustomers list
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllCustomers.Count;
            }
            set
            {
                
            }
        }

        //public propety for allCustomers
        public List<clsCustomer> AllCustomers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data number
                return mAllCustomers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCustomers = value;
            }
        }

        //public constructor for the class
        public clsCustomerCollection()
        {
            //create an instance of the customer class to store a customer
            clsCustomer ACustomer = new clsCustomer();
            //set the customer to John
            ACustomer.FirstName = "John";
            //add the customer to the private list of customers
            mAllCustomers.Add(ACustomer);
            //re initialise the ACustomer object to accept a new item
            ACustomer = new clsCustomer();
            //set the customer to Komal
            ACustomer.FirstName = "Komal";
            //add the second customer to the private list of customers
            mAllCustomers.Add(ACustomer);
            //the private list now contains two customers
        }
        //public int Count { get; set; }
        //public List<clsCustomer> AllCustomers { get; set; }
    }
}