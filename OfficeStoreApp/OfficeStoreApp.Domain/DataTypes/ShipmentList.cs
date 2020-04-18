using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using OfficeStoreApp.Domain.ServiceModules;

namespace OfficeStoreApp.Domain.DataTypes
{
    //@todo: IEnumerable<> implementation
    public static class ShipmentList
    {
        /// <summary>
        /// Depends on ManufacturesList
        /// </summary>
        /// <returns></returns>
        public static List<Shipment> GenerateDefault()
        {
            List<Shipment> resultList = new List<Shipment>();

            if (ManufacturerList._lastList.Count <= 0)
                return resultList;

            // ShipmentList (whole tab) generated shipment by shipment
            for (int i = 0; i < RandomNumberGenerator.GetInt32(1, 15); i++)
            {
                List<BoxedProduct> productsToShip = new List<BoxedProduct>();
                DateTime beginTime = DateTime.Now, endTime = DateTime.Now;

                // productsToShip list fill
                for (int j = 0; j < RandomNumberGenerator.GetInt32(1, 10); j++)
                {
                    productsToShip.Add(new BoxedProduct(
                        new Product("Product #" + j.ToString()),
                        RandomNumberGenerator.GetInt32(1, 1000)));
                }

                DateGenerator.GenerateDatePeriod(beginTime, endTime);

                resultList.Add(new Shipment(
                    ManufacturerList._lastList[RandomNumberGenerator.GetInt32(1, ManufacturerList._lastListCounter)],
                    productsToShip, beginTime, endTime));
            }

            return resultList;
        }
    }
}
