using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class Bonus:IDiscount
    {
        private Double Bonus_Price;

        public double SetPrice(double price, byte count)
        {
            Bonus_Price = price;
            return price * (count - 1);
        }

        public string ToDisplay()
        {
            return $" Ваша скидка - стоимость одного предмета: {Bonus_Price} BYR";
        }
    }
}
