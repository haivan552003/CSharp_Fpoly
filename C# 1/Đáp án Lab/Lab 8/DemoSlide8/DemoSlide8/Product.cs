using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide8
{
    internal class Product
    {
        public string ten;
        public double gia;
        public double giamgia;
        public Product() { }

        public Product(string ten, double gia, double giamgia)
        {
            this.ten = ten;
            this.gia = gia;
            this.giamgia = giamgia;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten sp: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap gia: ");
            this.gia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap giam gia: ");
            this.giamgia = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten: " + this.ten);
            Console.WriteLine("Gia: "+ this.gia);
            Console.WriteLine("Giam gia: " + this.giamgia);
        }
        public override string ToString()
        {
            return "Ten: " + this.ten 
                + "\nGia: " + this.gia 
                + "\nGiam gia: " + this.giamgia;
        }
    }
}

