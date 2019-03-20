using System.Collections.Generic;

namespace APhoneLibrary
{
    public class clsTariffCollection
    {
        //private data member for the list
        List<clsTariff> mTariffList = new List<clsTariff>();
        clsTariff mThisTariff = new clsTariff();

        //constructor for the class
        public clsTariffCollection()
        {
            //create the items of test data
            clsTariff TestItem = new clsTariff();
            //set its properties
            TestItem.TariffID = 1;
            TestItem.TariffTexts = "500";
            TestItem.TariffCalls = "Unlimited";
            TestItem.TariffData = "20GB";
            TestItem.TariffNetwork = "O2";
            TestItem.TariffPrice = 30.00m;
            TestItem.TariffUpfront = 50.00m;
            //add the item to the test list
            mTariffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsTariff();
            //set its properties
            TestItem.TariffID = 1;
            TestItem.TariffTexts = "2000";
            TestItem.TariffCalls = "Unlimited";
            TestItem.TariffData = "50GB";
            TestItem.TariffNetwork = "Vodafone";
            TestItem.TariffPrice = 15.99m;
            TestItem.TariffUpfront = 10.00m;
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

        public clsTariff ThisTariff
        {
            get
            {
                return mThisTariff;
            }
            set
            {
                mThisTariff = value;
            }
        }

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TariffTexts", mThisTariff.TariffTexts);
            DB.AddParameter("@TariffCalls", mThisTariff.TariffCalls);
            DB.AddParameter("@TariffData", mThisTariff.TariffData);
            DB.AddParameter("@TariffNetwork", mThisTariff.TariffNetwork);
            DB.AddParameter("@TariffPrice", mThisTariff.TariffPrice);
            DB.AddParameter("@TariffUpfront", mThisTariff.TariffUpfront);
            return DB.Execute("sproc_TariffTable_Add");

        }
    }
}