internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;

        Console.Write("Nhap vao a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap vao b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("So nho nhat trong hai so a va b: " + Math.Min(a, b));
        Console.WriteLine("a luy b la: " + Math.Pow(a, b));

        Console.ReadKey();
    }
}