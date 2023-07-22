internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tinh tien luong");
        int BacLuong, NgayCong, PhuCap, TienLanh, NCTL = 0;

        Console.Write("Nhap bac luong: ");
        BacLuong = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ngay cong: ");
        NgayCong = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap phu cap: ");
        PhuCap = Convert.ToInt32(Console.ReadLine());

        if(NgayCong >= 0 && NgayCong < 25){
            NCTL = NgayCong;
        }
        else if(NgayCong >= 25)
        {
            NCTL = (NgayCong - 25) * 2 + 25;
        }
        TienLanh = BacLuong * 650000 * NCTL + PhuCap;

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Tien luong duoc lanh la: " + TienLanh);

        Console.ReadKey();
    }
}