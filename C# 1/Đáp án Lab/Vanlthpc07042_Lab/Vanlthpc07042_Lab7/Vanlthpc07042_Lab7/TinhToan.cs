using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab7
{
    public delegate void Toan(int x, int y);
    public class TinhToan
    {
        public void tong(int x, int y)
        {
            Console.WriteLine("Tong: " + (x + y));
        }
        public void hieu(int x, int y)
        {
            Console.WriteLine("Hieu: " + (x - y));
        }
        public void Tich(int x, int y)
        {
            Console.WriteLine("Tich: " + (x * y));
        }
        public void Thuong(int x, int y)
        {
            Console.WriteLine("Thuong: " + (x / y));
        }
    }
    public class PrintHelper
    {
        public delegate void BeforePrint();
        public event BeforePrint beforePrinkEvent;
        public PrintHelper() { }
        public void PrintNumber(int num)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Number: {0,-12:N0}", num);
        }
        public void PrintDemical(int dec)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Demical: {0:G}", dec);
        }
        public void PrintMoney(int money)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Money:{0:C}", money);
        }
        public void PrintTemperature(int num)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexademical(int dec)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Hexademical: {0:X}", dec);
        }
    }
}
