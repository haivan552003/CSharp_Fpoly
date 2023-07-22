using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_De2
{
    public class DienThoai
    {
        public string tenDienThoai;
        public double giaDienThoai;

        public DienThoai()
        {
        }

        public DienThoai(string tenDienThoai, double giaDienThoai)
        {
            this.tenDienThoai = tenDienThoai;
            this.giaDienThoai = giaDienThoai;
        }

        public string getTenDienThoai()
        {
            return this.tenDienThoai;
        }
        public void setTenDienThoai()
        {
            tenDienThoai = this.tenDienThoai;
        }
        public double getGiaDienThoai()
        {
            return this.giaDienThoai;
        }
        public void setGiaDienThoai()
        {
            giaDienThoai = this.giaDienThoai;
        }
        public int GiamGia()
        {
            if (this.giaDienThoai > 200000) return 200000;
            else if (this.giaDienThoai > 1000000) return 150000;
            else return 100000;
        }
        public void ThanhTien()
        {
            Console.WriteLine("So tien phai tra la: "+ (this.giaDienThoai - this.GiamGia()));
        }
        public void ChuyenChuHoa()
        {
            Console.WriteLine("Ten dien thoai chu hoa: " + this.tenDienThoai.ToUpper());
        }

        public void ChuyenChuThuong()
        {
            Console.WriteLine("Ten dien thoai chu thuong: " + this.tenDienThoai.ToLower());
        }
        public void InHoaChuCaiDauMoiTu()
        {
            string chuCaiDau = this.tenDienThoai.Substring(0, 1); //chi lay tu dau
            string conLai = this.tenDienThoai.Substring(1); //bo tu dau
            Console.WriteLine("Ten dien thoai viet hoa chu dau: " + (chuCaiDau.ToUpper() + conLai));
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten dien thoai: ");
            this.tenDienThoai = Console.ReadLine();
            Console.WriteLine("Nhap gia dien thoai: ");
            this.giaDienThoai = double.Parse(Console.ReadLine());  
        }
        public void Xuat()
        {
            Console.WriteLine("Ten dien thoai: " + this.tenDienThoai);
            Console.WriteLine("Nhap gia dien thoai: " + this.giaDienThoai);
            Console.WriteLine("Giam gia: " + this.GiamGia());
            this.ThanhTien();
            this.ChuyenChuHoa();
            this.ChuyenChuThuong();
            this.InHoaChuCaiDauMoiTu();
        }
    }
}
