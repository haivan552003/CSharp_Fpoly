using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanlthpc07042_Lab5_Bai1;

namespace Vanlthpc07042_Lab5_Bai2
{
    public class SinhVienBiz : SinhVienPoly
    {
        public double diemMarketing;
        public double diemSale;

        public SinhVienBiz()
        {
        }

        public SinhVienBiz(string hoTen, double diemMarketing, double diemSale)
        {
            this.hoTen = hoTen;
            this.diemSale = diemSale;
            this.diemMarketing = diemMarketing;
            this.nghanh = "Kinh doanh";
        }
        public override double getDiem()
        {
            return (2 * this.diemMarketing + this.diemSale) / 3;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            this.hoTen = Console.ReadLine();
            this.nghanh = "Biz";
            Console.WriteLine("Nhap diem Marketing: ");
            this.diemMarketing = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Sale: ");
            this.diemSale = double.Parse(Console.ReadLine());
        }
    }
}
