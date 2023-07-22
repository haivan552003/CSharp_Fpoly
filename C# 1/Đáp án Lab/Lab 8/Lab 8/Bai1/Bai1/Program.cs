using Bai1;

internal class Program
{
    static void Main(string[] args)
    {
        Product prd = new Product();
        prd.Nhap();
        prd.Xuat();
        Console.WriteLine(prd.ToString());
        
    }
}