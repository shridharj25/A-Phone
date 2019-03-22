using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TariffTestProject
{
    [TestClass]
    public class TariffTests
    {
        //Start Of Connor's Tests

        //Good test data
        string TariffTexts = "200";
        string TariffCalls = "Unlimited";
        string TariffData = "10GB";
        string TariffNetwork = "O2";
        decimal TariffPrice = 15.99m;
        decimal TariffUpfront = 0.00m;

        [TestMethod]
        public void TariffInstanceOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //test to see that it exists
            Assert.IsNotNull(ATariff);
        }

        [TestMethod]
        public void TariffCallsOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string callLimit = "Unlimited";
            //assign the data to property
            ATariff.TariffCalls = callLimit;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffCalls, callLimit);
        }

        [TestMethod]
        public void TariffDataOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string dataLimit = "20GB";
            //assign the data to property
            ATariff.TariffData = dataLimit;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffData, dataLimit);
        }

        [TestMethod]
        public void TariffIDOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            Int32 TariffID = 1;
            //assign the data to property
            ATariff.TariffID = TariffID;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffID, TariffID);
        }

        [TestMethod]
        public void TariffNetworkOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string tariffNetwork = "O2";
            //assign the data to property
            ATariff.TariffNetwork = tariffNetwork;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffNetwork, tariffNetwork);
        }

        [TestMethod]
        public void TariffPriceOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            decimal tariffPrice = 45.00m;
            //assign the data to property
            ATariff.TariffPrice = tariffPrice;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffPrice, tariffPrice);
        }

        [TestMethod]
        public void TariffTextsOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string tariffTexts = "Unlimited";
            //assign the data to property
            ATariff.TariffTexts = tariffTexts;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffTexts, tariffTexts);
        }

        [TestMethod]
        public void TariffUpfrontOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            decimal tariffUpfront = 90.00m;
            //assign the data to property
            ATariff.TariffUpfront = tariffUpfront;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.TariffUpfront, tariffUpfront);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            Boolean Found = false;
            Int32 TariffID = 1;
            Found = ATariff.Find(TariffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsTariff ATariff = new clsTariff();
            String Error = "";
            Error = ATariff.Valid(TariffTexts, TariffCalls, TariffData, TariffNetwork, TariffPrice, TariffUpfront);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsTariffCollection AllTariffs = new clsTariffCollection();
            clsTariff TestItem = new clsTariff();
            Int32 PrimaryKey = 0;
            TestItem.TariffTexts = "500";
            TestItem.TariffCalls = "Unlimited";
            TestItem.TariffData = "20GB";
            TestItem.TariffNetwork = "Test";
            TestItem.TariffPrice = 30.00m;
            TestItem.TariffUpfront = 50.00m;
            AllTariffs.ThisTariff = TestItem;
            PrimaryKey = AllTariffs.Add();
            TestItem.TariffID = PrimaryKey;
            AllTariffs.ThisTariff.Find(PrimaryKey);
            AllTariffs.Delete();
            Boolean Found = AllTariffs.ThisTariff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsTariffCollection AllTariffs = new clsTariffCollection();
            clsTariff TestItem = new clsTariff();
            Int32 PrimaryKey = 0;
            TestItem.TariffTexts = "500";
            TestItem.TariffCalls = "Unlimited";
            TestItem.TariffData = "20GB";
            TestItem.TariffNetwork = "Test";
            TestItem.TariffPrice = 30.00m;
            TestItem.TariffUpfront = 50.00m;
            AllTariffs.ThisTariff = TestItem;
            PrimaryKey = AllTariffs.Add();
            TestItem.TariffID = PrimaryKey;
            TestItem.TariffTexts = "200";
            TestItem.TariffCalls = "1000";
            TestItem.TariffData = "10GB";
            TestItem.TariffNetwork = "Test 2";
            TestItem.TariffPrice = 15.00m;
            TestItem.TariffUpfront = 25.00m;
            AllTariffs.ThisTariff = TestItem;
            AllTariffs.Update();
            AllTariffs.ThisTariff.Find(PrimaryKey);
            Assert.AreEqual(AllTariffs.ThisTariff, TestItem);
        }

        [TestMethod]
        public void TestTariffNotFound()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TariffID = 21;
            Found = ATariff.Find(TariffID);
            if (ATariff.TariffID !=21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TariffCallsMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMinOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "10000";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMinAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "100000";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMaxLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "1000000 Minutes";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "UnlimitedMinutes";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMaxAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "UnlimitedMinutes ";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsExtremeMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "1000000000000000000000000000000000000000000Minutes";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffCallsMidOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffCalls = "100 Minutes";
            //invoke the mothod
            Error = ATariff.ValidTariffCalls(SomeTariffCalls);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMinOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "1";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMinAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "10";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMaxLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "10GB";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "100GB";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMaxAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "1000GB";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataExtremeMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "10000000GB";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffDataMidOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffData = "1GB";
            //invoke the mothod
            Error = ATariff.ValidTariffData(SomeTariffData);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMinOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "O2";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMinAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "333";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMaxLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "Completly Random ???";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "Very Random Network?";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMaxAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "Very Random Network??";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkExtremeMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "O2222222222222222222222222222222222222222222222222";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffNetworkMidOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffNetwork = "Sky Mobile";
            //invoke the mothod
            Error = ATariff.ValidTariffNetwork(SomeTariffNetwork);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMinOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "500 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMinAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "5000 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMaxLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "500000000000000000 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "5000000000000000000 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMaxAddOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "50000000000000000000 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsExtremeMaxOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "50000000000000000000000000000000000000000000 Texts";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffTextsMidOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffTexts = "Unlimited Texts ";
            //invoke the mothod
            Error = ATariff.ValidTariffTexts(SomeTariffTexts);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffPriceMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffPrice ="-0.01";
            //invoke the mothod
            Error = ATariff.ValidTariffPrice(SomeTariffPrice);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffPriceMinPlusOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffPrice = "0.01";
            //invoke the mothod
            Error = ATariff.ValidTariffPrice(SomeTariffPrice);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffPriceBadData()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffPrice = "xyz";
            //invoke the mothod
            Error = ATariff.ValidTariffPrice(SomeTariffPrice);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffUpfrontMinLessOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffUpfront = "-0.01";
            //invoke the mothod
            Error = ATariff.ValidTariffPrice(SomeTariffUpfront);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TariffUpfrontMinPlusOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffUpfront = "0.01";
            //invoke the mothod
            Error = ATariff.ValidTariffUpfront(SomeTariffUpfront);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TariffUpfrontBadData()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create a string variable to store the result of the varibale
            String Error = "";
            //create some test data to test the method
            string SomeTariffUpfront = "xyz";
            //invoke the mothod
            Error = ATariff.ValidTariffPrice(SomeTariffUpfront);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReportByNetworkMethodOK()
        {
            clsTariffCollection AllTariffs = new clsTariffCollection();
            clsTariffCollection FilteredTariffs = new clsTariffCollection();
            FilteredTariffs.ReportByNetwork("");
            Assert.AreEqual(AllTariffs.Count, FilteredTariffs.Count);
        }

        [TestMethod]
        public void ReportByNEtworkNoneFound()
        {
            clsTariffCollection FilteredTariffs = new clsTariffCollection();
            FilteredTariffs.ReportByNetwork("xxx xxx");
            Assert.AreEqual(0, FilteredTariffs.Count);
        }

        [TestMethod]
        public void ReportByNetworkTestDataFound()
        {
            clsTariffCollection FilteredTariffs = new clsTariffCollection();
            Boolean OK = true;
            FilteredTariffs.ReportByNetwork("O2");
            if (FilteredTariffs.Count == 2)
            {
                if (FilteredTariffs.TariffList[0].TariffID != 3)
                {
                    OK = false;
                }
                if (FilteredTariffs.TariffList[1].TariffID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //End Of Connor's Tests
    }
}