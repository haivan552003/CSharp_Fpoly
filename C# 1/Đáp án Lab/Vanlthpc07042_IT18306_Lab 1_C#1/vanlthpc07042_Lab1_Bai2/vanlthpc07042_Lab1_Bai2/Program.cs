using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab1_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chuong trinh tinh chu vi, dien tich, canh nho nhat hinh chu nhat\n\n");
            int ChieuDai, ChieuRong, ChuVi, DienTich;

            Console.Write("Nhap chieu dai: ");
            ChieuDai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            ChieuRong = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chieu dai vua nhap la: " + ChieuDai);
            Console.WriteLine("Chieu rong vua nhap la: " + ChieuRong);

            ChuVi = (ChieuDai + ChieuRong) * 2;
            Console.WriteLine("Chu vi hinh chu nhat la: " + ChuVi);

            DienTich = ChieuDai * ChieuRong;
            Console.WriteLine("Dien tich hinh chu nhat la: " + DienTich);

            int Canh_Min = Math.Min(ChieuRong, ChieuDai);
            Console.WriteLine("Canh nho nhat la: " + Canh_Min);
            Console.ReadKey();
        }
    }
}
