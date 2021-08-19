using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEpamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list with type DateTime and add date items.
            List<DateTime> dateTimes = new List<DateTime>()
            {
                new DateTime(2015, 10, 10),
                new DateTime(2021, 03, 21),
                new DateTime(2021, 09, 11),
                new DateTime(2021, 11, 15),
                new DateTime(2020, 01, 10),
                new DateTime(2021, 05, 01),
                new DateTime(2021, 02, 11),
                new DateTime(2021, 03, 21),
                new DateTime(2021, 12, 10),
                new DateTime(2017, 07, 05)
            };
            //Create list with type Product and add product.
            List<Product> list_Product = new List<Product>()
            {
                new Shop("Диван", 2, dateTimes[0], 800.00),
                new Shop("Стул", 4, dateTimes[1], 65.00, new SpecifiedDiscount(25)),
                new Shop("Кресло", 1, dateTimes[2], 200.00, new SpecifiedDiscount(11)),
                new Shop("Лампа", 3, dateTimes[3], 40.00),
                new Shop("Кровать", 2, dateTimes[4], 320.00, new FixedDiscount(10)),
                new Shop("Шкаф", 10, dateTimes[5], 900.00, new Bonus()),
                new Shop("Тумбочка", 1, dateTimes[6], 75.00),
                new Shop("Раздвижной шкаф", 7, dateTimes[7], 1200.00, new Bonus()),
                new Shop("Пуфик", 1, dateTimes[8], 320.00, new FixedDiscount(40)),
                new Shop("Кресло качалка", 5, dateTimes[9], 500.00, new SpecifiedDiscount(11))
            };



            //Output a list of 10.
            UInt32 sold_in_the_tenth_month = 0;
            foreach (var value in list_Product)
            {
                value.ToDisplay();
                if ("10" == value.Day.ToString("dd"))
                    sold_in_the_tenth_month++;
            }

            Console.WriteLine($"\n{sold_in_the_tenth_month} покупки(ок) 10ого числа");

            //Sort the list by date.
            list_Product.Sort();
            Console.WriteLine($"\nСортированные товары по ДАТЕ: \n");
            foreach (var value in list_Product)
            {
                Console.WriteLine(value.ToDisplay());
            }
            
            
            SortItems(list_Product);
            Console.ReadLine();

        }

        //In this method, we use the 'as' operator to define sheet elements in a particular discount.
        static void SortItems(List<Product> products)
        {
            Console.WriteLine("\nСортированные товары по КАТЕГОРИЯМ:");
            Console.WriteLine("\nКатегория 'ОБЫЧНАЯ':");
            foreach (var item in products)
            {
                if (item.Discount == null)
                {
                    Console.WriteLine(item.ToDisplay());
                }
            }
            Console.WriteLine("\nКатегория 'СО СКИДКОЙ ПО ПРОЦЕНТУ':");
            foreach (var item in products)
            {
                if (item.Discount is SpecifiedDiscount)
                {
                    Console.WriteLine(item.ToDisplay());
                }
            }
            Console.WriteLine("\nКатегория 'СО СКИДКОЙ НА ТРАНСПОРТ':");
            foreach (var item in products)
            {
                if (item.Discount is FixedDiscount)
                {
                    Console.WriteLine(item.ToDisplay());
                }
            }
            Console.WriteLine("\nКатегория 'С БОНУСНОЙ СКИДКОЙ':");
            foreach (var item in products)
            {
                if (item.Discount is Bonus)
                {
                    Console.WriteLine(item.ToDisplay());
                }
            }
        }
    }
}
