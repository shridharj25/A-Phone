using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APhoneLibrary
{
    public class clsOrderCollection
    {
        public List<clsOrder> AllOrders
        {
            get
            {
                return mAllOrders;
            }
            set
            {
                //assigning the incoming value to the private data memeber
                mAllOrders = value;
            }
        }

        // Private data memeber for allOrders List
        private List<clsOrder> mAllOrders = new List<clsOrder>();

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllOrders.Count;
            }
            set
            {
                
            }

        }

    }
}