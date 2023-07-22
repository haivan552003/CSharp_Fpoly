using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab2_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh xac dinh so nguyen to");
            int i, n;
            bool ok = true;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 2; i < n - 1; i++)
            {
                if(n % i == 0)
                {
                    ok = false;
                    break;
                }
            }
            if(ok == true)
            {
                Console.WriteLine(n + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(n + " khong phai la so nguyen to");
            }

            Console.ReadKey();
        }
    }
}
