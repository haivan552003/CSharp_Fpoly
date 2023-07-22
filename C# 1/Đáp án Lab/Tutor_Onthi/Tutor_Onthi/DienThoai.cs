using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_Onthi
{
    public class DienThoai
    {
        public string tenDienThoai;
        public double giaDienThoai;

        public DienThoai(string tenDienThoai, double giaDienThoai)
        {
            this.tenDienThoai = tenDienThoai;
            this.giaDienThoai = giaDienThoai;
        }

        public DienThoai()
        {
        }

        public string getTenDienThoai()
        {
            return this.tenDienThoai;
        }
        public void setTenDienThoai()
        {
            tenDienThoai = this.tenDienThoai;
        }

        public void getGiaDienThoai()
        {
            giaDienThoai = this.giaDienThoai;
        }
        public double setGiaDienThoai()
        {
            return this.giaDienThoai;
        }
        public int GiamGia()
        {
            if (this.giaDienThoai > 2000000) return 200000;
            else if (this.giaDienThoai > 1000000) return 150000;
            else return 100000;
        }

        public void ThanhTien()
        {
            Console.WriteLine("Thanh tien: " + (this.giaDienThoai - this.GiamGia()));
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
            string chuDau = this.tenDienThoai.Substring(0, 1);
            string conLai = this.tenDienThoai.Substring(1);

            //f pt can tho
            Console.WriteLine("Viet hoa chu cai dau ten dien thoai: " + (chuDau.ToUpper() + conLai));
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tien dien thoai: ");
            this.tenDienThoai = Console.ReadLine();
            Console.WriteLine("Nhap gia dien thoai: ");
            this.giaDienThoai = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten dien thoai: "+this.tenDienThoai);
            Console.WriteLine("Gia: " + this.giaDienThoai);
            Console.WriteLine("Giam gia: " + this.GiamGia());
            this.ThanhTien();
            this.ChuyenChuHoa();
            this.ChuyenChuThuong();
            this.InHoaChuCaiDauMoiTu();
        }
    }
}
