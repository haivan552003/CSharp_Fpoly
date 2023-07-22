using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab7_Bai3
{
    internal class Student
    {
        public String MSSV;
        public String hoTen;
        public String gioiTinh;
        public int tuoi;
        public String thanhPho;

        public Student(string mSSV, string hoTen, string gioiTinh, int tuoi, string thanhPho)
        {
            this.MSSV = MSSV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
            this.thanhPho = thanhPho;
        }
        public Student() 
        {
            this.hoTen = hoTen;
        }
        public Student(string ten)
        { this.MSSV = ten;
        }
        public void Nhap()
        {
            ma:
            Console.WriteLine("Nhap MSSV: ");
            this.MSSV = Console.ReadLine();
            string pmssv = "(PC|PH)[0-9]{1,5}";
            if (!Regex.IsMatch(this.MSSV.ToUpper(), pmssv))
            {
                Console.WriteLine("Nhap sai, nhap lai");
                goto ma;
            }
            ten:
            Console.WriteLine("Nhap ten: ");
            this.hoTen = Console.ReadLine();
            string pten = "^[a-zA-Z ]{6,40}$";
            if(!Regex.IsMatch(this.hoTen, pten))
            {
                Console.WriteLine("Nhap sai, nhap lai");
                goto ten;
            }
            tuoi:
            Console.WriteLine("Nhap tuoi: ");
            this.tuoi = int.Parse(Console.ReadLine());
            if(tuoi < 18)
            {
                Console.WriteLine("Nhap sai, nhap lai");
                goto tuoi;
            }
            gt:
            Console.WriteLine("Nhap gioi tinh: ");
            this.gioiTinh = Console.ReadLine();
            string pgioitinh = "nam|nu";
            if (!Regex.IsMatch(this.gioiTinh.ToLower(), pgioitinh))
            {
                Console.WriteLine("Nhap sai, nhap lai");
                goto gt;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("MSSV: " + this.MSSV);
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Tuoi: " + this.tuoi);
            Console.WriteLine("Gioi tinh: " + this.gioiTinh);
        }
    }
}
