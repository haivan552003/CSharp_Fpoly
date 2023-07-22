using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vanlthpc07042_Lab5_Bai1.Bai1;

namespace Vanlthpc07042_Lab5_Bai1
{
    public class Bai1 //class ChuNhat trong đề
    {
        public double rong;
        public double dai;

        public Bai1()
        {
        }
        public Bai1(double dai, double rong)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double getChuVi()
        {
            return (this.dai + this.rong) * 2;
        }
        public double getDienTich()
        {
            return this.dai * this.rong;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Chieu dai: " + this.dai);
            Console.WriteLine("Chieu rong: " + this.rong);
            Console.WriteLine("Chu vi: " + getChuVi());
            Console.WriteLine("Dien tich: " + getDienTich());
        }
    }
    public class Vuong : Bai1
    {
        public Vuong(double canh):base(canh, canh)
        {
            this.rong = canh;
            this.dai = canh;
        }

        public Vuong()
        {
        }

        public override void Xuat()
        {
            Console.WriteLine("Canh: " + this.dai);
            Console.WriteLine("Chu vi: " + getChuVi());
            Console.WriteLine("Dien tich: " + getDienTich());
        }
        
    }
}
