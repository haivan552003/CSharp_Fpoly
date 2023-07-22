internal class Program
{
    private static void Main(string[] args)
    {
        ChonChuongTrinh: //goto ChonChuongTrinh quay ve day
        Console.WriteLine("Phan biet so nguyen");
        int n;
        Console.Write("Nhap so nguyen: ");
        n = Convert.ToInt32(Console.ReadLine());

        //xet dieu kien n == 0
        if(n == 0) {
            Console.WriteLine(n + " khong phai so chan hay le, nguyen duong hay nguyen am");
        }
        else
        {
            //xet dieu kien nguyen duong, nguyen am
            if (n > 0)
            {
                Console.WriteLine(n + " la so nguyen duong");
            }
            else
            {
                Console.WriteLine(n + " la so nguyen am");
            }
            //xet dieu kien chan le
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " la so chan");
            }
            else
            {
                Console.WriteLine(n + " la so le");
            }
        }
        Console.WriteLine("-------------------------------------------");
        int flag;
        Console.WriteLine("Bam phim 1 de tiep tuc chuong trinh");
        flag = Convert.ToInt32(Console.ReadLine());
        if(flag == 1)
        {
            goto ChonChuongTrinh;
        }
        Console.ReadKey();
    }
}