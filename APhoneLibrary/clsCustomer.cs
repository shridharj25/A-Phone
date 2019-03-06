using System;

namespace APhoneLibrary
{
    public class clsCustomer
    {
        public string FirstName { get; set; }
        public int HouseNumber { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNo { get; set; }
        public string PostCode { get; set; }
        public string StreetName { get; set; }
        public string Surname { get; set; }

        public string ValidCustomerFirstName(string someFirstName)
        {
            //string variable to store the error message
            string Error = "";
            //if the first name is more than 15 characters
            if (someFirstName.Length > 15)
            {
                //return an error message
                Error = "The First Name cannot have more than 15 characters";
            }

            if (someFirstName.Length == 0)
            {
                //otherwise return an error message
                Error = "The First Name may not be blank!";
            }
            return Error;
        }

        public string ValidCustomerHouseNumber(string someHouseNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the house number is more than 5 characters
            if (someHouseNumber.Length > 5)
            {
                //return an error message
                Error = "The First Name cannot have more than 5 characters";
            }

            if (someHouseNumber.Length == 0)
            {
                //otherwise return an error message
                Error = "The First Name may not be blank!";
            }
            return Error;
        }

        public string ValidCustomerPhoneNo(string somePhoneNo)
        {
            //string variable to store the error message
            string Error = "";
            //if the PhoneNo is more than 15 characters
            if (somePhoneNo.Length > 15)
            {
                //return an error message
                Error = "The PhoneNo cannot have more than 15 characters";
            }

            if (somePhoneNo.Length < 7)
            {
                //return an error message
                Error = "The PhoneNo cannot have less than 7 characters";
            }

            if (somePhoneNo.Length == 0)
            {
                //otherwise return an error message
                Error = "The PhoneNo may not be blank!";
            }
            return Error;
        }

        public string ValidCustomerPostCode(string somePostCode)
        {
            //string variable to store the error message
            string Error = "";
            //if the PostCode is more than 7 characters
            if (somePostCode.Length > 7)
            {
                //return an error message
                Error = "The PostCode cannot have more than 7 characters";
            }

            if (somePostCode.Length < 7)
            {
                //return an error message
                Error = "The PostCode cannot have less than 7 characters";
            }

            if (somePostCode.Length == 0)
            {
                //otherwise return an error message
                Error = "The PostCode may not be blank!";
            }
            return Error;
        }

        public string ValidCustomerStreetName(string someStreetName)
        {
            //string variable to store the error message
            string Error = "";
            //if the Street Name is more than 10 characters
            if (someStreetName.Length > 10)
            {
                //return an error message
                Error = "The Street Name cannot have more than 10 characters";
            }

            if (someStreetName.Length < 3)
            {
                //return an error message
                Error = "The Street Name cannot have less than 3 characters";
            }

            if (someStreetName.Length == 0)
            {
                //otherwise return an error message
                Error = "The Street Name may not be blank!";
            }
            return Error;
        }

        public string ValidCustomerSurname(string someSurname)
        {
            //string variable to store the error message
            string Error = "";
            //if the Surname is more than 10 characters
            if (someSurname.Length > 10)
            {
                //return an error message
                Error = "The Surname cannot have more than 10 characters";
            }

            if (someSurname.Length < 3)
            {
                //return an error message
                Error = "The Surname cannot have less than 3 characters";
            }

            if (someSurname.Length == 0)
            {
                //otherwise return an error message
                Error = "The Surname may not be blank!";
            }
            return Error;
        }
    }


}