using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide6
{
    internal class TinhToan
    {
        public void TinhTong(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }
        public void TinhTong(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = " + (a + b + c));
        }
        public void TinhTong(double a, double b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }
        public double TinhTong(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
