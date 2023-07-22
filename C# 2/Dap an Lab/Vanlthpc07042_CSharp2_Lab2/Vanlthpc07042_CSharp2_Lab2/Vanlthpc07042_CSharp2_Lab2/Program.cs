using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            int chosee;
            Console.WriteLine("MENU LAB 2\n");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("Chon chuc nang: ");
            chosee = Convert.ToInt32(Console.ReadLine());

            switch (chosee)
            {
                case 1:
                    Console.Clear();
                    menubai1:
                    Console.WriteLine("1. Bai 1 - a");
                    Console.WriteLine("2. Bai 1 - b");
                    Console.WriteLine("3. Bai 1 - c");
                    Console.WriteLine("4. Bai 1 - d");
                    Console.WriteLine("Chon chuc nang: ");
                    chosee = Convert.ToInt32(Console.ReadLine());

                    switch (chosee)
                    {
                        case 1:
                            ImplicitlyVariable.bai1a();
                            break;
                        case 2:
                            bai1b.Bai1b();
                            break;
                        case 3:
                            bai1c.Bai1c();
                            break;
                        case 4:
                            bai1d.Bai1d();
                            break;
                        default:
                            Console.WriteLine("Khong co chuc nang");
                            Console.Clear();
                            goto menu;
                            break;
                    }
                    Console.WriteLine("Chon 1 de tiep tuc chuong trinh bai 1: ");
                    Console.WriteLine("Chon 0 de tiep tuc chuong trinh lab 2: ");
                    chosee = Convert.ToInt32(Console.ReadLine());
                    if (chosee == 1)
                    {
                        goto menubai1;
                    }
                    else if (chosee == 0)
                    {
                        goto menu;
                    }
                    break;
                case 2:
                    Console.Clear();
                menubai2:
                    Console.WriteLine("1. Bai 2 - a");
                    Console.WriteLine("2. Bai 2 - b");
                    Console.WriteLine("3. Bai 2 - c");
                    Console.WriteLine("4. Thoat chuong trinh");
                    Console.WriteLine("Chon chuc nang: ");
                    chosee = Convert.ToInt32(Console.ReadLine());

                    switch (chosee)
                    {
                        case 1:
                            bai2a.Bai2a();
                            break;
                        case 2:
                            bai2b.Bai2b();
                            break;
                        case 3:
                            bai2c.Bai2c();
                            break;
                        default:
                            Console.WriteLine("Khong co chuc nang");
                            Console.Clear();
                            goto menu;
                            break;
                    }
                    Console.WriteLine("Chon 1 de tiep tuc chuong trinh bai 2: ");
                    Console.WriteLine("Chon 0 de tiep tuc chuong trinh lab 2: ");
                    chosee = Convert.ToInt32(Console.ReadLine());
                    if (chosee == 1)
                    {
                        goto menubai2;
                    }
                    else if (chosee == 0)
                    {
                        goto menu;
                    }
                    break;
                    break;
                default:
                    Console.WriteLine("Khong co chuc nang");
                    Console.Clear();
                    goto menu;
                    break;
            }
            Console.ReadKey();
        }
    }
}
