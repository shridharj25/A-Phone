﻿using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APhoneTestProject
{
    [TestClass]
    public class tstPhoneCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class you want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //test to see if it exists
            Assert.IsNotNull(AllPhones);
        }

        [TestMethod]
        public void PhoneListOk()
        {
            //create an instance of the class we want ot create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPhone> TestList = new List<clsPhone>();
            //add item to the list
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //set its properties 
            TestItem.PhoneId = 1;
            TestItem.Make = "Apple";
            TestItem.Model = "IPhone X";
            TestItem.PhoneNo = "07749493975";
            TestItem.Price = "500";
            TestItem.ScreenSize = "7.2";
            TestItem.CameraQuality = "FHD";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to a property
            AllPhones.PhoneList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPhones.PhoneList, TestList);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want ot create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllPhones.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllPhones.Count, SomeCount);
        }

        [TestMethod]
        public void ThisPhonePropertyOk()
        {
            //create an instance of the class we want ot create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property
            clsPhone TestPhone = new clsPhone();
            //set the properties to the test object
            TestPhone.PhoneId = 1;
            TestPhone.Make = "Apple";
            TestPhone.Model = "IPhone X";
            TestPhone.PhoneNo = "07749493975";
            TestPhone.Price = "500";
            TestPhone.ScreenSize = "7.2";
            TestPhone.CameraQuality = "FHD";
            //assign the data to the property
            AllPhones.ThisPhone = TestPhone;
            //test to see that the two values are the same
            Assert.AreEqual(AllPhones.ThisPhone, TestPhone);
        }
    }
}