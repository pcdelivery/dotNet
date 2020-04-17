using System;
using System.Collections.Generic;
using System.Text;
using OfficeStoreApp.Domain.Contracts;

namespace OfficeStoreApp.Domain
{
    class BoxedProduct : IBoxedProduct
    {
        public Product ProductInStack { set; get; }

        public int Quantity { set; get; }

        public BoxedProduct(Product productToPutInStack, int numberOfProduct)
        {
            ProductInStack = productToPutInStack;
            Quantity = numberOfProduct;
        }
    }
}
