using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain
{
    class Product
    {
        public static int NextProductId = 1;

        public int Id { set; get; }

        public int [] Barcode { set; get; }

        public BitArray BinaryBarcode { set; get; }

        public List<string> Type { set; get; }

        public string Title { set; get; }

        public Manufacturer Manufacturer { set; get; }

        public DateTime ManufacturingDate { set; get; }

        public DateTime ExpirationDate { set; get; }

        public int PurchasePrice { set; get; }

        public int SellPrice{ set; get; }

        public string Description { set; get; }
    }
}
