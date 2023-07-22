using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thithu
{
    public class Xemay
    {
        public string tenXe;
        public int giaXe;
        public Xemay()
        {
        }

        public Xemay(string tenXe, int giaXe)
        {
            this.tenXe = tenXe;
            this.giaXe = giaXe;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten xe: ");
            this.tenXe = Console.ReadLine();
            Console.WriteLine("Nhap gia xe: ");
            this.giaXe = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten xe: " +this.tenXe);
            Console.WriteLine("Gia xe: "+ this.giaXe);
        }
        public void setGiaXe()
        {
            giaXe = this.giaXe;
        }
        public int getGiaXe()
        {
            return giaXe;
        }
        public void setTenXe()
        {
            tenXe = this.tenXe;
        }
        public string getTenXe()
        {
            return tenXe;
        }
        public int GiamGia()
        {
            if (this.giaXe < 1000000) return 100000;
            else if (this.giaXe <= 2000000) return 150000;
            else return 200000;
        }
        public void ThanhTien()
        {
            int thanhTien = this.giaXe - this.GiamGia();
        }
        public void ChuyenChuHoa()
        {
            this.tenXe = tenXe.ToUpper();
        }
        public void ChuyenChuThuong()
        {
            this.tenXe = tenXe.ToLower();
        }
        public void catChuDauTien() //indexof tra ve vi tri dau
        {
            //string chuDau = this.tenXe.IndexOf(" "); tenXe.Substring(0, );
            //if (chuDau == -1)
            //{

            //}
            string name[] = this.tenXe.Split(" ");
            //name[0]
            //name[lenght - 1]
        }
        public void catChuCuoiCung()
        {
            string chuCuoi = tenXe.Substring(this.tenXe.Length - 1, this.tenXe.IndexOf(" "));
        }
    }
}
