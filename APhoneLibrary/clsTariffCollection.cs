using System;
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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TariffTable_SelectAll");
            PopulateArray(DB);
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TariffID", mThisTariff.TariffID);
            DB.Execute("sproc_TariffTable_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TariffID", mThisTariff.TariffID);
            DB.AddParameter("@TariffTexts", mThisTariff.TariffTexts);
            DB.AddParameter("@TariffCalls", mThisTariff.TariffCalls);
            DB.AddParameter("@TariffData", mThisTariff.TariffData);
            DB.AddParameter("@TariffNetwork", mThisTariff.TariffNetwork);
            DB.AddParameter("@TariffPrice", mThisTariff.TariffPrice);
            DB.AddParameter("@TariffUpfront", mThisTariff.TariffUpfront);
            DB.Execute("sproc_TariffTable_Update");
        }

        public void ReportByNetwork(string TariffNetwork)
        {
            //filters the records based on a network
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TariffNetwork", TariffNetwork);
            DB.Execute("sproc_TariffTable_FilterByNetwork");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mTariffList = new List<clsTariff>();
            while (Index < RecordCount)
            {
                clsTariff ATariff = new clsTariff();
                ATariff.TariffTexts = Convert.ToString(DB.DataTable.Rows[Index]["TariffTexts"]);
                ATariff.TariffCalls = Convert.ToString(DB.DataTable.Rows[Index]["TariffCalls"]);
                ATariff.TariffData = Convert.ToString(DB.DataTable.Rows[Index]["TariffData"]);
                ATariff.TariffNetwork = Convert.ToString(DB.DataTable.Rows[Index]["TariffNetwork"]);
                ATariff.TariffPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TariffPrice"]);
                ATariff.TariffUpfront = Convert.ToDecimal(DB.DataTable.Rows[Index]["TariffUpfront"]);
                mTariffList.Add(ATariff);
                Index++;
            }
        }
    }
}