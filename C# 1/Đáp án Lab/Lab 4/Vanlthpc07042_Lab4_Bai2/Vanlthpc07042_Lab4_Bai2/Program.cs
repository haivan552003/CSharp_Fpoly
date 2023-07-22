public class SanPham{
    string tenSanPham1, tenSanPham2;
    int donGiaSP1, donGiaSP2;
    

    public void NhapSanPham1()
    {
        Console.Write("Nhap ten san pham: ");
        tenSanPham1 = Console.ReadLine();
        Console.Write("Nhap don gia: ");
        donGiaSP1 = Convert.ToInt32(Console.ReadLine());   
    }
    public void NhapSanPham2()
    {
        Console.Write("Nhap ten san pham: ");
        tenSanPham2 = Console.ReadLine();
        Console.Write("Nhap don gia: ");
        donGiaSP2 = Convert.ToInt32(Console.ReadLine());
    }
    public double getThueThuNhap() // ? 
    {
        return donGiaSP1 * 0.1; 
    }
    public void XuatSanPham1()
    {
        Console.WriteLine("Ten san pham: " + tenSanPham1);
        Console.WriteLine("Don gia: " + donGiaSP1);
    }
    public void XuatSanPham2()
    {
        Console.WriteLine("Ten san pham: " + tenSanPham2);
        Console.WriteLine("Don gia: " + donGiaSP2);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("THONG TIN SAN PHAM");
        SanPham sp = new SanPham();
        //nhap
        Console.WriteLine("Nhap thong tin san pham 1");
        sp.NhapSanPham1();
        Console.WriteLine("Nhap thong tin san pham 2");
        sp.NhapSanPham2();
        //xuat
        Console.WriteLine("____________________________");
        Console.WriteLine("Thong tin san pham 1");
        sp.XuatSanPham1();
        Console.WriteLine("Thong tin san pham 2");
        sp.XuatSanPham2();
    }
}