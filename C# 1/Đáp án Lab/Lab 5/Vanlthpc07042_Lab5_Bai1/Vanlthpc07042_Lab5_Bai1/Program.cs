using Vanlthpc07042_Lab5_Bai1;

internal class Program
{
    private static void Main(string[] args)
    {
        Repeat:
        Console.WriteLine("Menu");
        Console.WriteLine("1. Bai 1");
        Console.WriteLine("2. Bai 2");
        Console.WriteLine("3. Bai 3");
        Console.WriteLine("4. Bai 4");
        Console.WriteLine("Chon bai: ");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Bai1 cn = new Bai1();
                Bai1 vu = new Vuong();
               
                Console.WriteLine("Hinh chu nhat");
                Console.WriteLine("Nhap chieu dai: ");
                cn.dai = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong: ");
                cn.rong = double.Parse(Console.ReadLine());
                cn.Xuat();

                Console.WriteLine("------------------------");
                Console.WriteLine("Hinh vuong");
                do
                {
                    Console.WriteLine("Nhap canh: ");
                    vu.dai = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap lai canh: ");
                    vu.rong = double.Parse(Console.ReadLine());
                }while(vu.dai != vu.rong);
                vu.Xuat();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Tiep tuc chuong trinh bam '1'");
                n = int.Parse(Console.ReadLine());
                if(n == 1)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------");
                    goto Repeat;
                }           
                break;
        }
        
    }
}