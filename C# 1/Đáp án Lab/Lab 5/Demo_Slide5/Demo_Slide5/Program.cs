using Demo_Slide5;

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

        ArrayList dsnv = new ArrayList();

        Nhanvien nv = new Nhanvien("Cao dang", "PC07042", "Van", "Nu");
        Console.WriteLine("Ma so: " + nv.maSo);
        Console.WriteLine("Ho ten: " + nv.hoTen);
        Console.WriteLine("Gioi tinh: " + nv.gioiTinh);
        Console.WriteLine("Bang cap: " + nv.bangCap);

        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++){
            NhanVien nv = new NhanVien();
            Add.nv();
        }
        dsnv.Add(nv1);
        dsnv.Add(nv2);
        foreach(NhanVien x in dsnv)
        {
            Console.WriteLine("Ho ten: " + x.hoTen);
            Console.WriteLine("Gioi tinh: " + x.gioiTinh);
            Console.WriteLine("Bang cap: " + x.bangCap);
        }
    }
}