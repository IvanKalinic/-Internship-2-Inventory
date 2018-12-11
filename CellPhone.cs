using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class CellPhone:TechnologicalEquipment
    {
        public string NameAndSurname { get; set; }
        public int PhoneNumber { get; set; }

        public CellPhone(int serialNumber, string description, int dateOfPurchase, int monthsOfWarranty,
            int price, string manufacturer, bool hasBattery, string nameAndSurname, int phoneNumber)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price, manufacturer, hasBattery)
        {
            NameAndSurname = nameAndSurname;
            PhoneNumber = phoneNumber;
        }
    }
}
