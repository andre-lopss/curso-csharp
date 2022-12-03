﻿using System;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter rental data");
                Console.Write("Car model: ");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Enter price per hour: ");
                double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));
                RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
                rentalService.ProcessInvoice(carRental);

                Console.WriteLine("Invoice: ");
                Console.WriteLine(carRental.Invoice);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
