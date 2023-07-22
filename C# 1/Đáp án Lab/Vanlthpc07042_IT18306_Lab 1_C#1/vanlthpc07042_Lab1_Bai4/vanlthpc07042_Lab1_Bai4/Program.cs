using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh delta");

            int a, b, c;
            double delta;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;
            
            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("Can Delta: " + Math.Sqrt(Math.Abs(delta))); //dung gia tri tuyet doi de can duoc neu delta am

            Console.ReadKey();
        }
    }
}
