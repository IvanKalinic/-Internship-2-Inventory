using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class CommonProperties
    {
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public int DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }

        public CommonProperties(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer)
        {

            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            Price = price;
            Manufacturer = manufacturer;
        }
}
