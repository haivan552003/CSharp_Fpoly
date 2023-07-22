using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide8
{
    internal class Program
    {
        static void Main(string[] args)
            
        {

            /*
              //bai2
             Hashtable weekday = new Hashtable(); //chay theo ngan xep
            weekday.Add(1, "Sunday");
            weekday.Add(2, "Monday");
            weekday.Add(3, "Tuesday");
            weekday.Add(4, "Wednesday");
            weekday.Add(5, "Thurday");
            weekday.Add(6, "Friday");
            weekday.Add(7, "Saturday");
            foreach(DictionaryEntry item in weekday)
            {
                Console.WriteLine("key " + item.Key + " value " + item.Value);

            }
            Console.WriteLine(weekday.ContainsValue("Tuesday"));
            Console.ReadLine();
             */

            //bai1
            Product prd = new Product();
            prd.Nhap();
            Console.WriteLine(prd.ToString());
            Console.ReadLine();

        }
    }
}
