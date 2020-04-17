using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using OfficeStoreApp.Domain.Contracts;

namespace OfficeStoreApp.Domain
{
    class Manufacturer : IManufacturer
    {
        public static int NextManufacturerId = 1;

        public int Id { set; get; }

        public string Title { set; get; }

        public List<BoxedProduct> Supply { set; get; }

        public DateTime EstablishedDate { set; get; }

        public double TrustRating { set; get; }

        public string Description { set; get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateOfCreation"> month/day/year </param>
        public Manufacturer(string title, string dateOfCreation)
        {
            Title = title;
            EstablishedDate = DateTime.Parse(dateOfCreation);
            Id = NextManufacturerId++;
        }

        public void Register(double rating, string manufacturerDescription)
        {
            TrustRating = rating;
            Description = manufacturerDescription;
        }

        public void PutToWarehouse(Product productToPut, int number) =>
            Supply.Add(new BoxedProduct(productToPut, number));

        public bool IsEmpty() => Supply.Count == 0;

        public void _display(int mode = 0)
        {
            string divider = mode == 0 ? "|" : "\n";

            Console.Write(Id.ToString() + divider);
            Console.Write(Title + divider);
            Console.Write(EstablishedDate.Date.ToString() + divider);
            Console.Write(Supply.Count + divider);
            Console.Write(TrustRating.ToString() + divider);
            Console.Write(Description + divider);
            Console.Write("\n");
        }
    }
}
