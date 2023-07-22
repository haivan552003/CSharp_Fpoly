using Bai1;
using System;

internal class Program
{
    public class PrintHelper
    {
        public delegate void BeforePrint();
        public event BeforePrint beforePrinkEvent;
        public PrintHelper() {  }
        public void PrintNumber(int num) {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Number: {0,-12:N0}",num);
        }
        public void PrintDemical(int dec) {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Demical: {0:G}",dec);
        }
        public void PrintMoney(int money)
        {
            if (beforePrinkEvent != null)
            {
                beforePrinkEvent();
            }
            Console.WriteLine("Money:{0:C}", money);
        }
        public void PrintTemperature(int num) {
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
        static void Main(string[] args)
        {
            // B
            TinhToan tt = new TinhToan();
            Toan toan = tt.tong;
            toan += tt.hieu;
            toan += tt.Tich;
            toan += tt.Thuong;
            toan(90 , 10);
        }

    }
    
   
}