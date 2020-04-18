using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OfficeStoreApp.Domain.DataTypes
{
    public static class ManufacturerList
    {
        static String[] TitleArray = { "Bic", "Promex", "TPromo", "Azure", "Xerox" };
        static String[] CreationDateArray = { "7/11/1878", "10/01/1912", "1/5/2001", "8/16/1954", "4/30/1989" };

        public static List<Manufacturer> _lastList { get; set; }
        public static int _lastListCounter { get; set; }

        public static List<Manufacturer> GenerateDefault()
        {
            List<Manufacturer> manList = new List<Manufacturer>();

            for (int i = 0; i < TitleArray.Length && i < CreationDateArray.Length; i++)
            {
                Manufacturer newMan = new Manufacturer(TitleArray[i], CreationDateArray[i]);
                newMan.Register(newMan.Id, "Bla-bla-blah " + newMan.Id.ToString());

                // Generating product which manufacture offers
                for (int j = 0; j < RandomNumberGenerator.GetInt32(0, 3); j++)
                {
                    newMan.PutToWarehouse(
                        new Product("Product #" + j.ToString()),
                        RandomNumberGenerator.GetInt32(1, 1000));
                }

                manList.Add(newMan);
            }

            _lastList = manList;
            _lastListCounter = _lastList.Count;
            return manList;
        }
    }
}
