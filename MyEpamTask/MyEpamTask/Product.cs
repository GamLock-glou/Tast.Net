using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class Product : IComparable<Product>
    {
        public String NameProduct { get; private set; }
        public Byte Count { get; private set; }
        public DateTime Day { get; private set; }
        public Double Price { get; private set; }

        // Final discount for the entire batch.
        public Double FinalPrice 
        {
            get 
            {
                if (Discount != null)
                    return Discount.SetPrice(Price, Count);
                else return Price * Count;
            }
            private set { value = Price * Count; }
        }
        protected Product(String name, Byte count, DateTime date, Double price)
        {
            NameProduct = name;
            Count = count;
            Day = date;
            Price = price;
        }

        protected Product(String name, Byte count, DateTime date, Double price, IDiscount discount)
        {
            NameProduct = name;
            Count = count;
            Day = date;
            Price = price;
            Discount = discount;
        }

        // Sorting a sheet by day.
        public int CompareTo(Product day)
        {
            return Day.CompareTo(day.Day);
        }

        public string ToDisplay()
        {
            string discount;
            if (Discount != null)
                discount = Discount.ToDisplay().ToString();
            else discount = " Скидок нет!";
            return $"Имя продукта: {NameProduct}, Количество: {Count}, Дата покупки: {Day.ToString("d")}, Цена 1 товара {Price}, Стоимость партии товара: {FinalPrice}," +
                $"{discount}";
        }

        public IDiscount Discount;
    }
}
