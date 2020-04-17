using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using OfficeStoreApp.Domain;

// public String[] _prdc = { "Printer", "Scaner", "Blue Pen", "Red Pen", "Pencil", "Paper A4", "Paper A3" };

namespace OfficeStoreApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String[] _mns = { "Bic", "Promex", "TechPromo", "Azure", "Xerox" };
            String[] _dates = { "7/11/1878", "10/01/1912", "1/5/2001", "8/16/1954", "4/30/1989" };
            List<Manufacturer> manList;

            for (int i = 0; i < _mns.Length && i < _dates.Length; i++)
            {
                Manufacturer newMan = new Manufacturer(_mns[i], _dates[i]);
                newMan.Register(newMan.Id, "Bla-bla-blah " + newMan.Id.ToString());

                for (int j = 0; j < RandomNumberGenerator.GetInt32(0, 15); j++)
                {
                    newMan.PutToWarehouse(new Product(), );
                }
            }
            ;
            // 1 окно - Все производители
            // 2 окно - Все производители, рейтинг которых ОТ
            // 3 окно - Все НЕПУСТЫЕ производители

        }
    }
}
