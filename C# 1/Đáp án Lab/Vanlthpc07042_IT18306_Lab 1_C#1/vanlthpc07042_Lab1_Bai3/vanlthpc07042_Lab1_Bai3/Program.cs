using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab1_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chuong trinh tinh va xuat the tich cua khoi lap phuong\n\n");
            float Canh;
            float TheTich;
            Console.Write("Nhap canh: ");
            Canh = Convert.ToInt32(Console.ReadLine());

            TheTich = (float)Math.Pow(Canh, 3); //ep kieu tuong minh, do pow nhan kieu du lieu double
            Console.WriteLine("The tich khoi lap phuong la: " + TheTich);
            Console.ReadLine();
        }
    }
}
