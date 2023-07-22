using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide8
{
    public delegate T vdTdelegate<T>(T a, T b);
    public class Tdelegate
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)

        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("3. Bai 3");
            Console.WriteLine("4. Bai 4");
            Console.WriteLine("Chon chuc nang");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Product prd = new Product();
                    prd.Nhap();
                    Console.WriteLine(prd.ToString());
                    Console.ReadLine();
                    break;
                case 2:
                    Hashtable weekday = new Hashtable(); //chay theo ngan xep
                    weekday.Add(1, "Sunday");
                    weekday.Add(2, "Monday");
                    weekday.Add(3, "Tuesday");
                    weekday.Add(4, "Wednesday");
                    weekday.Add(5, "Thurday");
                    weekday.Add(6, "Friday");
                    weekday.Add(7, "Saturday");
                    foreach (DictionaryEntry item in weekday)
                    {
                        Console.WriteLine("key " + item.Key + " value " + item.Value);

                    }
                    Console.WriteLine(weekday.ContainsValue("Tuesday"));
                    Console.ReadLine();
                    break;
                case 3:
                    int x = 0, y = 5;
                    swap(ref x, ref y);
                    Console.WriteLine("x: {0} - y: {1}", x, y);
                    double m = 7.5, k = 2.5;
                    swap(ref m, ref k);
                    Console.WriteLine("m: {0} - k: {1}", m, n);
                    break;
                case 4:
                    Tdelegate mn = new Tdelegate();
                    vdTdelegate<int> dlgt = new vdTdelegate<int>(mn.add);
                    Console.WriteLine("Add result: " + dlgt(90, 10));
                    dlgt = mn.sub;
                    Console.WriteLine("Sub result: " + dlgt(90, 10));
                    break;
                default:
                    break;
            }
        }
    }
}
