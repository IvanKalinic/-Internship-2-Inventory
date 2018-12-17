using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    public class Vehicles : CommonProperties
    {
        public DateTime ExpirationDate { get; set; }
        public int Kilometers { get; set; }
        public ManufacturerVehicles Manufacturer { get; set; }

        public Vehicles(Guid serialNumber, string description, DateTime dateOfPurchase, TimeSpan monthsOfWarranty,
            double price,ManufacturerVehicles  manufacturer, DateTime expirationDate, int kilometers)
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
