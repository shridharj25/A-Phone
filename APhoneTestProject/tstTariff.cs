using System;
using APhoneLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TariffTestProject
{
    [TestClass]
    public class TariffTests
    {
        //Start Of Connor's Tests
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
            ATariff.Calls = callLimit;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Calls, callLimit);
        }

        [TestMethod]
        public void TariffDataOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string dataLimit = "20GB";
            //assign the data to property
            ATariff.Data = dataLimit;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Data, dataLimit);
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
            ATariff.Network = tariffNetwork;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Network, tariffNetwork);
        }

        [TestMethod]
        public void TariffPriceOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            decimal tariffPrice = 45.00m;
            //assign the data to property
            ATariff.Price = tariffPrice;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Price, tariffPrice);
        }

        [TestMethod]
        public void TariffTextsOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            string tariffTexts = "Unlimited";
            //assign the data to property
            ATariff.Texts = tariffTexts;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Texts, tariffTexts);
        }

        [TestMethod]
        public void TariffUpfrontOK()
        {
            //create an instance of the class
            clsTariff ATariff = new clsTariff();
            //create some test data 
            decimal tariffUpfront = 90.00m;
            //assign the data to property
            ATariff.Upfront = tariffUpfront;
            //test to see that the two values are the same
            Assert.AreEqual(ATariff.Upfront, tariffUpfront);
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

        //End Of Connor's Tests
    }
}