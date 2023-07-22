using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab4_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SanPham sp1 = new SanPham();
            //SanPham sp2 = new SanPham();
            //Console.WriteLine("Nhap thong tin san phẩm 1");
            //sp1.Nhap();
            //Console.WriteLine("Nhap thong tin san pham 2");
            //sp2.Nhap();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("THONG TIN SAN PHAM 1");
            //sp1.Xuat();
            //Console.WriteLine("............................");
            //Console.WriteLine("THONG TIN SAN PHAM 2");
            //sp2.Xuat();
            //Console.ReadLine();
            SanPham sp3 = new SanPham("IP14", 41000, 1000);
            SanPham sp4 = new SanPham("Laptop", 7000);
            Console.WriteLine("Hai san pham vua tao la");
            sp3.Xuat();
            Console.WriteLine("...............................");
            sp4.Xuat();
            Console.WriteLine("...............................");
            SanPham sp5 = new SanPham();

            sp5.setTenSP("Xe AB");
            sp5.setDonGia(5000);
            sp5.setGiamGia(1);
            Console.WriteLine("Ten: " + sp5.getTenSP());
            Console.WriteLine("Don gia: " + sp5.getDonGia());
            Console.WriteLine("Giam gia: " + sp5.getGiamGia());

            Console.ReadLine();
        }
    }
}
