using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class demobai4
    {
        public double banKinh;
        //ban kinh la thuoc tinh hinh tron
        public double getChuVi()
        {
            return 2 * Math.PI * this.banKinh;
        }
        public double getDienTich()
        {
            return Math.PI * Math.Pow(this.banKinh, 2);
        }
        public void Xuat()
        {
            Console.WriteLine("Ban kinh la: " + this.banKinh);
        }
    }
}
