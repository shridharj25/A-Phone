using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APhoneLibrary
{
    public class clsOrderCollection
    {
        //Public property for AllOrders
        public List<clsOrder> AllOrders
        {
            //getter sends data to requesting code
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

    }
}