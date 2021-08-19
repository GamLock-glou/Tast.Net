using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class FixedDiscount : IDiscount
    {
        private Int32 Discount_Transport;
        private Byte Count;

        public FixedDiscount(Int32 discount_transport) 
        {
            Discount_Transport = discount_transport;
           
        }
        public double SetPrice(Double price, Byte count)
        {
            Count = count;
            return (price - Discount_Transport) * count;
        }

        public string ToDisplay()
        {
            return string.Format($" Ваша скидка составляет: {Discount_Transport * Count} BYR за доставку");
        }
    }
}
