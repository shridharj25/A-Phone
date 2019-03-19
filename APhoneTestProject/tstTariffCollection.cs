using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APhoneTestProject
{
    [TestClass]
    public class tstTariffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class we want to create
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTariffs);
        }

        [TestMethod]
        public void TariffListOK()
        {
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTariff> TestList = new List<clsTariff>();
            //add an item to the list
            //create the item of test data
            clsTariff TestItem = new clsTariff();
            //set its properties
            TestItem.Active = true;
            TestItem.TariffID = 1;
            TestItem.Texts = "500";
            TestItem.Calls = "Unlimited";
            TestItem.Data = "20GB";
            TestItem.Network = "O2";
            TestItem.Price = 30.00m;
            TestItem.Upfront = 50.00m;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTariffs.TariffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTariffs.TariffList, TestList);
        }

        /* No Longer Needed
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllTariffs.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllTariffs.Count, SomeCount);
        } */

        [TestMethod]
        public void ThisTariffPropertyOK()
        {
            //create an instance of the class
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //create some test data to assign to the property
            clsTariff TestTariff = new clsTariff();
            //set the properties of the test object
            TestTariff.Active = true;
            TestTariff.TariffID = 1;
            TestTariff.Texts = "2000";
            TestTariff.Calls = "Unlimited";
            TestTariff.Data = "50GB";
            TestTariff.Network = "Vodafone";
            TestTariff.Price = 15.99m;
            TestTariff.Upfront = 10.00m;
            //assign the data to the property
            AllTariffs.ThisTariff = TestTariff;
            //test to see that the two values are the same
            Assert.AreEqual(AllTariffs.ThisTariff, TestTariff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTariff> TestList = new List<clsTariff>();
            //add an item to the list
            //create the item of test data
            clsTariff TestItem = new clsTariff();
            //set its properties
            TestItem.Active = true;
            TestItem.TariffID = 1;
            TestItem.Texts = "500";
            TestItem.Calls = "Unlimited";
            TestItem.Data = "20GB";
            TestItem.Network = "O2";
            TestItem.Price = 30.00m;
            TestItem.Upfront = 50.00m;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTariffs.TariffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTariffs.Count, TestList.Count);
        }

        /* No longer Needed
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create 
            clsTariffCollection AllTariffs = new clsTariffCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllTariffs.Count, 2);
        } */
    }
}
