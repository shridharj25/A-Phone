using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderTestProject
{
    [TestClass]
    public class OrderTests
    {
        //good test data
        //creating some test data to pass to the method
        //string OrderID = "1";
        //string CustomerID = "1";
        //string PhoneID = "1";
        //string TariffID = "1";
        string OrderMadeBy = "Jhon";
        string TotalPrice = "700";
        string OrderDate = DateTime.Now.Date.ToString();
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
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.PhoneID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PhoneID, TestData);
        }
        [TestMethod]
        public void TariffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.TariffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TariffID, TestData);
        }
        [TestMethod]
        public void OrderMadeByPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Jhon";
            //assign the data to the property
            AnOrder.OrderMadeBy = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderMadeBy, TestData);
        }
        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = Convert.ToDecimal("750.0");
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //creating some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 5;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the OrderID
            if (AnOrder.OrderID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnOrder.Find(CustomerID);
            //check the CustomerID no
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TariffIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TariffID = 1;
            //invoke the method
            Found = AnOrder.Find(TariffID);
            //check the TariffID
            if (AnOrder.TariffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PhoneIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PhoneID = 1;
            //invoke the method
            Found = AnOrder.Find(PhoneID);
            //check the Phone no
            if (AnOrder.PhoneID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the Phone no
            if (AnOrder.TotalPrice != 700)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderMadeByFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the Phone no
            if (AnOrder.OrderMadeBy != "Jhon")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the  no
            if (AnOrder.OrderDate != Convert.ToDateTime("12/01/2009"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void OrderIDByMinLessOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string OrderID = "";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreNotEqual(Error, "");

        //}
        //[TestMethod]
        //public void OrderIDByMin()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string OrderID = "1";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void OrderIDByMinPlusOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string OrderID = "12";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void CustomerIDByMinLessOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string CustomerID = "";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void CustomerIDByMin()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string CustomerID = "1";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void CustomerIDByMinPlusOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string CustomerID = "12";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void PhoneIDByMinLessOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string PhoneID = "";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void PhoneIDByMin()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string PhoneID = "1";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void PhoneIDByMinPlusOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string PhoneID = "12";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //public void TariffIDByMinLessOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string TariffID = "";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreNotEqual(Error, "");

        //}
        //[TestMethod]
        //public void TariffIDByMin()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string TariffID = "1";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void TariffIDByMinPlusOne()
        //{
        //    //create an instance of the class
        //    clsOrder AnOrder = new clsOrder();
        //    //create a string variable to store the result of the validation
        //    string Error = "";
        //    //Boolean OK = false;
        //    //creating test data to test the method
        //    string TariffID = "12";
        //    //Invoke the method
        //    //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
        //    //test to see if the result is OK 
        //    Assert.AreEqual(Error, "");

        //}
        [TestMethod]
        public void OrderMadeByMinLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //creating test data to test the method
            string OrderMadeBy = "";
            //Invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderMadeByMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "j";
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreEqual(Error, "");
         
        }

        [TestMethod]
        public void OrderMadeByMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "jj";
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderMadeByMaxLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "";
            OrderMadeBy = OrderMadeBy.PadRight(49, 'j');
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderMadeByMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "";
            OrderMadeBy = OrderMadeBy.PadRight(50, 'j');
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderMadeByMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "";
            OrderMadeBy = OrderMadeBy.PadRight(51, 'j');
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderMadeByMid()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "";
            OrderMadeBy = OrderMadeBy.PadRight(25, 'j');
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderMadeByExteremeMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            string Error = "";
            //Boolean OK = false;
            //creating test data to test the method
            string OrderMadeBy = "";
            OrderMadeBy = OrderMadeBy.PadRight(100, 'j');
            //Invoke the method
            //OK = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see if the result is OK 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-50);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(50);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderMadeBy, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
      
        //End of Shridhar's Tests
    }
}