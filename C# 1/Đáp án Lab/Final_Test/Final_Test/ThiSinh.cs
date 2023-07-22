using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Test
{
    public class ThiSinh
    {
        public string MTS;
        public int SDT;
        public string email;

        public ThiSinh()
        {
        }

        public ThiSinh(string mTS, int sDT, string email)
        {
            this.MTS = MTS;
            this.SDT = SDT;
            this.email = email;
        }
        public void setMTS()
        {
            MTS = this.MTS;
        }
        public void setSDT()
        {
            SDT = this.SDT;
        }
        public void setemail()
        {
            email = this.email;
        }
        public string getMTS()
        {
            return this.MTS;
        }
        public int getSDT()
        {
            return this.SDT;
        }
        public string getemail()
        {
            return this.email;
        }
    }
    public class ThiSinhCNTT : ThiSinh
    {
        public double toan, ly, hoa;

        public ThiSinhCNTT()
        {
        }

        public ThiSinhCNTT(double toan, double ly, double hoa)
        {
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void settoan()
        {
            toan = this.toan;
        }
        public void setly()
        {
            ly = this.ly;
        }
        public void sethoa()
        {
            hoa = this.hoa;
        }
        public double gettoan()
        {
            return this.toan;
        }
        public double getly()
        {
            return this.ly;
        }
        public double gethoa()
        {
            return this.hoa;
        }
    }
    public class ThiSinhDLNHKS : ThiSinh
    {
        public double van, su, dia;

        public ThiSinhDLNHKS()
        {
        }
        public ThiSinhDLNHKS(double van, double su, double dia)
        {
            this.van = van;
            this.su = su;
            this.dia = dia;
        }
        public void setvan()
        {
            van = this.van;
        }
        public void setsu()
        {
            su = this.su;
        }
        public void setdia()
        {
            dia = this.dia;
        }
    }

    internal interface IQuanLyThiSinh
    {
        public string MTS { get; set; }
        public string email { get; set; }

        public int SDT { get; set; }
        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }
        public double van { get; set; }
        public double su { get; set; }
        public double dia { get; set; }
    }
    public class QuanLyThiSinh : IQuanLyThiSinh
    {
        private string mts;
        private int sdt;
        private string Email;
        private double toann, lyy, hoaa, vann, suu, diaa;
        public string MTS { get => this.mts; set => this.mts = value; }
        public string email { get => this.Email; set => this.Email = value; }
        public int SDT { get => this.sdt; set => this.sdt = value; }
        public double toan { get => this.toann; set => this.toann = value; }
        public double ly { get => this.lyy; set => this.lyy = value; }
        public double hoa { get => this.hoaa; set => this.hoaa = value; }
        public double van { get => this.vann; set => this.vann = value; }
        public double su { get => this.suu; set => this.suu = value; }
        public double dia { get => this.diaa; set => this.diaa = value; }

        public void NhapCNTT()
        {
        MTS:
            Console.WriteLine("Nhap MTS IT: ");
            this.MTS = Console.ReadLine();
            string pMTS = "IT[0-9]{5}";
            if (!Regex.IsMatch(this.MTS.ToUpper(), pMTS))
            {
                Console.WriteLine("MSSV không hợp lệ");
                goto MTS;
            }
            Console.WriteLine("Nhap SDT: ");
            this.SDT = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap email: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Nhap diem toan: ");
            this.toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            this.ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            this.hoa = double.Parse(Console.ReadLine());
        }
        public void NhapDLNHKS()
        {
        MTS:
            Console.WriteLine("Nhap MTS DLNHKS: ");
            this.MTS = Console.ReadLine();
            string pMTS = "DL[0-9]{5}";
            if (!Regex.IsMatch(this.MTS.ToUpper(), pMTS))
            {
                Console.WriteLine("MSSV không hợp lệ");
                goto MTS;
            }
            Console.WriteLine("Nhap SDT: ");
            this.SDT = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap email: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Nhap diem van: ");
            this.van = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem su ");
            this.su = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem dia ");
            this.dia = double.Parse(Console.ReadLine());
        }
        public double TBCNTT()
        {
            return (this.toan + this.ly + this.hoa) / 3;
        }
        public double TBDLNHKS()
        {
            return (this.van + this.su + this.dia) / 3;
        }
        public void TrungTuyenCNTT()
        {
            double cntt = this.TBCNTT();
            if (cntt >= 5)
            {
                Console.WriteLine("Chuc mung trung tuyen");
            }
            else
            {
                Console.WriteLine("Rot");
            }
        }
        public void TrungTuyenDLNHKS()
        {
            double dlnhks = this.TBDLNHKS();
            if (dlnhks >= 5)
            {
                Console.WriteLine("Chuc mung trung tuyen");
            }
            else
            {
                Console.WriteLine("Rot");
            }
        }
        public void XuatCNTT()
        {
            Console.WriteLine("MTS: " + this.MTS);
            Console.WriteLine("SDT: " + this.SDT);
            Console.WriteLine("Email: "+this.email);
            Console.WriteLine("Diem toan: " + this.toan);
            Console.WriteLine("Diem ly: " + this.ly);
            Console.WriteLine("Diem hoa: " + this.hoa);
            Console.WriteLine("Diem TB: " + this.TBCNTT());
            this.TrungTuyenCNTT();
        }
        public void XuatDLNHKS()
        {
            Console.WriteLine("MTS: " + this.MTS);
            Console.WriteLine("SDT: " + this.SDT);
            Console.WriteLine("Email: " + this.email);
            Console.WriteLine("Diem van: " + this.van);
            Console.WriteLine("Diem su: " + this.su);
            Console.WriteLine("Diem dia: " + this.dia);
            Console.WriteLine("Diem TB: " + this.TBDLNHKS());
            this.TrungTuyenDLNHKS();
        }
        public void NhapCNTT(string MTS, string email, int SDT, double toan, double ly, double hoa)
        {
            throw new NotImplementedException();
        }

        public void NhapDLNHKS(string MTS, string email, int SDT, double van, double su, double dia)
        {
            throw new NotImplementedException();
        }
    }
}
