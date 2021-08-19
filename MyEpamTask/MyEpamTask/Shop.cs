using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class Shop: Product
    {
        public Shop(String name, Byte count, DateTime date, Double price)
            : base(name, count, date, price) { }
        public Shop(String name, Byte count, DateTime date, Double price, IDiscount discount)
            : base(name, count, date, price, discount) { }
    }
}
