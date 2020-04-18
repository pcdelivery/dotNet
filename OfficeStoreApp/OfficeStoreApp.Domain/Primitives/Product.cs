using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using OfficeStoreApp.Domain.Contracts;
using OfficeStoreApp.Domain.ServiceModules;

namespace OfficeStoreApp.Domain
{
    /// <summary>
    /// EAN-13
    /// </summary>
    public class Product : IProduct
    {
        public static int NextProductId = 1;

        public int Id { set; get; }

        public int [] Barcode { set; get; }

        //@todo
        // public BitArray BinaryBarcode { set; get; }
        
        public List<string> Type { set; get; }

        public string Title { set; get; }

        public DateTime ManufacturingDate { set; get; }

        public DateTime ExpirationDate { set; get; }

        public string Description { set; get; }

        public Product(string title)
        {
            Id = NextProductId++;
            Title = title;
            Barcode = new int[13];
            Type = new List<string>();

            for (int i = 0; i < 13; i++)
                Barcode[i] = RandomNumberGenerator.GetInt32(0, 10);

            for (int i = 0; i < RandomNumberGenerator.GetInt32(0, 5); i++)
                Type.Add("Type #" + Barcode[i].ToString());

            ManufacturingDate = DateGenerator.GenerateWideDateTime();
            ExpirationDate = DateGenerator.GenerateDateTime();
            Description = "Description #" + Id.ToString();
        }

        public void _display(int mode = 0)
        {
            string divider = mode == 0 ? "\t" : "\n";

            Console.Write(Id.ToString() + divider);
            Console.Write(Title + divider);
            Console.Write(String.Join("", Barcode) + divider);
            Console.Write(String.Join(",", Type) + divider);

            String date1 = ManufacturingDate.Year.ToString() + ":" + ManufacturingDate.Month.ToString();
            String date2 = ExpirationDate.Year.ToString() + ":" + ExpirationDate.Month.ToString();

            Console.Write(date1 + "-" + date2 + divider);
            Console.Write(Description + divider);
            Console.Write("\n");
        }
    }
}
