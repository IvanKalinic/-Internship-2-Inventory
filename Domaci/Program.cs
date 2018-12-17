using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
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
                new Vehicles(Guid.NewGuid(), "Car", new DateTime(2001,12,12), TimeSpan.FromDays(365), 40000, ManufacturerVehicles.Mercedes, new DateTime(2002,12,12),
                    150000),
                /* {
                     SerialNumber = 12345, Description = "Car", DateOfPurchase = "12.1.2001.", MonthsOfWarranty = 40,
                     Price = 40000, ExpirationDate= "12.1.2002.", Kilometers = 150000,Manufacturer=Manufacturer.Mercedes
                 }, */
                new Vehicles(Guid.NewGuid(), "Motorbike", new DateTime(2007,5,14), TimeSpan.FromDays(365*2), 30000, ManufacturerVehicles.Honda,
                new DateTime(2007,5,14), 100000),
                /* {
                     SerialNumber = 123456, Description = "Motorbike", DateOfPurchase = "14.5.2006.", MonthsOfWarranty = 48,
                     Price = 30000, ExpirationDate= "14.5.2007.", Kilometers = 100000,Manufacturer=Manufacturer.Honda
                 }, */
                new Vehicles(Guid.NewGuid(), "Car", new DateTime(2017,12,24), TimeSpan.FromDays(365), 200000, ManufacturerVehicles.Nissan, new DateTime(2018,12,24),
                    350000)
                /*    {
                        SerialNumber = 345234, Description = "Car", DateOfPurchase = "24.8.2013.", MonthsOfWarranty = 48,
                        Price = 200000, ExpirationDate= "24.8.2014.", Kilometers = 350000,Manufacturer=Manufacturer.Nissan
                    } */
            };

            var allCellPhones = new List<CellPhone>()
            {
                new CellPhone(Guid.NewGuid(), "Android", new DateTime(2015,5,30),TimeSpan.FromDays(365), 5000, ManufacturerPhones.Samsung, true,
                    "Marko V",
                    "0982324156"),
                new CellPhone(Guid.NewGuid(), "IPhone", new DateTime(2017,10,30),TimeSpan.FromDays(36*12), 10000, ManufacturerPhones.Apple, true,
                    "Karlo Jukic",
                    "095/1234/567"),
                new CellPhone(Guid.NewGuid(), "Windows Phone", new DateTime(2018,2,9),TimeSpan.FromDays(365), 4000, ManufacturerPhones.Nokia, true,
                    "Nikola D",
                     "099-908-7654")
            };

            var allComputers = new List<Computer>()
            {
                new Computer(Guid.NewGuid(), "16GB RAM,512GB SSD", new DateTime(2018,8,30), TimeSpan.FromDays(36*12), 7000, ManufacturerComputers.Asus,
                    true,
                    "Windows 10", true),
                new Computer(Guid.NewGuid(), "8GB RAM,1TB HDDD", new DateTime(2017,7,24),TimeSpan.FromDays(365), 5500, ManufacturerComputers.Acer,
                    true,
                    "Linux", true),
                new Computer(Guid.NewGuid(), "12GB RAM,256GB SSD+1TB SSD", new DateTime(2018,4,20), TimeSpan.FromDays(36*12), 6000,
                    ManufacturerComputers.Lenovo,
                    true, "Windows 10", true)
            };
            

            var generalChoice = 1;

            while (generalChoice != 0)
            {
                Console.WriteLine("Unesi 1 za dodavanje novih clanova");
                Console.WriteLine("Unesi 2 za ispis svih komada invertara na uneseni serijski broj");
                Console.WriteLine("Unesi 3 za ispis svih racunala kojima garancija istice u godini koju zelis");
                Console.WriteLine("Unesi 4 za ispis broja komada tehnoloske opreme koje imaju bateriju");
                Console.WriteLine("Unesi 5 za ispis svih mobitela ciju marku zelis ili svih racunala s operacijskim sustavom kojeg zelis");
                Console.WriteLine("Unesi 6 za ispis imena i brojeva vlasnika mobitela kojem garancija istice u godini koju zelis");
                Console.WriteLine("Unesi 7 za ispis svih vozila kojima registracija istice u sljedecih mjesec dana");
                Console.WriteLine("Unesi 8 za ispis cijene pri kupnji i trenutne cijene");
                Console.WriteLine("Unesi 0 za izlaz iz izbornika");

                generalChoice = int.Parse(Console.ReadLine());

                switch (generalChoice)
                {
                    case 1:
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
                                case 0:
                                    Console.WriteLine("Izlaz");
                                    break;
                                default:
                                    Console.WriteLine("Krivi unos");
                                    break;
                            }
                        }

                        break;
                    case 2:
                        PrintFromSerialNumber(allVehicles);
                        break;
                    case 3:
                        PrintComputersWithYear(allComputers);
                        break;
                    case 4:
                        HowManyComputersWithBattery(allComputers);
                        HowManyCellPhonesWithBattery(allCellPhones);
                        break;

                    case 5:
                        Console.WriteLine("Zelis li upisati marku mobitela ili operacijski sutav racunala?");
                        Console.WriteLine("1-mobitel,2-racunalo");
                        var choice3 = int.Parse(Console.ReadLine());
                        if (choice3 ==1)
                        {
                            Console.WriteLine("Upisi marku mobitela");
                            var name = Console.ReadLine();
                            HowManyCellPhonesByBrand(allCellPhones,name);
                        }
                        else if (choice3 == 2)
                        {
                            Console.WriteLine("Unesi operacijski sustav racunala");
                            var system = Console.ReadLine();
                            HowManyComputersWithOperationSystem(allComputers,system);
                        }
                        else
                        {
                            Console.WriteLine("Krivi upis");
                        }
                        break;
                    case 6:
                        PrintNamesAndNumbersWithYear(allCellPhones);
                        break;
                    case 7:
                        PrintVehiclesWithMonth(allVehicles);
                        break;
                    case 8:
                        Console.WriteLine("Odredi zelis li ispis za kompjutere(1),mobitele (2) ili vozila(3)");
                        var choice4 = int.Parse(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            PrintPurchaseAndCurrentPriceOfComputers(allComputers);
                        } 
                       
                        else if (choice4 == 2)
                        {
                            PrintPurchaseAndCurrentPriceOfCellPhones(allCellPhones);
                        }
                        
                        else if (choice4 == 3)
                        {
                            PrintPurchaseAndCurrentPriceOfVehicles(allVehicles);
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos");
                        }

                        break;
                    case 0:
                        Console.WriteLine("Izlaz");
                        break;
                    default:
                        Console.WriteLine("Kraj programa");
                        break;
                }
            }

            // Console.WriteLine("Poziv funkcije za serijski broj");
           // PrintFromSerialNumber(allVehicles);
       

        }

        static List<Vehicles> AddElementsToVehicles(List<Vehicles> myVehicles)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("ExpirationDate=");
            var expirationDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Kilometers=");
            var kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Manufacturer= (1-Mercedes,2-Bmw,3-Nissan,4-Suzuki,5-Honda)");           
            var manufacturer = int.Parse(Console.ReadLine());
            var manufacturerToAdd = ManufacturerVehicles.Mercedes;
            if (manufacturer == 1)
                manufacturerToAdd = ManufacturerVehicles.Mercedes;
            else if (manufacturer == 2)
                manufacturerToAdd = ManufacturerVehicles.Bmw;
            else if (manufacturer == 3)
                manufacturerToAdd = ManufacturerVehicles.Nissan;
            else if (manufacturer == 4)
                manufacturerToAdd = ManufacturerVehicles.Suzuki;
            else if (manufacturer == 5)
                manufacturerToAdd = ManufacturerVehicles.Honda;
            
            var myVehicle = new Vehicles(Guid.NewGuid(), description,dateOfPurchase, monthsOfWarranty, price,
                manufacturerToAdd, expirationDate, kilometers);
           
            myVehicles.Add(myVehicle);
            return myVehicles;
        }

        static List<CellPhone> AddElementsToCellPhones(List<CellPhone> myCellPhones)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("Manufacturer= (1-Samsung,2-Nokia,3-Sony,4-Apple)");
            var manufacturer = int.Parse(Console.ReadLine());
            var manufacturerToAdd = ManufacturerPhones.Samsung;
            if (manufacturer == 1)
                manufacturerToAdd = ManufacturerPhones.Samsung;
            else if (manufacturer == 2)
                manufacturerToAdd = ManufacturerPhones.Nokia;
            else if (manufacturer == 3)
                manufacturerToAdd = ManufacturerPhones.Sony;
            else if (manufacturer == 4)
                manufacturerToAdd = ManufacturerPhones.Apple;
         

            Console.WriteLine("Unesi ima li bateriju?1-da,2-ne");
            var choiceForBattery = int.Parse(Console.ReadLine());
            var hasBattery = true;
            if (choiceForBattery == 1)
                hasBattery = true;
            else
            {
                hasBattery = false;
            }
            Console.WriteLine("Unesi ime i prezime osobe");
            var nameAndSurname = Console.ReadLine();
            Console.WriteLine("Unesi broj osobe");
            var phoneNumber =Console.ReadLine();

            var myPhone = new CellPhone(Guid.NewGuid(), description, dateOfPurchase, monthsOfWarranty, price,
                manufacturerToAdd, hasBattery, nameAndSurname, phoneNumber);
            myCellPhones.Add(myPhone);
            return myCellPhones;
        }

        static List<Computer>AddElementsToComputers(List<Computer> myComputers)
        {
            Console.WriteLine("Description= ");
            var description = Console.ReadLine();
            Console.WriteLine("DateOfPurchase=");
            var dateOfPurchase = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("MonthsOfWarranty=");
            var monthsOfWarranty = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Price=");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi ima li bateriju?1-da,2-ne");
            var hasBattery = true;
            var choiceForBattery = int.Parse(Console.ReadLine());
            if (choiceForBattery == 1)
                hasBattery = true;
            else
            {
                hasBattery = false;
            }
            Console.WriteLine("Unesi ime operacijskog sustava");
            var operationSystem = Console.ReadLine();
            Console.WriteLine("Unesi je li racunalo prijenosno");
            var choiceForPortable = int.Parse(Console.ReadLine());
            var isPortable = true;
            if (choiceForPortable == 1)
                isPortable = true;
            else
            {
                isPortable = false;
            }

            var myComputer = new Computer(Guid.NewGuid(), description, dateOfPurchase, monthsOfWarranty, price,
                ManufacturerComputers.Acer, hasBattery, operationSystem, isPortable);
            myComputers.Add(myComputer);
            return myComputers;
        }

       static void PrintFromSerialNumber(List<Vehicles> vehicle1)
        {
         
           Console.WriteLine("Unesi serijski broj");
            
            var serialNumberInput = Console.ReadLine();
            var counter = 1;
            foreach (var vehicle in vehicle1)
            {
                if (vehicle.SerialNumber.ToString() == serialNumberInput)
                {
                    Console.WriteLine(vehicle.Description);
                    Console.WriteLine(vehicle.DateOfPurchase);
                    Console.WriteLine(vehicle.MonthsOfWarranty);
                    Console.WriteLine(vehicle.Price);
                    Console.WriteLine(vehicle.Manufacturer);
                    Console.WriteLine(vehicle.ExpirationDate);
                    Console.WriteLine(vehicle.Kilometers);
                }
                else
                {
                    Console.WriteLine($"{counter}. vozilo nema taj serijski broj");
                }

                counter++;
            }
        } 
        
        static void PrintComputersWithYear(List<Computer> computers)
        {
            Console.WriteLine("Unesi godinu");
            var year=int.Parse(Console.ReadLine());
            var counter = 0;
            foreach (var computer in computers)
            {
                if ((computer.DateOfPurchase.Year + (int) (computer.MonthsOfWarranty.TotalDays) / 365) == year)
                {
                    PrintComputers(computer);
                    counter++;
                }
            }
            if(counter==0)
                Console.WriteLine("Računalo s tom godinom isteka garancije ne postoji");
        }

        static void PrintComputers(Computer computers)
        {
                Console.WriteLine("\n");
                Console.WriteLine(computers.SerialNumber);
                Console.WriteLine(computers.Description);
                Console.WriteLine(computers.DateOfPurchase);
                Console.WriteLine(computers.MonthsOfWarranty);
                Console.WriteLine(computers.Price);
                Console.WriteLine(computers.Manufacturer);
                Console.WriteLine(computers.HasBattery);
                Console.WriteLine(computers.OperationSystem);
                Console.WriteLine(computers.IsPortable); 
                Console.WriteLine("\n");
            
            
        }
        static void PrintCellPhones(CellPhone cellPhone)
        {
            Console.WriteLine("\n");
            Console.WriteLine(cellPhone.SerialNumber);
            Console.WriteLine(cellPhone.Description);
            Console.WriteLine(cellPhone.DateOfPurchase);
            Console.WriteLine(cellPhone.MonthsOfWarranty);
            Console.WriteLine(cellPhone.Price);
            Console.WriteLine(cellPhone.Manufacturer);
            Console.WriteLine(cellPhone.HasBattery);
            Console.WriteLine(cellPhone.NameAndSurname);
            Console.WriteLine(cellPhone.PhoneNumber);
            Console.WriteLine("\n");


        }
        static void HowManyCellPhonesWithBattery(List<CellPhone> myCellPhones)
        {
            var hasBatteryCounter = 0;
            foreach (var cellPhone in myCellPhones)
            {
                if (cellPhone.HasBattery == true)
                {
                    hasBatteryCounter++;
                }
            }

            Console.WriteLine($"U invertaru ima {hasBatteryCounter} mobitela s baterijom \n");
        }

        static void HowManyComputersWithBattery(List<Computer> myComputers)
        {
            var hasBatteryCounter = 0;
            foreach (var computer in myComputers)
            {
                if (computer.HasBattery == true)
                    hasBatteryCounter++;
            }

            Console.WriteLine($"U invertaru ima {hasBatteryCounter} kompjutera s baterijom");
        }

        static void HowManyCellPhonesByBrand(List<CellPhone> myCellPhones,string name)
        {
            var foundedPhones = myCellPhones.FindAll(i => i.Manufacturer.ToString() == name);
            var counter = 0;
            foreach (var cellPhone in foundedPhones)
            {
                counter++;
                PrintCellPhones(cellPhone);
            }
       
            Console.WriteLine($"U inventaru ima {counter} mobitela s trazenom markom \n");
        }

        static void HowManyComputersWithOperationSystem(List<Computer> myComputers, string system)
        {
            var counter = 0;
            foreach (var computer in myComputers)
            {
                if (computer.OperationSystem == system)
                {
                    counter++;
                    PrintComputers(computer);
                    
                }
            }

            Console.WriteLine($"U invertaru se nalazi {counter} racunala s takvim operacijskim sustavom");

        }
        static void PrintNamesAndNumbersWithYear(List<CellPhone> cellPhones)
        {
            Console.WriteLine("Unesi godinu");
            var year = int.Parse(Console.ReadLine());
            var counter = 0;
            foreach (var cellPhone in cellPhones)
            {
                if ((cellPhone.DateOfPurchase.Year + (int)(cellPhone.MonthsOfWarranty.TotalDays) / 365) == year)
                {
                    Console.WriteLine(cellPhone.NameAndSurname);
                    Console.WriteLine(cellPhone.PhoneNumber);
                    counter++;
                }
            }
            if (counter == 0)
                Console.WriteLine("Mobitel s tom godinom isteka garancije ne postoji");
        }

        static void PrintVehiclesWithMonth(List<Vehicles> myVehicles)
        {
            foreach (var myVehicle in myVehicles)
            {
                if ((myVehicle.ExpirationDate.Month - DateTime.Now.Month)<=1 && (myVehicle.ExpirationDate.Month - DateTime.Now.Month)>=0 && (myVehicle.ExpirationDate.Year-DateTime.Now.Year)>=0 && (myVehicle.ExpirationDate.Year-DateTime.Now.Year)<=1)
                {
                    PrintVehicles(myVehicle);
                }
            }
        }
        static void PrintVehicles(Vehicles vehicle)
        {
            Console.WriteLine("\n");
            Console.WriteLine(vehicle.SerialNumber);
            Console.WriteLine(vehicle.Description);
            Console.WriteLine(vehicle.DateOfPurchase);
            Console.WriteLine(vehicle.MonthsOfWarranty);
            Console.WriteLine(vehicle.Price);
            Console.WriteLine(vehicle.Manufacturer);
            Console.WriteLine(vehicle.ExpirationDate);
            Console.WriteLine(vehicle.Kilometers);
            Console.WriteLine("\n");
        }

        static void PrintPurchaseAndCurrentPriceOfVehicles(List<Vehicles> myVehicle)
        {
            foreach (var vehicle in myVehicle)
            {
                var purchasePrice = vehicle.Price;
                var difference = 0.0;

                var kilometers = vehicle.Kilometers;
                while (kilometers > 0)
                {
                    if (kilometers / 20000 >= 1)
                    {

                        purchasePrice = 0.9 * purchasePrice;
                        difference = vehicle.Price - purchasePrice;

                        if (purchasePrice <= 0.2 * vehicle.Price)
                        {

                            //  Console.WriteLine(" Trenutna cijena vozila je :{0}\t,a razlika je :{1}\n", purchasePrice, difference);
                            Console.WriteLine($"Trenutna cijena je {purchasePrice}");

                            break;
                        }

                        kilometers -= 20000;

                    }
                }

                if (purchasePrice > 0.2 * vehicle.Price)
                {

                    //Console.WriteLine("Trenuta cijena vozila je {0},a razlika je {1}",purchasePrice,difference);
                    Console.WriteLine($"Trenutna cijena {purchasePrice}");
                }
            }


        }

        static void PrintPurchaseAndCurrentPriceOfCellPhones(List<CellPhone> cellPhones)
        {
            foreach (var phones in cellPhones)
            {
                var price = phones.Price;
                var today = DateTime.Now;
                var todayTotal = today.Day + 30 * today.Month;
                var todayTotalDays = todayTotal + today.Year * 365;
               

                var purchaseDate = phones.DateOfPurchase;
                var purchaseDateTotal = purchaseDate.Day + 30 * purchaseDate.Month;
                var purchaseDateTotalDays = purchaseDateTotal + purchaseDate.Year * 365;

                var difference = 0.0;

                while (todayTotalDays-purchaseDateTotalDays > 0)
                {
                    if (todayTotalDays - purchaseDateTotalDays > 30)
                    {
                        price = 0.95 * price;
                        difference = phones.Price - price;

                        if (price <= 0.3 * phones.Price)
                        {
                            Console.WriteLine($"Trenutna cijena je {price}");
                            Console.WriteLine($"Razlika je {difference}");
                            PrintCellPhones(phones);
                            break;
                        }

                        
                    }
                    else if((todayTotalDays-purchaseDateTotalDays)<30 && (todayTotalDays-purchaseDateTotalDays)>0)
                    {
                        price = 0.95 * price;
                        difference = phones.Price - price;
                        break;
                    }

                    todayTotalDays -= 30;

                }

                if (price > 0.3 * phones.Price)
                {
                    
                    Console.WriteLine($"Trenutna cijena je {price}");
                    Console.WriteLine($"Razlika je {difference}");

                    PrintCellPhones(phones);
                }
            }

         }
        static void PrintPurchaseAndCurrentPriceOfComputers(List<Computer> computers)
        {
            foreach (var computer in computers)
            {
                var price = computer.Price;
                var today = DateTime.Now;
                var todayTotal = today.Day + 30 * today.Month;
                var todayTotalDays = todayTotal + today.Year * 365;


                var purchaseDate = computer.DateOfPurchase;
                var purchaseDateTotal = purchaseDate.Day + 30 * purchaseDate.Month;
                var purchaseDateTotalDays = purchaseDateTotal + purchaseDate.Year * 365;

                var difference = 0.0;

                while (todayTotalDays - purchaseDateTotalDays > 0)
                {
                    if (todayTotalDays - purchaseDateTotalDays > 30)
                    {
                        price = 0.95 * price;
                        difference = computer.Price - price;

                        if (price <= 0.3 * computer.Price)
                        {
                            Console.WriteLine($"Trenutna cijena je {price}");
                            Console.WriteLine($"Razlika je {difference}");

                            PrintComputers(computer);

                            break;
                        }


                    }
                    else if ((todayTotalDays - purchaseDateTotalDays) < 30 && (todayTotalDays - purchaseDateTotalDays) > 0)
                    {
                        price = 0.95 * price;
                        difference = computer.Price - price;
                        break;
                    }

                    todayTotalDays -= 30;

                }

                if (price > 0.3 * computer.Price)
                {
                    
                    Console.WriteLine($"Trenutna cijena je {price}");
                    Console.WriteLine($"Razlika je {difference}");
                    PrintComputers(computer);
                }
            }

        }

    }
}

