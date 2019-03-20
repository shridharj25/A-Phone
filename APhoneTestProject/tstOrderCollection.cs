﻿using System;
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
            //set ThisAddress to the test data
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
            //set ThisAddress to the test data
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
    }
}
