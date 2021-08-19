using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class SpecifiedDiscount : IDiscount
    {
        private Int32 Percent;

        public SpecifiedDiscount(int percent)
        {
            Percent = percent;
        }

        public double SetPrice(Double price, Byte count)
        {
            return ((price * count) * (1.00 - Percent / 100.00));
        }

        // Пометка для себя! (Если читаете код, не обращайте внимания))
        //___________________________________________________________
        // public override string ToString()
        //{
        //  return string.Format("Your discount has: {0}%", Percent);
        //}
        //___________________________________________________________
        public string ToDisplay()
        {
            return string.Format($" Ваша скидка составляет: {Percent}%");
        }
    }
}
