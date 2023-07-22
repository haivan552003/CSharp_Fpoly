using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class sinhvien
    {
        public string hoTen;
        private double diem;

        public void setDiem(double diem)
        {
            if(diem < 0 || diem > 10)
            {
                Console.WriteLine("Diem khong hop le");
                this.diem = -1;//diem khong hop le
            }
            else
            {
                this.diem = diem;
            }
        }
        public double getDiem() 
        { 
            return this.diem; 
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten vao: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap diem: ");
            this.diem = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Diem: " + this.diem);
        }
        public void XepLoai()
        {
            if (this.diem > 8)
            {
                Console.WriteLine("Hoc luc: Gioi");
            }
            else if (this.diem > 6.5)
            {
                Console.WriteLine("Hoc luc: Kha");
            }
            else if (this.diem > 5)
            {
                Console.WriteLine("Hoc luc: Trung binh");
            }
            else
            {
                Console.WriteLine("Hoc luc: Yeu");
            }
        }
        //khai bao ham tao
        public sinhvien()
        {
            this.hoTen = "";
            this.diem = 0;

        }
        public sinhvien(string hoTen, double diem)
        {
            this.hoTen = hoTen;
            this.diem = diem;
        }
    }
}
