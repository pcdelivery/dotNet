using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain
{
    class TransactionContent
    {
        public List<Product> Products { set; get; }

        public List<int> Quantity { set; get; }
    }
}
