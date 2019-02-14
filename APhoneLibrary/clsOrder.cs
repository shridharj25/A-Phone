using System;

namespace APhoneLibrary
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }
        public string OrderMadeBy { get; set; }
        public DateTime OrderDueDate { get; set; }
    }
}