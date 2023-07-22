using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_De2
{
    public class Giay
    {
        public string tenGiay;
        public string theLoai;
        public double giaTien;

        public void Nhap()
        {
            ten:
            Console.WriteLine("Nhap ten giay: ");
            this.tenGiay = Console.ReadLine();
            string pTenGiay = "[a-zA-Z]|[0-9]";
            if(!Regex.IsMatch(this.tenGiay, pTenGiay))
            {
                Console.WriteLine("Nhap sai");
                goto ten;
            }
            Console.WriteLine("Nhap the loai giay: ");
            this.theLoai = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Nhap gia: ");
                    this.giaTien = int.Parse(Console.ReadLine());
                }catch (Exception e) { }
               
            } while (this.giaTien < 0);
            
        }
        public void Xuat()
        {
            Console.WriteLine("Ten giay: " + this.tenGiay);
            Console.WriteLine("The loai: " + this.theLoai);
            Console.WriteLine("Gia: " + this.giaTien);
        }
        public string TimKiemTheoTenHoacTheLoai()
        {
            return this.tenGiay;
            
        }
        public void CapNhatThongTinGiay()
        {
            Console.WriteLine("Cap nhat ten: ");
            this.tenGiay = Console.ReadLine();
            Console.WriteLine("Cap nhat the loai: ");
            this.theLoai = Console.ReadLine();
            Console.WriteLine("Cap nhat gia: ");
            this.giaTien = double.Parse(Console.ReadLine());
        }
    }
}
