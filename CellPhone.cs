using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class CellPhone:TechnologicalEquipment
    {
        public string NameAndSurname { get; set; }
        public string PhoneNumber { get; set; }
        public ManufacturerPhones Manufacturer { get; set; }

        public CellPhone(Guid serialNumber, string description, DateTime dateOfPurchase, TimeSpan monthsOfWarranty,
            double price, ManufacturerPhones manufacturer, bool hasBattery, string nameAndSurname, string phoneNumber)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price, hasBattery)
        {
            NameAndSurname = nameAndSurname;
            PhoneNumber = phoneNumber;
            Manufacturer = manufacturer;
        }
    }

    public enum ManufacturerPhones
    {
        Samsung=1,
        Nokia,
        Sony,
        Apple
    }
}
