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
    double tariffPrice = 45.00;
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
    double tariffUpfront = 90.00;
    //assign the data to property
    ATariff.Upfront = tariffUpfront;
    //test to see that the two values are the same
    Assert.AreEqual(ATariff.Upfront, tariffUpfront);
}
//End Of Connor's Tests