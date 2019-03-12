using System;

namespace APhoneLibrary
{
    public class clsOrder
    {
        //public variable for OrderDate
        public DateTime OrderDate { get; set; }
        public String Order{ get; set; }
        //public variable for Price
        public decimal Price { get; set; }
        //public variable for OrderrMadeBy
        public string OrderMadeBy { get; set; }
        //public variable for OrderDueDate
        public DateTime OrderDueDate { get; set; }
        //public variable for OrderID
        public int OrderID { get; set; }
        //public variable for CustomerID
        public int CustomerID { get; set; }
        //public variable for OrderID
        public int PhoneID { get; set; }
        //public variable for TariffID
        public int TarrifID { get; set; }

        public string Valid(string someOrderMadeby)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the OrderMadeby is more than 20
            if (someOrderMadeby.Length > 21)

            {
                //return blank string
                Error = "The Order Made By cannot have more than 20 Characters";
            }
            if (someOrderMadeby.Length == 0)
            {
                //return an error message
                Error = "The Order Made By cannot be blank!";
            }

            return Error;
        }

        public string ValidPhoneOrderMax(string someOrderMadeby)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the OrderMadeby is more than 20
            if (someOrderMadeby.Length > 50)

            {
                //return blank string
                Error = "The Order Made By cannot have more than 20 Characters";
            }
            if (someOrderMadeby.Length == 0)
            {
                //return an error message
                Error = "The Order Made By cannot be blank!";
            }

            return Error;
        }

        public string ValidOrderPrice(decimal someOrderPrice)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the OrderMadeby is more than 1100
            if (someOrderPrice > 1100)

            {
                //return blank string
                Error = "The Order Price cannot be more than 1100";
            }
            if (someOrderPrice == 0)
            {
                //return an error message
                Error = "The Order Price cannot be blank!";
            }

            return Error;
        }
    }
}
