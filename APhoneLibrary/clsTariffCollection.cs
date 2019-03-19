using System.Collections.Generic;

namespace APhoneLibrary
{
    public class clsTariffCollection
    {
        //private data member for the list
        List<clsTariff> mTariffList = new List<clsTariff>();

        //constructor for the class
        public clsTariffCollection()
        {
            //create the items of test data
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
            mTariffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsTariff();
            //set its properties
            TestItem.Active = true;
            TestItem.TariffID = 1;
            TestItem.Texts = "2000";
            TestItem.Calls = "Unlimited";
            TestItem.Data = "50GB";
            TestItem.Network = "Vodafone";
            TestItem.Price = 15.99m;
            TestItem.Upfront = 10.00m;
            //add the item to the test list
            mTariffList.Add(TestItem);
        }

        public List<clsTariff> TariffList
        {
            get
            {
                //return the private data 
                return mTariffList;
            }
            set
            {
                //set the private data
                mTariffList = value;
            }
        }

        public clsTariff ThisTariff { get; set; }

        public int Count
        {
            get
            {
                //reurn the count of the list
                return mTariffList.Count;
            }
            set
            {
                //We shall worry about this later
            }
        }
    }
}