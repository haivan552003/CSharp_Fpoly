using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab4_Bai1
{
    internal class SanPham
    {
        private string tenSP;
        private double donGia;
        private double giamGia;

        public void setTenSP(string tenSP)
        {
            this.tenSP = tenSP;
        }
        public void setDonGia(double donGia)
        {
            this.donGia = donGia;
        }
        public void setGiamGia(double giamGia)
        {
            this.giamGia = giamGia;
        }

        public string getTenSP()
        {
            return this.tenSP;
        }
        public double getDonGia()
        {
            return this.donGia;
        }
        public double getGiamGia()
        {
            return this.giamGia;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            this.tenSP = Console.ReadLine();
            Console.Write("Nhap don gia: ");
            this.donGia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap giam gia: ");
            this.giamGia = Convert.ToInt32(Console.ReadLine());
        }
        private double getThueNhapKhau()
        {
            return 0.1 * this.donGia;
        }
        public void Xuat()
        {
            Console.WriteLine("Ten san pham: " + this.tenSP.ToUpper());
            Console.WriteLine("Don gia: " + this.donGia);
            Console.WriteLine("Giam gia: " + this.giamGia);
            Console.WriteLine("Thue nhap khau: " + this.getThueNhapKhau());
        }
        public SanPham(string tenSP, double donGia, double giamGia) //ham tao
        {
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.giamGia = giamGia;
        }
        public SanPham(string tenSP, double donGia) //ham tao
        {
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.giamGia = 0;
        }
        public SanPham()
        {
            this.tenSP = "";
            this.donGia = 0;
            this.giamGia = 0;
        }
    }
}
