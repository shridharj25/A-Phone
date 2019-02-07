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
        public void InstanceOK()
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

        [TestMethod]
        public void PhoneIdOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            int somePhoneId = 1;
            //assign the data to property
            APhone.PhoneId = somePhoneId;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.PhoneId, somePhoneId);
        }
        //End of Lewis' Phone tests
    }
}

