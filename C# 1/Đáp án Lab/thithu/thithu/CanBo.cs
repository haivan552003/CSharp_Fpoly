using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThiThu
{
    public class CanBo
    {
        public string maCB;
        public string hoTen;
        public int namSinh;
        public string gioiTinh;

        public CanBo()
        {
        }

        public CanBo(string maCB, string hoTen, int namSinh, string gioiTinh)
        {
            this.maCB = maCB;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
        }
        public string getMaCB()
        {
            return this.maCB;
        }
        public string getHoTen()
        {
            return this.hoTen;
        }
        public int getNamSinh()
        {
            return this.namSinh;
        }
        public string getGioiTinh()
        {
            return this.gioiTinh;
        }
        public void setMaCB()
        {
            maCB = this.maCB;
        }
        public void setHoTen()
        {
            hoTen = this.hoTen;
        }
        public void setNamSinh()
        {
            namSinh = this.namSinh;
        }
        public void setGioiTinh()
        {
            gioiTinh = this.gioiTinh;
        }
        public int getTuoi()
        {
            return 2023 - this.namSinh;
        }
        public void Nhap()
        {
            ten:
            Console.WriteLine("Nhap ma can bo: ");
            this.maCB = Console.ReadLine();
            string pMaCB = "NV[0-9]{5}";
            if(!Regex.IsMatch(this.maCB.ToUpper(), pMaCB))
            {
                Console.WriteLine("Nhap sai");
                goto ten;
            }
            Console.WriteLine("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            this.namSinh = int.Parse(Console.ReadLine());
            gioiTinh:
            Console.WriteLine("Nhap gioi tinh: ");
            this.gioiTinh = Console.ReadLine();
            string pGioTinh = "nam|nu";
            if(!Regex.IsMatch(this.gioiTinh.ToLower(), pGioTinh))
            {
                Console.WriteLine("Nhap sai");
                goto gioiTinh;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Ma can bo: " + this.maCB);
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Nam sinh: " + this.namSinh);
            Console.WriteLine("Tuoi: " + this.getTuoi());
            Console.WriteLine("Gioi tinh: " + this.gioiTinh);
        }
    }
    public class KySu : CanBo
    {
        public string bangCap;

        public KySu()
        {
        }
        public KySu(string bangCap)
        {
            this.bangCap = bangCap;
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap bang cap: ");
            this.bangCap = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Bang cap: " + this.bangCap);
        }
    }
}
