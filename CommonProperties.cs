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
<<<<<<< HEAD
        public string DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public int Price { get; set; }
        


        public CommonProperties(Guid serialNumber, string description, string dateOfPurchase, int monthsOfWarranty,
            int price)
=======
        public int DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }

        public CommonProperties(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer)
>>>>>>> 401033b2fbd910f7c890776c6e151342ecd77e35
        {

            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            Price = price;
<<<<<<< HEAD
           
        }
       
    }
    
=======
            Manufacturer = manufacturer;
        }
>>>>>>> 401033b2fbd910f7c890776c6e151342ecd77e35
}
