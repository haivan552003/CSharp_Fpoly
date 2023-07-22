using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab5_Bai1
{
    abstract public class SinhVienPoly
    {
        public string hoTen;
        public string nghanh;

        abstract public double getDiem(double diem);
        /*
          public string getHocLuc(string hocLuc)
         {
        Console.WriteLine("Hoc luc: " + this.getHocLuc)
         }
         */
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Nghanh: " + this.nghanh);
            Console.WriteLine("Diem: " + this.getDiem);
            ;
        }
    }
    
}
