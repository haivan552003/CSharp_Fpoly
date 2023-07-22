internal class Program
{
    private static void Main(string[] args)
    {
        Random rd= new Random();
        int so = rd.Next(5, 12);
        Console.WriteLine(so);
    }
}