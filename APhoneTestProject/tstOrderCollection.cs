using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APhoneTestProject
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //creating test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
        [TestMethod]

        public void AllOrderListOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection Orders = new clsOrderCollection();
            //creating some test data to assign to the property
            //data in this case would be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //creating item of test data
            clsOrder TestItem = new clsOrder();
            //setting its properties
            TestItem.OrderID = 1;
            TestItem.OrderMadeBy = "Jhon";
            //adding the item to the test list
            TestList.Add(TestItem);
            //assigning the data to the property
            Orders.AllOrders = TestList;
            //testing to see if the two values are the same
            Assert.AreEqual(Orders.AllOrders, TestList);
            


        }


    }
   

}
