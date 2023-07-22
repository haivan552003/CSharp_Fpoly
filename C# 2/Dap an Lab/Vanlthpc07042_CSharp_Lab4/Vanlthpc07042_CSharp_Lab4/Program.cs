using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
        menu
            :
            Console.WriteLine("MENU LAB 4\n");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("3. Bai 3");
            Console.WriteLine("4. Bai 4");
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
                case 3:
                    bai3.Bai3();
                    break;
                case 4:
                    bai4.Bai4();
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
