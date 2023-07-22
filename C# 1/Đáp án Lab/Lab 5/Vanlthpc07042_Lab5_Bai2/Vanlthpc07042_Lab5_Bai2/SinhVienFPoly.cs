using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab5_Bai1
{
    abstract public class SinhVienPoly
    {
        public string hoTen;
        public string nghanh;

        protected SinhVienPoly()
        {
        }
        protected SinhVienPoly(string hoTen, string nghanh)
        {
            this.hoTen = hoTen;
            this.nghanh = nghanh;
        }

        abstract public double getDiem();
        public string getHocLuc()
        {
            double diem = this.getDiem();
            if (diem >= 9) return "Xuat sac";
            else if (diem >= 7.5) return "Gioi";
            else if (diem >= 6.5) return "Kha";
            else if (diem >= 5) return "Trung binh";
            else return "Yeu";
              
        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + this.hoTen.ToUpper());
            Console.WriteLine("Nghanh: " + this.nghanh);
            Console.WriteLine("Diem: " + this.getDiem());
            Console.WriteLine("Hoc luc: " + this.getHocLuc());
        }   
    }
}
