using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class Computer:TechnologicalEquipment
    {
        public string OperationSystem { get; set; }
        public bool IsPortable { get; set; }

        public Computer(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer, bool hasBattery, string operationSystem, bool isPortable)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price, manufacturer,hasBattery)
        {
            OperationSystem = operationSystem;
            IsPortable = isPortable;
        }
    }
}
