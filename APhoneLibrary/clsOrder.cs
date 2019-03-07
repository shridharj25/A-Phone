using System;

namespace APhoneLibrary
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
        public string OrderMadeBy { get; set; }
        public DateTime OrderDueDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int PhoneID { get; set; }
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

    
    }
}