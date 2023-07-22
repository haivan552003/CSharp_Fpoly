using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp_Asignment
{
    class baitap
    {
        QLXHonDaDataContext qlxHD = new QLXHonDaDataContext();
        //nhap danh sach xe
        public static void y1()
        {
            String MaXe;
            String MaLoaiXe;
            String TenXe;
            float Gia;
            String MauXe;
            int DongCo;
            float KhoiLuong;

            Console.Write("Nhap MaXe: ");
            MaXe = Console.ReadLine();
            Console.Write("Nhap MaLoaiXe: ");
            MaLoaiXe = Console.ReadLine();
            Console.Write("Nhap TenXe: ");
            TenXe = Console.ReadLine();
            Console.Write("Nhap Gia: ");
            Gia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap MauXe: ");
            MauXe = Console.ReadLine();
            Console.Write("Nhap DongCo: ");
            DongCo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap KhoiLuong: ");
            KhoiLuong = Convert.ToInt32(Console.ReadLine());

            var NhapXe = new THONGTINXE()
            {
                MaXe = MaXe,
                MaLoaiXe = MaLoaiXe,
                TenXe = TenXe,
                Gia = Gia,
                MauXe = MauXe,
                DongCo = DongCo,
                KhoiLuong = KhoiLuong,
            };
        }
    }
}
