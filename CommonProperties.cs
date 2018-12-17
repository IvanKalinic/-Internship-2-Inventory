using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Text;

namespace Internship_2_Inventory
{
    public class CommonProperties
    {
        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public TimeSpan MonthsOfWarranty { get; set; }
        public double Price { get; set; }
        

        public CommonProperties(Guid serialNumber, string description, DateTime dateOfPurchase, TimeSpan monthsOfWarranty,
            double price)
        { 
       
            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            Price = price;
        }
       
    }

}
