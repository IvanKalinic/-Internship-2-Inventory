using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class Computer:TechnologicalEquipment
    {
        public string OperationSystem { get; set; }
        public bool IsPortable { get; set; }
        public ManufacturerComputers Manufacturer { get; set; }

        public Computer(Guid serialNumber, string description, DateTime dateOfPurchase, TimeSpan monthsOfWarranty,
            double price, ManufacturerComputers manufacturer, bool hasBattery, string operationSystem, bool isPortable)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price,hasBattery)
        {
            OperationSystem = operationSystem;
            IsPortable = isPortable;
            Manufacturer = manufacturer;
        }
    }

    public enum ManufacturerComputers
    {
        Dell=1,
        Hp,
        Asus,
        Acer,
        Lenovo
    }
}
