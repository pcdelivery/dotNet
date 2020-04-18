using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OfficeStoreApp.Domain.Contracts;
using OfficeStoreApp.Domain.ServiceModules;

namespace OfficeStoreApp.Domain
{
    public class Shipment : IShipmentTransaction
    {
        public Manufacturer Manufacturer { set; get; }

        public List<BoxedProduct> ContentToShip { set; get; }

        public DateTime PurchaseDate { set; get; }

        public DateTime ShipmentDateBegin { set; get; }

        public DateTime ShipmentDateEnd { set; get; }

        public Shipment(Manufacturer manufacturer, List<BoxedProduct> productsToShip,
            DateTime shipmentDateBegin, DateTime shipmentDateEnd)
        {
            Manufacturer = manufacturer;
            ContentToShip = productsToShip;
            PurchaseDate = DateTime.Now;
            ShipmentDateBegin = shipmentDateBegin;
            ShipmentDateEnd = shipmentDateEnd;
        }

        //@todo: ShipmentDateEnd dynamic change, ShipmentDateEnd == null at DateTime.Now
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturer"> Title to create new </param>
        /// <param name="shipmentDateBegin"> month/day/year </param>
        /// <param name="shipmentDateEnd"> month/day/year </param>
        public Shipment(string manufacturerTitle, List<BoxedProduct> productsToShip,
            string shipmentDateBegin, string shipmentDateEnd)
        {
            Manufacturer = new Manufacturer(manufacturerTitle, DateTime.Now);
            ContentToShip = productsToShip;
            PurchaseDate = DateTime.Now;
            ShipmentDateBegin = DateTime.Parse(shipmentDateBegin);
            ShipmentDateEnd = DateTime.Parse(shipmentDateEnd);
        }

        public bool IsDone => DateTime.Now.CompareTo(ShipmentDateEnd) >= 0 ? true : false;

        public void _display(int mode = 0)
        {
            string divider = mode == 0 ? "\t" : "\n";

            Console.Write("[Title]" + Manufacturer.Title + divider);

            int sum = 0;
            foreach (var box in ContentToShip)
            {
                Console.Write("[" + box.Quantity.ToString() + "]" + box.ProductInStack.Title + " ");
                sum += box.Quantity;
            }

            Console.Write("[sum]" + sum + divider);

            Console.Write("[PD]" + DateGenerator.DateToShortString(PurchaseDate) + divider);
            Console.Write("[ShB]" + DateGenerator.DateToShortString(ShipmentDateBegin) + divider);
            Console.Write("[ShE]" + DateGenerator.DateToShortString(ShipmentDateEnd) + divider);
            Console.Write("\n");
        }
    }
}
