namespace APhoneLibrary
{
    public class clsPhone
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string PhoneNo { get; set; }
        public string Price { get; set; }
        public double ScreenSize { get; set; }
        public string CameraQuality { get; set; }
        public int PhoneId { get; set; }

        public string ValidPhoneMake(string somePhoneMake)
        {
            //string variable to store the error message
            string Error = "";
            //if the phone make is more 10 characters
            if (somePhoneMake.Length > 10)
            {
                //return an error message
                Error = "The phone make cannot be more than 10 characters long";
            }

            if (somePhoneMake.Length == 0)
            {
                //otherwise return an error message
                Error = "Phone make cannot be blank!";
            }
            return Error;
        }

        public string ValidPhoneModel(string somePhoneModel)
        {
            //string variable to store the error message
            string Error = "";
            //if the phone model is more 10 characters
            if (somePhoneModel.Length > 10)
            {
                //return an error message
                Error = "The phone model cannot be more than 10 characters long";
            }

            if (somePhoneModel.Length == 0)
            {
                //otherwise return an error message
                Error = "Phone model cannot be blank!";
            }
            return Error;
        }

        public string ValidPhoneNo(string somePhoneNo)
        {
            //string variable to store the error message
            string Error = "";
            //if the phone no is not 11 characters
            if (somePhoneNo.Length != 11)
            {
                //return an error message
                Error = "The phone no has to be 11 nubers";
            }

            if (somePhoneNo.Length == 0)
            {
                //otherwise return an error message
                Error = "Phone no cannot be blank!";
            }
            return Error;
        }

        //public string ValidPhonePrice(string somePhonePrice)
        //{
        //    //string variable to store the error message
        //    string Error = "";
        //    //if the phone price is more 1200
        //    if (somePhonePrice.Length > 1200)
        //    {
        //        //return an error message
        //        Error = "There are no phones above £1200";
        //    }

        //    if (somePhonePrice.Length == 0)
        //    {
        //        //otherwise return an error message
        //        Error = "Price cannot be blank!";
        //    }
        //    return Error;
        //}

        //public string ValidPhoneScreenSize(double somePhoneScreenSize)
        //{
        //    //string variable to store the error message
        //    string Error = "";
        //    //if the phone screen size cannot be more that 7"
        //    if (somePhoneScreenSize > 7)
        //    {
        //        //return an error message
        //        Error = "There are no phones with a screen size greater than 7 inches";
        //    }

        //    if (somePhoneScreenSize == 0)
        //    {
        //        //otherwise return an error message
        //        Error = "Sreen size cannot be blank!";
        //    }
        //    return Error;
        //}

        public string ValidPhoneCameraQuality(string somePhoneCameraQuality)
        {
            //string variable to store the error message
            string Error = "";
            //if the phone make is more 5 characters
            if (somePhoneCameraQuality.Length > 5)
            {
                //return an error message
                Error = "The phone camera quality cannot be more than 5 characters";
            }

            if (somePhoneCameraQuality.Length == 0)
            {
                //otherwise return an error message
                Error = "Phone camera quality cannot be blank!";
            }
            return Error;
        }
    }
}