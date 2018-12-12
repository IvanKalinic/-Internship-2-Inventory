using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class CellPhone:TechnologicalEquipment
    {
        public string NameAndSurname { get; set; }
        public int PhoneNumber { get; set; }
        public ManufacturerPhones Manufacturer { get; set; }

        public CellPhone(Guid serialNumber, string description, string dateOfPurchase, int monthsOfWarranty,
            int price, ManufacturerPhones manufacturer, bool hasBattery, string nameAndSurname, int phoneNumber)
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
