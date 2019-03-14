using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerTestProject
{
    [TestClass]
    public class CustomerTests
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "Bhakti";
        string HouseNumber = "20";
        string DOB = DateTime.Now.Date.ToString();
        string PhoneNo = "07876543421";
        string PostCode = "LE6 7HY";
        string StreetName = "Star City";
        string Surname = "Mistry";

        
        /// <summary>
        /// Properties
        /// </summary>
        
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

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string FirstName = "Komal";
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
            string HouseNumber = "58";
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
            DateTime DOB = DateTime.Now.Date;
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
            string PhoneNo = "07894561230";
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
            string PostCode = "LE4 8KJ";
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
            string StreetName = "Newtown Leaze";
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
            string Surname = "Mukesh";
            //assing the data to the property
            ACustomer.Surname = Surname;
            //test to see that the two vlaues are the same
            Assert.AreEqual(ACustomer.Surname, Surname);
        }

        /// <summary>
        /// Methods: Find
        /// </summary>
        /// 

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean varibale to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.FirstName != "Deon")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNumberFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.HouseNumber != "69")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.DOB !=Convert.ToDateTime("10/02/1999"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.PhoneNo != "09878675873")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.PostCode != "LE4 8KJ")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetNameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.StreetName != "Newtown Leaze")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varibale to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.Surname != "Bowen")
            {
                OK = false;
            }
            //test to see that the reult is correct
            Assert.IsTrue(OK);
        }

        /// <summary>
        /// Methods: Validations
        /// </summary>
        
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store an error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// Validation Method: First Name
        /// </summary>

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "E"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "EE"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Jeddddddd"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Montgomery"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "hgyhthdgtghdgwyg"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Komal"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Validation Method: House Number
        /// </summary>

        [TestMethod]
        public void HouseNumberMinLessOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = ""; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMin()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "2"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMinPlusOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "22"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMaxLessOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "2222"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMax()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "73647"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMaxPlusOne()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "364563"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMid()
        {
            //create an insatnce of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            //Boolean OK = false;
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNumber = "34"; //this should be ok
            //invoke the method
            //OK = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            Error = ACustomer.Valid(FirstName, HouseNumber, DOB, PhoneNo, PostCode, StreetName, Surname);
            //test to see that the result is correct
            //Assert.IsTrue(OK);
            Assert.AreEqual(Error, "");
        }

    }
}

