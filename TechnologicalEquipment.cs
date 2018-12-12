using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class TechnologicalEquipment:CommonProperties
    {
        public bool HasBattery { get; set; }
        
        public TechnologicalEquipment(Guid serialNumber, string description, string dateOfPurchase, int monthsOfWarranty,
            int price,bool hasBattery)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price)
        {
            HasBattery = hasBattery;
        }

    }
}
