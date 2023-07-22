using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Slide5
{
    public class Nguoi
    {
        public string maSo;
        public string hoTen;
        public string gioiTinh;
        public Nguoi(string maSo, string hoTen, string gioiTinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
        }
        public Nguoi() { }
    }
    public class Nhanvien : Nguoi
    {
        public string bangCap;
        public Nhanvien(string bangCap, string maSo, string hoTen, string gioiTinh) : base(maSo, hoTen, gioiTinh)
        {
            this.bangCap = bangCap;
        }
        public Nhanvien() { }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            this.gioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap ma so: ");
            this.maSo = Console.ReadLine();
        }
    }
}
