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
        public void CustomerDOBOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime DOB = Convert.ToDateTime("01/01/2011");
            //assign the data to the property
            ACustomer.DOB = DOB;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DOB, DOB);
        }

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
        //End of Komal's tests
    }
}

