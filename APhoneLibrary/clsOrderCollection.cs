using System.Collections.Generic;

namespace APhoneLibrary
{
    public class clsOrderCollection
    {
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
        public int Count
        {
            //getter sends data to requesting code
            get
            {
                //return the count property of the private list
                return mAllOrders.Count;
            }
            //setter accepts data from other objects
            set
            {

            }

        }

        List<clsOrder> mOrdersList = new List<clsOrder>();
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

        public clsOrder ThisOrder { get; set; }
    }
}