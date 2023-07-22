internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Giai phuong trinh bac 2");
        float a, b, c;
        float delta;

        Console.Write("Nhap a: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = float.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        c = float.Parse(Console.ReadLine());

        delta = b * b - 4 * a * c;
        Console.WriteLine("Delta: " + delta);
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep: " + (-b / 2 * a));
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem: x1 = {0}\n\t\tx2= {1}" + x1, x2);
            }
        }
        Console.ReadKey();
    }
}