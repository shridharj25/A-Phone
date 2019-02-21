using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderTestProject
{
    [TestClass]
    public class OrderTests
    {
        //Start of Shridhar's Tests
        [TestMethod]
        public void OrderInstanceOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data 
            DateTime someOrderDate = Convert.ToDateTime("01/01/2011");
            //assign the data property
            AOrder.OrderDate = someOrderDate;
            //test to see the that the two values are the same
            Assert.AreEqual(AOrder.OrderDate, someOrderDate);
        }

        [TestMethod]
        public void OrderPriceOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data 
            double somePrice = 450.0;
            //assign the data to property
            AOrder.Price = somePrice;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.Price, somePrice);
        }

        [TestMethod]
        public void PhoneOrderByOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data 
            string someOrderMadeby = "John";
            //assign the data to property
            AOrder.OrderMadeBy = someOrderMadeby;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderMadeBy, someOrderMadeby);
        }

        [TestMethod]
        public void OrderDueDateOK()
        {
            //create instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data 
            DateTime someOrderDueDate = Convert.ToDateTime("01/01/2011");
            //assign the date to property
            AOrder.OrderDueDate = someOrderDueDate;
            //test to check that the two values are equal
            Assert.AreEqual(AOrder.OrderDueDate, someOrderDueDate);
        }
        //End of Shridhar's Tests
    }
}