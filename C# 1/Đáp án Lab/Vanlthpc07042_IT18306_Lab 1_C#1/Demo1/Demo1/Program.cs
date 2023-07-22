internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Nhap a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = Convert.ToInt32(Console.ReadLine());

        c = a + b;
        Console.WriteLine("c = " + c);
        Console.ReadKey();
    }
}