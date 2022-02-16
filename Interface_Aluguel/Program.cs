using System;
using System.Globalization;
using System.Collections.Generic;
using Interface_Aluguel.Entities;
using Interface_Aluguel.Services;


namespace Interface_Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Model: ");
            string car = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciação de OBJETO
            CarRental carRental = new CarRental(start, finish, new Vehicle(car));

            RentalService rentalService = new RentalService(hour, day, new BrasilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
