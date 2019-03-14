using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneTestProject
{
    //Start of Lewis' Phone tests
    [TestClass]
    public class PhoneTests
    {
        //good test data
        //create some test data to pass to the method
        string PhoneMake = "Apple";
        string PhoneModel = "8";
        string PhoneNo = "07749493578";
        string Price = "800";
        string ScreenSize = "7.4";
        string CameraQuality = "FHD";

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

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is ok
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// Attribute: Phone Make
        /// </summary>

        [TestMethod]
        public void PhoneMakeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //string varaible to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = ""; //this should trigger an error
            //invoke the method
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMin()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "a"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "aa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "aaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMid()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "aaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = "aaaaaaaaaaa"; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneMake = ""; 
            PhoneMake = PhoneMake.PadRight(250, 'a'); //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Attribute: Phone Model
        /// </summary>

        [TestMethod]
        public void PhoneModelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = ""; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMin()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "a"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "aa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "aaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMid()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "aaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "aaaaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelExtremeMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneModel = "";
            PhoneModel = PhoneModel.PadRight(250, 'a'); //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        ///<summary>
        ///Attribute: Phone Number
        ///</summary>

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = "a"; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "aa";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aaaaaaaaaa"; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aaaaaaaaaaa"; //this should be ok
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aaaaaaaaaaaa"; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aaaaaa"; //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            string Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; 
            PhoneNo = PhoneNo.PadRight(250, 'a'); //this should fail
            //invoke the method
            //OK = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            Error = APhone.Valid(PhoneMake, PhoneModel, PhoneNo, Price, ScreenSize, CameraQuality);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }
    }
}

