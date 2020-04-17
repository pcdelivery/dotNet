using System;
using System.Collections.Generic;
using System.Text;
using OfficeStoreApp.Domain;

namespace OfficeStoreApp.BLL.Contracts
{
    interface IShipmentGetService
    {
        IEnumerable<Shipment> GetAllShipments();

        IEnumerable<Shipment> GetShipmentById(int id);

        IEnumerable<Shipment> GetShipmentsInPeriod(DateTime from, DateTime to);

        IEnumerable<Shipment> GetActualShipments(DateTime from, DateTime to);
    }
}
