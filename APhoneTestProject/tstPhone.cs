using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneTestProject
{
    //Start of Lewis' Phone tests
    [TestClass]
    public class PhoneTests
    {
       [TestMethod]
       public void InstanceOk()
       {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //test to see if that exists
            Assert.IsNotNull(APhone);
       }

       [TestMethod]
       public void PhoneIdPropertyOk()
       {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APhone.PhoneId = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.PhoneId, TestData);
       }

       [TestMethod]
       public void PhoneMakePropertyOk()
       {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "Samsung";
            //assign the data to the property
            APhone.Make = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.Make, TestData);
       }

        [TestMethod]
        public void PhoneModelPropertyOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "S10";
            //assign the data to the property
            APhone.Model = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.Model, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "07749493975";
            //assign the data to the property
            APhone.PhoneNo = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.PhoneNo, TestData);
        }

        [TestMethod]
        public void PhonePricePropertyOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "500";
            //assign the data to the property
            APhone.Price = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.Price, TestData);
        }

        [TestMethod]
        public void PhoneScreenSizePropertyOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "7.2";
            //assign the data to the property
            APhone.ScreenSize = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.ScreenSize, TestData);
        }

        [TestMethod]
        public void PhoneCameraQualityPropertyOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "HD";
            //assign the data to the property
            APhone.CameraQuality = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(APhone.CameraQuality, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create the test data to use with the method
            Int32 PhoneId = 1;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPhoneIdFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.PhoneId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneMakeFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.Make != "Samsung")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneModelFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.Model != "S10")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.PhoneNo != "07749493975")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhonePriceFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.Price != "500")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneScreenSizeFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.ScreenSize != "7")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneCameraQualityFound()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //boolean variable for storing the result of the search
            Boolean Found = false;
            //boolean varibale to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneId = 2;
            //invoke the method
            Found = APhone.Find(PhoneId);
            //check the property
            if (APhone.CameraQuality != "HD")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

