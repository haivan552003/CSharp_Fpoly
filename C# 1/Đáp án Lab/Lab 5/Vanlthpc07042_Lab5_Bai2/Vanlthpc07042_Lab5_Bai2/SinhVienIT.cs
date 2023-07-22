using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanlthpc07042_Lab5_Bai1;

namespace Vanlthpc07042_Lab5_Bai2
{
    public class SinhVienIT : SinhVienPoly
    {
        public double diemCSharp;
        public double diemHTML;
        public double diemCSS;

        public SinhVienIT()
        {
        }
        public SinhVienIT(string hoTen, double diemCSharp, double diemHTML, double diemCSS)
        {
            this.hoTen = hoTen;
            this.diemCSharp = diemCSharp;   
            this.diemHTML = diemHTML;
            this.diemCSS = diemCSS;
            this.nghanh = "IT";
        }
        public override double getDiem()
        {
            return (2 * diemCSharp + diemCSS + diemHTML) / 4;
        } 
        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            this.hoTen = Console.ReadLine();
            this.nghanh = "IT";
            Console.WriteLine("Nhap diem C#: ");
            this.diemCSharp = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem HTML: ");
            this.diemHTML = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem CSS: ");
            this.diemCSS = double.Parse(Console.ReadLine()); 
        }
    }
}
