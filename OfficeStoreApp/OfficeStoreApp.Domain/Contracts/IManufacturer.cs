using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain.Contracts
{
    interface IManufacturer
    {
        public int Id { get; }

        public DateTime EstablishedDate { get; }

        public double TrustRating { get; }
    }
}
