using System;

namespace APhoneLibrary
{
    public class clsTariff
    {
        public string Calls { get; set; }
        public string Data { get; set; }
        public int TariffID { get; set; }
        public string Network { get; set; }
        public decimal Price { get; set; }
        public string Texts { get; set; }
        public decimal Upfront { get; set; }
        public bool Active { get; set; }

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