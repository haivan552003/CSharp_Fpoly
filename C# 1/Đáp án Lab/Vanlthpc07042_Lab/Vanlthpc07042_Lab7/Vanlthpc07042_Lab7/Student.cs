using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab7
{
    internal class Student
    {
        public string mssv;
        public string hoten;
        public string gioitinh;
        public double tuoi;
        public string thanhpho;

        public Student(string hoten)
        {
            this.hoten = hoten;
        }


        public Student(string mssv, string hoten, string gioitinh, double tuoi, string thanhpho)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
            this.thanhpho = thanhpho;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ma: ");
        ma: this.mssv = Console.ReadLine();
            string pmssv = "^(PC|PO|PH)[0-9]{5}";
            if (!Regex.IsMatch(this.mssv.ToUpper(), pmssv))
            {
                Console.WriteLine("Vui long nhap lai MSSV"); goto ma;
            }
            Console.WriteLine("Ho ten: ");
        ten: this.hoten = Console.ReadLine();
            string pten = "^[a-zA-Z ]{6,40}$";
            if (!Regex.IsMatch(this.hoten, pten))
            {
                Console.WriteLine("Vui long nhap lai ho ten"); goto ten;
            }
            Console.WriteLine("Nhap tuoi: ");
        tuoi: this.tuoi = double.Parse(Console.ReadLine());
            if (this.tuoi < 18)
            {
                Console.WriteLine("Moi nhap lai tuoi: ");
                goto tuoi;
            }
            Console.WriteLine("Gioi tinh: ");
        gT: this.gioitinh = Console.ReadLine();
            string pgioitinh = "^(Nam|Nu)$";
            if (!Regex.IsMatch(this.gioitinh.ToUpper(), pgioitinh.ToUpper()))
            {
                Console.WriteLine("Moi nhap lai gioi tinh: ");
                goto gT;
            }
            Console.WriteLine("Thanh Pho: ");
        tp: this.thanhpho = Console.ReadLine();
            string ptpho = "^[a-zA-Z ]{6,40}$";
            if (!Regex.IsMatch(this.thanhpho, ptpho))
            {
                Console.WriteLine("Moi nhap lai thanh pho: ");
                goto tp;
            }
        }
    }
}
