using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class TechnologicalEquipment:CommonProperties
    {
        public bool HasBattery { get; set; }

        public TechnologicalEquipment(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer,bool hasBattery)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price, manufacturer)
        {
            HasBattery = hasBattery;
        }

    }
}
