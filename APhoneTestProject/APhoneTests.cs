using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APhoneTestProject
{
    //Start of Lewis' Phone tests
    [TestClass]
    public class APhoneTests
    {
       [TestMethod]
        public void PhoneInstanceOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //test to see that it exists
            Assert.IsNotNull(APhone);
        }

        [TestMethod]
        public void PhoneMakeOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            string someMake = "Samsung";
            //assign the data to property
            APhone.Make = someMake;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.Make, someMake);
        }

        [TestMethod]
        public void PhoneModelOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            string someModel = "S8";
            //assign the data to property
            APhone.Model = someModel;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.Model, someModel);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            string somePhoneNo = "07749493975";
            //assign the data to property
            APhone.PhoneNo = somePhoneNo;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.PhoneNo, somePhoneNo);
        }

        [TestMethod]
        public void PhonePriceOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            double somePrice = 500.0;
            //assign the data to property
            APhone.Price = somePrice;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.Price, somePrice);
        }

        [TestMethod]
        public void PhoneScreenSizeOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            double someScreenSize = 5.6;
            //assign the data to property
            APhone.ScreenSize = someScreenSize;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.ScreenSize, someScreenSize);
        }

        [TestMethod]
        public void PhoneCameraQualityOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            string someCameraQuality = "12";
            //assign the data to property
            APhone.CameraQuality = someCameraQuality;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.CameraQuality, someCameraQuality);
        }
        //End of Lewis' Phone tests

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

