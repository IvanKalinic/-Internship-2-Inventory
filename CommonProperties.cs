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
        public string DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public int Price { get; set; }
        


        public CommonProperties(Guid serialNumber, string description, string dateOfPurchase, int monthsOfWarranty,
            int price)
        {

            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            Price = price;
           
        }
       
    }
    
}
