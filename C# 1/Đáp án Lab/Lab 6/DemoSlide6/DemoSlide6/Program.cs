using DemoSlide6;

internal class Program
{
    private static void Main(string[] args)
    {
        Tau t1 = new Tau();
        TauChien t2 = new TauChien();
        TauDuLich t3 = new TauDuLich();

        t1.LayThongTin();
        t2.LayThongTin();
        t3.LayThongTin();

        Console.WriteLine("==========================");
        TinhToan math = new TinhToan();
        math.TinhTong(1, 2);
        math.TinhTong(7.0, 7.5);
        math.TinhTong(7.0, 8.5);
        Console.WriteLine("a + b + c = " + math.TinhTong(2.5, 3, 2.5));
        Console.WriteLine("==========================");
    }
}