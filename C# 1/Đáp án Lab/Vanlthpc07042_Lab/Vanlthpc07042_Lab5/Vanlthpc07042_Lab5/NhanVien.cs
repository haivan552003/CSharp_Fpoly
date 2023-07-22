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