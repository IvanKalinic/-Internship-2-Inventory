using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class Vehicles : CommonProperties
    {
        public int ExpirationDate { get; set; }
        public int Kilometers { get; set; }

        public Vehicles(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer, int expirationDate, int kilometers)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price, manufacturer)
        {

            ExpirationDate = expirationDate;
            Kilometers = kilometers;
        }
    }
}
