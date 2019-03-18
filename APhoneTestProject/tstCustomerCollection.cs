﻿using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APhoneTestProject
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item of test data
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Komal";
            TestItem.HouseNumber = "20";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "07867543762";
            TestItem.PostCode = "LE5 6HY";
            TestItem.StreetName = "Star City";
            TestItem.Surname = "Mukesh";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Komal";
            TestCustomer.HouseNumber = "20";
            TestCustomer.DOB = DateTime.Now.Date;
            TestCustomer.PhoneNo = "07867543762";
            TestCustomer.PostCode = "LE5 6HY";
            TestCustomer.StreetName = "Star City";
            TestCustomer.Surname = "Mukesh";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two vlaues are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data to assign needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Komal";
            TestItem.HouseNumber = "20";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "07867543762";
            TestItem.PostCode = "LE5 6HY";
            TestItem.StreetName = "Star City";
            TestItem.Surname = "Mukesh";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Komal";
            TestItem.HouseNumber = "20";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "07867543762";
            TestItem.PostCode = "LE5 6HY";
            TestItem.StreetName = "Star City";
            TestItem.Surname = "Mukesh";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

    }
}
