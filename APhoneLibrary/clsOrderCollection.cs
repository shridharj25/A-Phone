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
        //public constructor for the class
       public clsOrderCollection()
       {
            //creating an instance of the order class to store a order
            clsOrder AOrder = new clsOrder();
            //set the order to Jhon
            AOrder.Order = "Jhon";
            //add the order to the private list of counties
            mAllOrders.Add(AOrder);
            //re initalise the AOrder object to accept a new item
            AOrder = new clsOrder();
            //set the order to Jhon
            AOrder.Order = "Bob";
            //add the second order to the private list of orders
            mAllOrders.Add(AOrder);
            //the private list now contains two orders

        }
    }
    
}