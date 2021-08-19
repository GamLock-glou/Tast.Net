using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    interface IDiscount
    {
        // Discount price metod.
        Double SetPrice(Double price, Byte count);

        // Output discount method.
        // можно было бы не создавать, если переопределять метод ToString, то можно было бы обойтись без этого метода.
        String ToDisplay();
    }
}
