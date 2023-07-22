using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace De01CSharp
{
    public class HocVien
    {
        public string ma;
        public string hoTen;
        public string soDienThoai;
        public string nghanhHoc;

        public HocVien()
        {
        }

        public HocVien(string ma, string hoTen, string soDienThoai, string nghanhHoc)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.nghanhHoc = nghanhHoc;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            sdt:
            Console.WriteLine("Nhap so dien thoai: ");
            this.soDienThoai = Console.ReadLine();
            string pma = "0[9|8|1|7|3|5]([0-9]|\\s|-|\\.){8,12}";
            if (!Regex.IsMatch(this.soDienThoai, pma))
            {
                Console.WriteLine("Nhap lai sdt");
                goto sdt;
            }
            Console.WriteLine("Nhap nghanh hoc: ");
            this.nghanhHoc = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.WriteLine("Ma: " + this.ma);
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("So dien thoai: " + this.soDienThoai);
            Console.WriteLine("Nghanh hoc: " + this.nghanhHoc);
        }
    }
    public class HocVienDoHoa : HocVien
    {
        public double diemPTS;
        public double diemAi;
        public double diemCorel;

        public HocVienDoHoa()
        {
        }

        public HocVienDoHoa(string ma, string hoTen, string soDienThoai, string nghanhHoc, double diemPTS, double diemAi, double diemCorel)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.nghanhHoc = nghanhHoc;
            this.diemPTS = diemPTS;
            this.diemAi = diemAi;
            this.diemCorel = diemCorel;
        }
        public double getDTB()
        {
            return (this.diemPTS * 2 + this.diemAi + this.diemCorel) / 4;
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap diem PTS: ");
            this.diemPTS = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Ai: ");
            this.diemAi = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Corel: ");
            this.diemCorel = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem PTS: " + this.diemPTS);
            Console.WriteLine("Diem Ai: " + this.diemAi);
            Console.WriteLine("Diem Corel: " + this.diemCorel);
            Console.WriteLine("Diem trung binh: " + this.getDTB());
        }
    }
    public class HocVienTinHoc : HocVien
    {
        public double diemWord;
        public double diemExcel;
        public double diemPP;

        public HocVienTinHoc()
        {
        }

        public HocVienTinHoc(string ma, string hoTen, string soDienThoai, string nghanhHoc, double diemPTS, double diemAi, double diemCorel)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.nghanhHoc = nghanhHoc;
            this.diemWord = diemPTS;
            this.diemExcel = diemAi;
            this.diemPP = diemCorel;
        }
        public double getDTB()
        {
            return this.diemWord + this.diemExcel + this.diemPP;
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap diem Word: ");
            this.diemWord = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Excel: ");
            this.diemExcel = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem PPT: ");
            this.diemPP = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem Word: " + this.diemWord);
            Console.WriteLine("Diem Excel " + this.diemExcel);
            Console.WriteLine("Diem PPT: " + this.diemPP);
            Console.WriteLine("Diem trung binh: " + this.getDTB());
        }
    }
}
