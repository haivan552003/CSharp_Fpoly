using System.ComponentModel.Design;
using Test_De2;

internal class Program
{
    private static void Main(string[] args)
    {
    menu:
        Console.WriteLine("MENU");
        Console.WriteLine("1. Bai 1");
        Console.WriteLine("2. Bai 2");
        Console.WriteLine("Chon chuc nang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                DienThoai dt = new DienThoai();
                dt.Nhap();
                dt.Xuat();
                break;
            case 2:
                List<Giay> giays = new List<Giay>();
                bai2:
                Console.WriteLine("MENU BAI 2");
                Console.WriteLine("1. Nhap");
                Console.WriteLine("2.Xuat");
                Console.WriteLine("3. Tim kiem");
                Console.WriteLine("4. Cap nhap");
                Console.WriteLine("Chon chuc nang");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        chucnang1bai2:
                        Console.WriteLine("Nhap so luong giay");
                        n = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < n; i++)
                        {
                            Giay g = new Giay();
                            g.Nhap();
                            giays.Add(g);
                        }
                        break;
                    case 2:
                        if(giays.Count == 0)
                        {
                            goto chucnang1bai2;
                        }
                        foreach(Giay x in giays)
                        {
                            x.Xuat();
                        }
                        break;
                    case 3:
                        if (giays.Count == 0)
                        {
                            goto chucnang1bai2;
                        }
                        Console.WriteLine("Nhap ten hoa the loai giay can tim: ");
                        string timKiem = Console.ReadLine();
                        foreach (Giay x in giays)
                        {
                            if (timKiem.ToLower() == x.TimKiemTheoTenHoacTheLoai().ToLower())
                                x.Xuat();
                        }
                        break;
                    case 4:
                        if (giays.Count == 0)
                        {
                            goto chucnang1bai2;
                        }
                        foreach (Giay x in giays)
                        {
                            x.CapNhatThongTinGiay();
                        }
                        foreach(Giay x in giays)
                        {
                            x.Xuat();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Bam 1 de tiep tuc chuong trinh bai 2");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Tiep tuc chuong trinh");
                    goto bai2;
                }
                break;
            default:
                break;

                
        }
        Console.WriteLine("Bam 1 de tiep tuc chuong trinh");
        n = Convert.ToInt32(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("Tiep tuc chuong trinh");
            goto menu;
        }
    }
}