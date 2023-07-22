using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab1_Bai3
{
    partial class clsCalculation
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Output Addition is {0}", a + b);
        }

        public void Substration(int a, int b)
        {
            Console.WriteLine("Output Substration is {0}", a - b);
        }
    }

    partial class clsCalculation
    {
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Output Multiplication is {0}", a * b);
        }

        public void Division(int a, int b)
        {
            Console.WriteLine("Output Division is {0}", a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsCalculation objCal = new clsCalculation();
            objCal.Addition(2, 3);
            objCal.Division(2, 2);
            objCal.Multiplication(2, 3);
            objCal.Substration(2, 3);

            Console.Read();
        }
    }
}
