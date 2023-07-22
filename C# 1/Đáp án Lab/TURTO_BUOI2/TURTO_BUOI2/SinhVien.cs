using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TURTO_BUOI2
{
    internal class SinhVien
    {
        public string hoTen;
        public string HoTen = "/[^a-z0-9A-Z_[:space:]ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂ ưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]/u";
        public string pemail = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public string MSSV;
        public double diem;
        public string email;

        public void Nhap()
        {
            //Console.WriteLine("Nhap MSSV: ");
            //this.MSSV = Console.ReadLine();
            nhaplaihoten:
            Console.WriteLine("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Nhap diem sinh vien: ");
                    this.diem = double.Parse(Console.ReadLine());
                }
                catch (Exception ex) { }
            } while (this.diem < 0 || this.diem > 10);
            Console.WriteLine("Nhap email: ");
            this.email = Console.ReadLine();
        }
        public void Xuat() 
        {
            Console.WriteLine("MSSV: " + this.MSSV);
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Diem: " + this.diem);
            Console.WriteLine("Email: " + this.email);

        }
        //Y3
        public double getDiem()
        {
            return this.diem;
        }
        public string getMSSV()
        {
            return this.MSSV;
        }
        public string getHocLuc()
        {
            double diem = this.getDiem();
            if (diem >= 9) return "Xuat sac";
            else if (diem >= 7.5) return "Gioi";
            else if (diem >= 6.5) return "Kha";
            else if (diem >= 5) return "Trung binh";
            else  return "Yeu";
        }
    }
}
