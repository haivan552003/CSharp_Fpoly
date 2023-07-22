using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab2_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 1");
            float a, b;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.Write("Nghiem ca phuong trinh la: " + (-b / a));
            }
            
            Console.ReadKey();
        }
    }
}
