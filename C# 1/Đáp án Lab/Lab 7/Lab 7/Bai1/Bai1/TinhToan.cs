using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public delegate void Toan(int x, int y);
    public class TinhToan
    {
        public void tong(int x, int y)
        {
            Console.WriteLine("Tong: "+(x + y));
        }
        public void hieu(int x, int y)
        {
            Console.WriteLine("Hieu: "+(x - y));
        }
        public void Tich(int x, int y)
        {   
            Console.WriteLine("Tich: "+(x * y));
        }
        public void Thuong(int x, int y)
        {
            Console.WriteLine("Thuong: "+(x/y));
        }
    }
}
