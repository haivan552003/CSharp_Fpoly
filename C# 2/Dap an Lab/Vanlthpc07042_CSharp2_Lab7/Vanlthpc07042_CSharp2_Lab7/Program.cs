using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine("MENU LAB 7\n");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("Chon chuc nang: ");
            int chosee = Convert.ToInt32(Console.ReadLine());

            switch (chosee)
            {
                case 1:
                    bai1.Bai1();
                    break;
                case 2:
                    bai2.Bai2();
                    break; 
                default:
                    Console.Clear();
                    break;
            }

            Console.WriteLine("Chon 0 de tiep tuc chuong trinh");

            chosee = Convert.ToInt32(Console.ReadLine());
            if (chosee == 0)
            {
                Console.Clear();
                goto menu;
            }
            Console.ReadLine();
        }
    }
}

