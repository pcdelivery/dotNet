using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain.Contracts
{
    interface IBoxedProduct
    {
        public Product ProductInStack { set; get; }

        public int Quantity { set; get; }
    }
}
