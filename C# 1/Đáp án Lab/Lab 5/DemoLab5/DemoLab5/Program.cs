using Demo_Slide5;
using DemoLab5;
using System.Collections;

internal class Program
{
    public class NhanVien
    {
        public int luong = 2000000000;
    }
    public class KeToan : NhanVien
    {
        //ke toan ke thua nhan vien
        public int tienThuong = 200000;
    }
    public class LapTrinhVien : NhanVien
    {
        //ke thua nhan vien
        public int tienThuong = 500000;
    }
    public class QuanTriVien : NhanVien
    {
        //ke thua nhan vien
        public int tienThuong = 800000;
    }
    public class DongVat
    {
        public string mauSau;
        public string tiengKeu;
    }
    public class ConCho : DongVat //lop con
    {
        public void TiengKeu()
        {
            tiengKeu = "gau gau";
            Console.WriteLine("Con cho keu: " + tiengKeu);
        }
    }
    public class ChoCon : ConCho //lop chau
    {
        public void TiengKeuChoCon()
        {
            TiengKeu();
            tiengKeu = "e e";
            Console.WriteLine("Cho con keu: " + tiengKeu);
        }
    }
    public class Con : ChoCon //lop chat
    {
        public void ConKeu()
        {
            TiengKeuChoCon();
            Console.WriteLine("Tieng con keu: la la");
        }

    }
    private static void Main(string[] args)
    {
        Con cc = new Con();
        cc.ConKeu();
        Console.WriteLine("-----------------------------");
        KeToan kt = new KeToan();
        Console.WriteLine("Luong: " + kt.luong);
        Console.WriteLine("Thuong: " + kt.tienThuong);
        Console.WriteLine(".............................");
        LapTrinhVien ltv = new LapTrinhVien();
        Console.WriteLine("Luong: " + ltv.luong);
        Console.WriteLine("Thuong: " + ltv.tienThuong);
        Console.WriteLine(".............................");
        QuanTriVien qtv = new QuanTriVien();
        Console.WriteLine("Luong: " + qtv.luong);
        Console.WriteLine("Thuong: " + qtv.tienThuong);
        Console.WriteLine("-----------------------------");

        
        Nhanvien nv = new Nhanvien("Cao dang", "PC07042", "Van", "Nu");
        Console.WriteLine("Ma so: " + nv.maSo);
        Console.WriteLine("Ho ten: " + nv.hoTen);
        Console.WriteLine("Gioi tinh: " + nv.gioiTinh);
        Console.WriteLine("Bang cap: " + nv.bangCap);

        Console.WriteLine("-----------------------------");
        ArrayList dsnv = new ArrayList();
        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Nhanvien nvien = new Nhanvien();
            nvien.Nhap();
            dsnv.Add(nvien);
        }
        Console.WriteLine(".............................");
        foreach (Nhanvien x in dsnv)
        {
            Console.WriteLine("Ho ten: " + x.hoTen);
            Console.WriteLine("Gioi tinh: " + x.gioiTinh);
            Console.WriteLine("Bang cap: " + x.bangCap);
            Console.WriteLine(".............................");
        }


        Console.WriteLine("-----------------------------");//nap chong
        tinhtoan tt = new tinhtoan();
        int tong = tt.sum(3, 4);
        double tong2 = tt.sum(7.0, 8.5);
        Console.WriteLine(tong2);

        Console.WriteLine("-----------------------------");

        con c1 = new con();
        c1.show();
    }
}