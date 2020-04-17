using System;
using System.Collections.Generic;
using System.Text;
using OfficeStoreApp.Domain.Contracts;

namespace OfficeStoreApp.Domain
{
    class Shipment : IShipmentTransaction
    {
        public int Id { set; get; }

        public Manufacturer Manufacturer { set; get; }

        public TransactionContent ProductsContent { set; get; }

        public DateTime PurchaseDate { set; get; }

        public DateTime ShipmentDate { set; get; }

        public bool IsDone => DateTime.Now.CompareTo(ShipmentDate) >= 0 ? true : false;
    }
}
