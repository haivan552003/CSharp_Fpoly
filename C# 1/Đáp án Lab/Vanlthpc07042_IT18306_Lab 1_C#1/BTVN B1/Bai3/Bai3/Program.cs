internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Chu vi, dien tich hinh vuong");
        int canh, chuVi;
        double dienTich;
        Console.Write("Nhap canh hinh vuong: ");
        canh = Convert.ToInt32(Console.ReadLine());

        chuVi = canh * 4;
        dienTich = Math.Pow(canh, 2);

        Console.WriteLine("Chu vi hinh vuong la " + chuVi + "\nDien tich hinh vuong la " + dienTich);
        Console.ReadKey();
    }
}