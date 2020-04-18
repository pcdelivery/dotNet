using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeStoreApp.Domain.Contracts
{
    interface IProduct
    {
        public int Id { set; get; }

        public List<string> Type { set; get; }

        public string Title { set; get; }
    }
}
