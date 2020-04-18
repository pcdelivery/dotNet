using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using OfficeStoreApp.Domain;
using OfficeStoreApp.Domain.DataTypes;

// public String[] _prdc = { "Printer", "Scaner", "Blue Pen", "Red Pen", "Pencil", "Paper A4", "Paper A3" };

namespace OfficeStoreApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String[] _mns = { "Bic", "Promex", "TPromo", "Azure", "Xerox" };
            String[] _dates = { "7/11/1878", "10/01/1912", "1/5/2001", "8/16/1954", "4/30/1989" };
            //List<Manufacturer> manList = new List<Manufacturer>();
            List<Manufacturer> manList = ManufacturerList.GenerateDefault();
            List<Shipment> shipList = ShipmentList.GenerateDefault();

            foreach (var shipTransaction in shipList)
                shipTransaction._display(1);


            // 1 окно - Все производители
            foreach (Manufacturer manufacturer in manList)
            {
                manufacturer._display();
            }

            Console.Write("\n\n");

            // 2 окно - Все производители, рейтинг которых ОТ
            foreach (Manufacturer manufacturer in manList)
            {
                if (manufacturer.TrustRating > 3)
                    manufacturer._display();
            }

            Console.Write("\n\n");

            // 3 окно - Все НЕПУСТЫЕ производители
            foreach (Manufacturer manufacturer in manList)
            {
                if (!manufacturer.IsEmpty())
                    manufacturer._display();
            }
        }
    }
}
