using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class Vehicles : CommonProperties
    {
        public string ExpirationDate { get; set; }
        public int Kilometers { get; set; }
        public ManufacturerVehicles Manufacturer { get; set; }

        public Vehicles(Guid serialNumber, string description, string dateOfPurchase, int monthsOfWarranty,
            int price,ManufacturerVehicles  manufacturer, string expirationDate, int kilometers)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, price)
        {

            ExpirationDate = expirationDate;
            Kilometers = kilometers;
            Manufacturer = manufacturer;
        }
        
    }
    public enum ManufacturerVehicles
    {
        Mercedes = 1,
        Bmw,
        Nissan,
        Suzuki,
        Honda

    }
}
