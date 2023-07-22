using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vanlthpc07042_Asigment_CSharp
{
    public class SinhVien
    {
        public string hoTen;
        public string pHoTen = "^([a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ]+)((\\s{1}[a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ]+){1,})$";
        public string MSSV;
        public double diem;
        public string email;
        public string pemail = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public string hocLuc;
        public double max, min;
        public double tong = 0;
        //nhâp thông tin sinh viên
        
        public virtual void Nhap()
        {
            NhapLaiHoTen:
            Console.WriteLine("Nhập họ tên sinh viên: ");
            this.hoTen = Console.ReadLine();

            if (Regex.IsMatch(this.hoTen.ToLower(), this.pHoTen))
            {
                Console.WriteLine("Họ tên hợp lệ");
            }
            else
            {
                Console.WriteLine("Họ tên không hợp lệ");
                goto NhapLaiHoTen;
                
            }
            do
            {
                try
                {
                    Console.WriteLine("Nhập điểm sinh viên: ");
                    this.diem = double.Parse(Console.ReadLine());
                }
                catch (Exception e) { }
            } while (this.diem < 0 || this.diem > 10);
            NhapLaiEmail:
            Console.WriteLine("Nhập email sinh viên: ");
            this.email = Console.ReadLine();
            if (Regex.IsMatch(this.email, this.pemail))
            {
                Console.WriteLine("Email hợp lệ");
            }
            else
            {
                Console.WriteLine("Email không hợp lệ");
                goto NhapLaiEmail;
            }
            
            Console.WriteLine("......................................................");
        }
        public string HoTenDaNhap()
        {
            return this.hoTen;
        }
        public double getDiem()
        {
            return this.diem;
        }
        public string getHocLuc()
        {
            double diem = this.getDiem();
            if (diem >= 9) return "Xuất Sắc";
            else if (diem >= 7.5) return "Giỏi";
            else if (diem >= 6.5) return "Khá";
            else if (diem >= 5) return "Trung Bình";
            else return "Yếu";
        }
        public int TongTheoHocLucXX()
        {
            int count_xs = 0, count_g = 0, count_k = 0, count_tb = 0, count_y = 0;
            if (this.getHocLuc().Equals("Xuất Sắc"))
                return count_xs++;
            if (this.getHocLuc().Equals("Giỏi"))
                return count_g++;
            else if (this.getHocLuc().Equals("Khá"))
                return count_k++;
            else if (this.getHocLuc().Equals("Trung Bình"))
                return count_tb++;
            else
                return count_y++; 
        }
        public void Xuat()
        {
            Console.WriteLine("Họ tên sinh viên: " + this.hoTen.ToUpper());
            Console.WriteLine("Điểm sinh viên: " + this.diem);
            Console.WriteLine("Email sinh viên: " + this.email);
            Console.WriteLine("Học lực: " + this.getHocLuc());
            Console.WriteLine("......................................................");
        }
        public void XuatY5()
        {
            Console.WriteLine("MSSV: " + this.MSSV.ToUpper());
        }
    }
    class SapXepTheoDiem : IComparer<SinhVien>
    {
        public int Compare(SinhVien? x, SinhVien? y)
        {
            double diem1 = x.diem;
            double diem2 = y.diem;
            int flag = 0;
            if (diem1 > diem2)
            {
                return flag = 1;
            }
            else if (diem1 < diem2)
            {
                return flag = -1;
            }
            else
            {
                return flag = 0;
            }
        }
    }

    class SapXepTheoDiemY7 : IComparer<SinhVien>
    {
        public int Compare(SinhVien? x, SinhVien? y)
        {
            double diem1 = x.diem;
            double diem2 = y.diem;
            int flag = 0;
            if (diem1 < diem2)
            {
                return flag = 1;
            }
            else if (diem1 > diem2)
            {
                return flag = -1;
            }
            else
            {
                return flag = 0;
            }
        }
    }
}
