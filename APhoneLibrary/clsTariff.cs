using System;

namespace APhoneLibrary
{
    public class clsTariff
    {
        private Int32 mTariffID;
        private String mTariffCalls;
        private String mTariffTexts;
        private String mTariffData;
        private String mTariffNetwork;
        private Decimal mTariffPrice;
        private Decimal mTariffUpfront;
        public int TariffID
        {
            get
            {
                return mTariffID;
            }
            set
            {
                mTariffID = value;
            }
        }
        public string TariffCalls
        {
            get
            {
                return mTariffCalls;
            }
            set
            {
                mTariffCalls = value;
            }
        }
        public string TariffData
        {
            get
            {
                return mTariffData;
            }
            set
            {
                mTariffData = value;
            }
        }
        public string TariffNetwork
        {
            get
            {
                return mTariffNetwork;
            }
            set
            {
                mTariffNetwork = value;
            }
        }
        public decimal TariffPrice
        {
            get
            {
                return mTariffPrice;
            }
            set
            {
                mTariffPrice = value;
            }
        }
        public string TariffTexts
        {
            get
            {
                return mTariffTexts;
            }
            set
            {
                mTariffTexts = value;
            }
        }
        public decimal TariffUpfront
        {
            get
            {
                return mTariffUpfront;
            }
            set
            {
                mTariffUpfront = value;
            }
        }

        public bool Find(int TariffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TariffID", TariffID);
            DB.Execute("sproc_TariffTable_FilterByTariffID");
            if (DB.Count == 1)
            {
                mTariffID = Convert.ToInt32(DB.DataTable.Rows[0]["TariffID"]);
                mTariffCalls = Convert.ToString(DB.DataTable.Rows[0]["TariffCalls"]);
                mTariffTexts = Convert.ToString(DB.DataTable.Rows[0]["TariffTexts"]);
                mTariffData = Convert.ToString(DB.DataTable.Rows[0]["TariffData"]);
                mTariffNetwork = Convert.ToString(DB.DataTable.Rows[0]["TariffNetwork"]);
                mTariffPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TariffPrice"]);
                mTariffUpfront = Convert.ToDecimal (DB.DataTable.Rows[0]["TariffUpfront"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ValidTariffCalls(string someTariffCalls)
        {
            //string variable to store the error message
            string Error = "";
            //if the Calls is more than 15 characters
            if (someTariffCalls.Length > 16)
            {
                //return an error message
                Error = "Calls Value cannot have more than 16 characters";
            }

            if (someTariffCalls.Length == 0)
            {
                //otherwise return an error message
                Error = "Calls Value may not be blank!";
            }
            return Error;
        }

        public string ValidTariffData(string someTariffData)
        {
            //string variable to store the error message
            string Error = "";
            //if the Data is more than 5 characters
            if (someTariffData.Length > 5)
            {
                //return an error message
                Error = "Data Value cannot have more than 5 characters";
            }

            if (someTariffData.Length == 0)
            {
                //otherwise return an error message
                Error = "Data Value may not be blank!";
            }
            return Error;
        }

        public string ValidTariffNetwork(string someTariffNetwork)
        {
            //string variable to store the error message
            string Error = "";
            //if the Network is more than 5 characters
            if (someTariffNetwork.Length > 20)
            {
                //return an error message
                Error = "Network Value cannot have more than 20 characters";
            }

            if (someTariffNetwork.Length == 0)
            {
                //otherwise return an error message
                Error = "Network Value may not be blank!";
            }
            return Error;
        }

        public string Valid(string tariffTexts, string tariffCalls, string tariffData, string tariffNetwork, decimal tariffPrice, decimal tariffUpfront)
        {
            return "";
        }

        public string ValidTariffTexts(string someTariffTexts)
        {
            //string variable to store the error message
            string Error = "";
            //if the texts is more than 5 characters
            if (someTariffTexts.Length > 25)
            {
                //return an error message
                Error = "Texts Value cannot have more than 25 characters";
            }

            if (someTariffTexts.Length == 0)
            {
                //otherwise return an error message
                Error = "Texts Value may not be blank!";
            }
            return Error;
        }

        public string ValidTariffPrice(string someTariffPrice)
        {
            string Error = "";
            try
            {
                decimal TempTariffPriceTemp = Convert.ToDecimal(someTariffPrice);
                if (TempTariffPriceTemp <= 0.00m)        
                {
                    //error here too
                    Error = "price must be greater than zero ";
                }
            }
            catch
            {
                //error
                Error = "the price is not a valid number ";
            }
            return Error;
        }

        public string ValidTariffUpfront(string someTariffUpfront)
        {
            string Error = "";
            try
            {
                decimal TempTariffUpfrontTemp = Convert.ToDecimal(someTariffUpfront);
                if (TempTariffUpfrontTemp <= 0.00m)
                {
                    //error here too
                    Error = "upfront must be greater than zero ";
                }
            }
            catch
            {
                //error
                Error = "the upfront is not a valid number ";
            }
            return Error;
        }
    }
}