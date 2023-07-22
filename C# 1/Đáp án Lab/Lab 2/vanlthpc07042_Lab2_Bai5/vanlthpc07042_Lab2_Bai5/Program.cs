using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab2_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh bang cuu chuong");
            int i, bangCuuChuong, ketQua;
            do
            {
                Console.Write("Nhap bang cuu chuong: ");
                bangCuuChuong = Convert.ToInt32(Console.ReadLine());
            } while (bangCuuChuong < 2 || bangCuuChuong > 9);
            
            Console.WriteLine("Bang cuu chuong " + bangCuuChuong);
            for(i = 1; i <= 10; i++)
            {
                ketQua = bangCuuChuong * i;
                Console.WriteLine("{0} x {1} = {2}", bangCuuChuong, i, ketQua);
            }

            Console.ReadKey();
        }
    }
}
