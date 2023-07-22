internal class Program
{
    static void swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        int x = 0, y = 5;
        swap(ref x, ref y);
        Console.WriteLine("x: {0} - y: {1}", x, y);
        double m = 7.5, n = 2.5;
        swap(ref m, ref n);
        Console.WriteLine("m: {0} - n: {1}", m, n);
    }
}