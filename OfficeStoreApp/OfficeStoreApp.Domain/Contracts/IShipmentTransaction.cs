using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain.Contracts
{
    interface IShipmentTransaction
    {
        public Manufacturer Manufacturer { set; get; }

        public List<BoxedProduct> ContentToShip { set; get; }

        public DateTime PurchaseDate { set; get; }

        public DateTime ShipmentDateBegin { set; get; }

        public DateTime ShipmentDateEnd { set; get; }
    }
}
