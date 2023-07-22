using Demo;

internal class Program
{
    private static void Main(string[] args)
    {

        /*
         demobai4 hinh_tron = new demobai4();
        hinh_tron.banKinh = 5;
        Console.WriteLine("Chu vi la: " + hinh_tron.getChuVi());
        Console.WriteLine("Dien tich la: " + hinh_tron.getDienTich());
        hinh_tron.Xuat();
        */

        /*
         sinhvien sv = new sinhvien();
        //sv.Nhap();
        Console.WriteLine("---------------------");
        Console.WriteLine("THONG TIN SINH VIEN");
        sv.setDiem(20);
        Console.WriteLine("Diem: " + sv.getDiem());
        sv.XepLoai();
         */

        int a = 99, b = 100;
        Console.WriteLine("a = " + a + " ,b = " + b);
        swap(ref a, b); //a la tham chie, b la tham tri
        Console.WriteLine("a = " + a + " ,b = " + b);
    }
    public static void swap(ref int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}