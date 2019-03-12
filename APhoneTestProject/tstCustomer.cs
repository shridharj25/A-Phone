using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerTestProject
{
    [TestClass]
    public class CustomerTests
    {
        //Start of Komal's Tests
        [TestMethod]
        public void CustomerInstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 SomeCustomerID = 1;
            //assign the data to the property
            ACustomer.CustomerID = SomeCustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, SomeCustomerID);
        }

        /// <summary>
        /// Arrtibute: First Name
        /// </summary>

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string FirstName = "Montgomery";
            //assign the data to the property
            ACustomer.FirstName = FirstName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, FirstName);
        }

        [TestMethod]
        public void ValidCustomerFirstNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "Billy";
            //invoke the method
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "A";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "An";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "Jeddddddd";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "Annnnnnnnn";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "agshrughtjfghttt";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "Komal";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "Taumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitanatahu";
            //invoke the mothod
            Error = ACustomer.ValidCustomerFirstName(SomeFirstName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: House Number
        /// </summary>

        [TestMethod]
        public void CustomerHouseNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 HouseNumber = 5;
            //assign the data to the property
            ACustomer.HouseNumber = HouseNumber;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNumber, HouseNumber);
        }

        [TestMethod]
        public void ValidCustomerHouseNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "28D";
            //invoke the method
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "1";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "22";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberMaxLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "6662";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "78564";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNumberExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeHouseNumber = "1f25g7h456fgh56j87ht";
            //invoke the mothod
            Error = ACustomer.ValidCustomerHouseNumber(SomeHouseNumber);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: DOB
        /// </summary>

        [TestMethod]
        public void CustomerDOBOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime DOB = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DOB = DOB;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DOB, DOB);
        }

        [TestMethod]
        public void ValidCustomerDOBOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            DateTime SomeDOB = DateTime.Now.Date; ;
            //invoke the method
            Error = ACustomer.ValidCustomerDOB(SomeDOB);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            DateTime SomeDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            SomeDOB = SomeDOB.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = SomeDOB.ToString();
            //invoke the method
            Error = ACustomer.ValidCustomerDOB(SomeDOB);
            //test to see that the result is OK i.e there was a error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            DateTime SomeDOB = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = SomeDOB.ToString();
            //invoke the method
            Error = ACustomer.ValidCustomerDOB(SomeDOB);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            DateTime SomeDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            SomeDOB = SomeDOB.AddDays(1);
            //convert the date variable to a string variable
            string DOB = SomeDOB.ToString();
            //invoke the method
            Error = ACustomer.ValidCustomerDOB(SomeDOB);
            //test to see that the result is OK i.e there was a error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            DateTime SomeDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            SomeDOB = SomeDOB.AddYears(1000);
            //convert the date variable to a string variable
            string DOB = SomeDOB.ToString();
            //invoke the method
            Error = ACustomer.ValidCustomerDOB(SomeDOB);
            //test to see that the result is OK i.e there was a error message returned
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: PhoneNo
        /// </summary>

        [TestMethod]
        public void CustomerPhoneNoOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string PhoneNo = "07632736472";
            //assign the data to the property
            ACustomer.PhoneNo = PhoneNo;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, PhoneNo);
        }

        [TestMethod]
        public void ValidCustomerPhoneNoOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result to the validation
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "088765342128764";
            //invoke the method
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "088765";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "0887653";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "08876534";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "08876534212876";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "0887653421287644";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "0887653";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPhoneNoExtremeMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePhoneNo = "08876534212876485746";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPhoneNo(SomePhoneNo);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: PostCode
        /// </summary>

        [TestMethod]
        public void CustomerPostCodeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string PostCode = "LE678MT";
            //assign the data to the property
            ACustomer.PostCode = PostCode;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, PostCode);
        }

        [TestMethod]
        public void ValidCustomerPostCodeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result to the validation
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MT";
            //invoke the method
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678M";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MT";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MTy";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678M";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MT";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MTY";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMideOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE5";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeExtremeMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomePostCode = "LE678MTY56";
            //invoke the mothod
            Error = ACustomer.ValidCustomerPostCode(SomePostCode);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: Street Name
        /// </summary>

        [TestMethod]
        public void CustomerStreetNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string StreetName = "AthenePLace";
            //assign the data to the property
            ACustomer.StreetName = StreetName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.StreetName, StreetName);
        }

        [TestMethod]
        public void ValidCustomerStreetNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result to the validation
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "LE56IM";
            //invoke the method
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "g2";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "ggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "gggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMaxLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "ggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "gggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameMaxPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "ggggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetNameExtremeMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeStreetName = "uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu";
            //invoke the mothod
            Error = ACustomer.ValidCustomerStreetName(SomeStreetName);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Arrtibute: Surname
        /// </summary>

        [TestMethod]
        public void CustomerSurnameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string Surname = "Fairclough";
            //assing the data to the property
            ACustomer.Surname = Surname;
            //test to see that the two vlaues are the same
            Assert.AreEqual(ACustomer.Surname, Surname);
        }

        [TestMethod]
        public void ValidCustomerSurnameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result to the validation
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "LE56IM";
            //invoke the method
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "gg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "ggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "gggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxLessOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "ggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "ggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxPlusOneOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "ggggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "ggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should not be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameExtremeMaxeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeSurname = "gggggggggggggggggggggggggggggggggggggggggggggggggg";
            //invoke the mothod
            Error = ACustomer.ValidCustomerSurname(SomeSurname);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        //End of Komal's tests
    }
}

