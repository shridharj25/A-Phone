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
        public void PhoneInstanceOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //test to see that it exists
            Assert.IsNotNull(APhone);
        }

        /// <summary>
        /// Attribute: Phone Make
        /// </summary>
        
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
        public void ValidPhoneMakeOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Apple";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonMakeMinLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is not okay i.e there should be an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMinOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "A";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMinPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Ap";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMaxLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Adgshtyfy";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Adnyjrioeo";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMaxPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Abfnhdyeurj";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeMidOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Abfhy";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMakeExtremeMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someMake = "Abcjfdhejddjhffjufruhreghieurghi";
            //invoke the method
            Error = APhone.ValidPhoneMake(someMake);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Attribute: Phone Model
        /// </summary>
        
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
        public void ValidPhoneModelOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S10";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMinLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMinOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMinPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S1";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMaxLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S12345678";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is  okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S123456789";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is  okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMaxPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S1234567891";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelMidOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S1234";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneModelExtremeMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someModel = "S1234567891dthdthgrggfserfge";
            //invoke the method
            Error = APhone.ValidPhoneModel(someModel);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Attribute: Phone No
        /// </summary>
        
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
        public void ValidPhoneNoOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "07749493975";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "0";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "07";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "0774949397";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "07749493975";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOneOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "077494939756";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMidOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "07749493";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMaxOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string somePhoneNo = "07749493975428645186256";
            //invoke the method
            Error = APhone.ValidPhoneNo(somePhoneNo);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Attribute: Phone Price
        /// </summary>

        [TestMethod]
        public void PhonePriceOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create some test data 
            string somePrice = "500";
            //assign the data to property
            APhone.Price = somePrice;
            //test to see that the two values are the same
            Assert.AreEqual(APhone.Price, somePrice);
        }

        //[TestMethod]
        //public void ValidPhonePriceOK()
        //{
        //    //create an instance of the class
        //    clsPhone APhone = new clsPhone();
        //    //create a string to store the result of the validation
        //    String Error = "";
        //    //create some test data 
        //    string somePhonePrice = "500";
        //    //invoke the method
        //    Error = APhone.ValidPhonePrice(somePhonePrice);
        //    //test to see that the result is okay i.e there was no error message 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void PhonePriceMinLessOneOK()
        //{
        //    //create an instance of the class
        //    clsPhone APhone = new clsPhone();
        //    //create a string to store the result of the validation
        //    String Error = "";
        //    //create some test data 
        //    string somePhonePrice = "";
        //    //invoke the method
        //    Error = APhone.ValidPhonePrice(somePhonePrice);
        //    //test to see that the result is not okay i.e there was an error message 
        //    Assert.AreNotEqual(Error, "");
        //}

        /// <summary>
        /// Attribute: Screen Size
        /// </summary>

        //[TestMethod]
        //public void PhoneScreenSizeOk()
        //{
        //    //create an instance of the class
        //    clsPhone APhone = new clsPhone();
        //    //create some test data 
        //    string someScreenSize = 5.6;
        //    //assign the data to property
        //    APhone.ScreenSize = someScreenSize;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(APhone.ScreenSize, someScreenSize);
        //}

        /// <summary>
        /// Attribute: Camera Quality
        /// </summary>

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
        public void ValidCameraQualityOK()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "15";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMinLessOneOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMinOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "1";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMinPlusOneOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "12";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMidOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "123";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMaxLessOneOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "1234";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMaxOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "12345";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is okay i.e there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMaxPlusOneOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "123456";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityExtremeMaxOk()
        {
            //create an instance of the class
            clsPhone APhone = new clsPhone();
            //create a string to store the result of the validation
            String Error = "";
            //create some test data 
            string someCameraQuality = "123456789123456789";
            //invoke the method
            Error = APhone.ValidPhoneCameraQuality(someCameraQuality);
            //test to see that the result is not okay i.e there was an error message 
            Assert.AreNotEqual(Error, "");
        }
        //End of Lewis' Phone tests
    }
}

