using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Internship_2_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var allVehicles = new List<Vehicles>()
            {
                new Vehicles(Guid.NewGuid(), "Car", "12.1.2001.", 40, 40000, ManufacturerVehicles.Mercedes, "12.1.2002",
                    150000),
                /* {
                     SerialNumber = 12345, Description = "Car", DateOfPurchase = "12.1.2001.", MonthsOfWarranty = 40,
                     Price = 40000, ExpirationDate= "12.1.2002.", Kilometers = 150000,Manufacturer=Manufacturer.Mercedes
                 }, */
                new Vehicles(Guid.NewGuid(), "Motorbike", "14.5.2006.", 48, 30000, ManufacturerVehicles.Honda,
                    "14.5.2007.", 100000),
                /* {
                     SerialNumber = 123456, Description = "Motorbike", DateOfPurchase = "14.5.2006.", MonthsOfWarranty = 48,
                     Price = 30000, ExpirationDate= "14.5.2007.", Kilometers = 100000,Manufacturer=Manufacturer.Honda
                 }, */
                new Vehicles(Guid.NewGuid(), "Car", "24.8.2013.", 48, 200000, ManufacturerVehicles.Nissan, "24.8.2014",
                    350000)
                /*    {
                        SerialNumber = 345234, Description = "Car", DateOfPurchase = "24.8.2013.", MonthsOfWarranty = 48,
                        Price = 200000, ExpirationDate= "24.8.2014.", Kilometers = 350000,Manufacturer=Manufacturer.Nissan
                    } */
            };

            var allCellPhones = new List<CellPhone>()
            {
                new CellPhone(Guid.NewGuid(), "Android", "24.5.2017.", 24, 5000, ManufacturerPhones.Samsung, true,
                    "Marko V",
                    0982324156),
                new CellPhone(Guid.NewGuid(), "IPhone", "30.10.2017.", 36, 10000, ManufacturerPhones.Apple, true,
                    "Karlo Jukic",
                    0951234567),
                new CellPhone(Guid.NewGuid(), "Windows Phone", "2.9.2016.", 24, 4000, ManufacturerPhones.Nokia, true,
                    "Nikola D",
                    0999087654)
            };

            var allComputers = new List<Computer>()
            {
                new Computer(Guid.NewGuid(), "16GB RAM,512GB SSD", "30.8.2018.", 36, 7000, ManufacturerComputers.Asus,
                    true,
                    "Windows 10", true),
                new Computer(Guid.NewGuid(), "8GB RAM,1TB HDDD", "24.7.2017.", 24, 5500, ManufacturerComputers.Acer,
                    true,
                    "Linux", true),
                new Computer(Guid.NewGuid(), "12GB RAM,256GB SSD+1TB SSD", "20.4.2018.", 36, 6000,
                    ManufacturerComputers.Lenovo,
                    true, "Windows 10", true)
            };


            var choice = 1;

            while (choice != 0)
            {
                Console.WriteLine("Za dodavanje novih članova liste vozila odaberite 1");
                Console.WriteLine("Za dodavanje novih članova liste mobitela odaberite 2");
                Console.WriteLine("Za dodavanje novih članova liste računala odaberite 3");
                Console.WriteLine("Za izlaz iz izbornika odaberite 0");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddElementsToVehicles(allVehicles);
                        break;
                    case 2:
                        AddElementsToCellPhones(allCellPhones);
                        break;
                    case 3:
                        AddElementsToComputers(allComputers);
                        break;
                    

                }
            }



        }

        static List<Vehicles> AddElementsToVehicles(List<Vehicles> myVehicles)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = Console.ReadLine();
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("ExpirationDate=");
            var expirationDate = Console.ReadLine();
            Console.WriteLine("Kilometers=");
            var kilometers = int.Parse(Console.ReadLine());
            // FALI ZA MANUFACTURERA
            var myVehicle = new Vehicles(Guid.NewGuid(), description, dateOfPurchase, monthsOfWarranty, price,
                ManufacturerVehicles.Bmw, expirationDate, kilometers);
           
            myVehicles.Add(myVehicle);
            return myVehicles;
        }

        static List<CellPhone> AddElementsToCellPhones(List<CellPhone> myCellPhones)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = Console.ReadLine();
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            // manufacturer 
            Console.WriteLine("Unesi ima li bateriju?1-da,2-ne");
            var choiceForBattery = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Unesi ime i prezime osobe");
            var nameAndSurname = Console.ReadLine();
            Console.WriteLine("Unesi broj osobe");
            var phoneNumber = int.Parse(Console.ReadLine());

            var myPhone = new CellPhone(Guid.NewGuid(), description, dateOfPurchase, monthsOfWarranty, price,
                ManufacturerPhones.Samsung, choiceForBattery, nameAndSurname, phoneNumber);
            myCellPhones.Add(myPhone);
            return myCellPhones;
        }

        static List<Computer>AddElementsToComputers(List<Computer> myComputers)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = Console.ReadLine();
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi ima li bateriju?1-da,2-ne");
            var choiceForBattery = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Unesi ime operacijskog sustava");
            var operationSystem = Console.ReadLine();
            Console.WriteLine("Unesi je li racunalo prijenosno");
            var isPortable = Boolean.Parse(Console.ReadLine());

            var myComputer = new Computer(Guid.NewGuid(), description, dateOfPurchase, monthsOfWarranty, price,
                ManufacturerComputers.Acer, choiceForBattery, operationSystem, isPortable);
            myComputers.Add(myComputer);
        }
    }
}

