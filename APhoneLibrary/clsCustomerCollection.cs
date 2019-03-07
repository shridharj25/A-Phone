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
        //public int Count { get; set; }
        //public List<clsCustomer> AllCustomers { get; set; }
    }
}