using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APhoneTestProject
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //Create an instance of the class i want to create
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    //creating test data to assign to the property
        //    Int32 SomeCount = 3;
        //    //assign the data to the property 
        //    AllOrders.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllOrders.Count, SomeCount);
        //}
        [TestMethod]

        public void AllOrderListOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //creating some test data to assign to the property
            //data in this case would be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //creating item of test data
            clsOrder TestItem = new clsOrder();
            //setting its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Jhon";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //adding the item to the test list
            TestList.Add(TestItem);
            //assigning the data to the property
            AllOrders.OrdersList = TestList;
            //testing to see if the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void ThisAddresssPropertyOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //creating some test data to assign to the property

            clsOrder TestOrders = new clsOrder();

            //setting its properties
            TestOrders.OrderID = 1;
            TestOrders.CustomerID = 1;
            TestOrders.PhoneID = 1;
            TestOrders.TariffID = 1;
            TestOrders.OrderMadeBy = "Jhon";
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.TotalPrice = 700;
            //assigning the data to the property
            AllOrders.ThisOrder = TestOrders;
            //testing to see if the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class i want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //creating some test data to assign to the property
            //data in this case would be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //creating item of test data
            clsOrder TestItem = new clsOrder();
            //setting its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Jhon";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //adding the item to the test list
            TestList.Add(TestItem);
            //assigning the data to the property
            AllOrders.OrdersList = TestList;
            //testing to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        //public void TwoRecordsPresent()
        //{
        //    //Create an instance of the class i want to create
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllOrders.Count, 7);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Jhon";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Jhon";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Jhon";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.PhoneID = 1;
            TestItem.TariffID = 1;
            TestItem.OrderMadeBy = "Rob";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 700;
            //Set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void ReportByOrderMadeByOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FillteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records);
            FillteredOrders.ReportByOrderMadeBy("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FillteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderMadeByNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FillteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records);
            FillteredOrders.ReportByOrderMadeBy("xxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FillteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderMadeFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredAddresses = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredAddresses.ReportByOrderMadeBy("yyy yyy");
            //check that the correct number of records are found
            if (FilteredAddresses.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredAddresses.OrdersList[0].OrderID != 6)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredAddresses.OrdersList[1].OrderID != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }

}

