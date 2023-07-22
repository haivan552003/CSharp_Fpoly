using System.Runtime.Intrinsics.X86;
using Tutor_Onthi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Giay> list_giay = new List<Giay>();
        menu:
        Console.WriteLine("MENU");
        Console.WriteLine("1. Bai 1");
        Console.WriteLine("2. Bai 2");
        Console.WriteLine("Chon chuc nang");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                DienThoai dt = new DienThoai();
                dt.Nhap();
                dt.Xuat();
               
                break;
            case 2:
                bai2:
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap");
                Console.WriteLine("2. Xuat");
                Console.WriteLine("3. Tim kiem");
                Console.WriteLine("4. Cap nhat");
                Console.WriteLine("Chon chuc nang bai 2");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        chucnang1:
                        Console.WriteLine("Nhap so luong giay");
                        n = int.Parse(Console.ReadLine());

                        for(int i = 0; i < n; i++)
                        {
                            Giay g = new Giay();
                            g.Nhap();
                            list_giay.Add(g);
                        }
                        break;
                    case 2:
                        if(list_giay.Count == 0)
                        {
                            goto chucnang1;
                        }
                        foreach(Giay x in list_giay)
                        {
                            x.Xuat();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap tu khoa tim kiem: ");
                        string timKiem = Console.ReadLine();
                        foreach(Giay x in list_giay)
                        {
                            if(timKiem == x.tenGiay || timKiem == x.theLoai)
                            {
                                x.Xuat();
                            }
                        }
                        break;
                    case 4:
                        foreach(Giay x in list_giay)
                        {
                            x.CapNhatThongTinGiay();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Bam 1 de tiep tuc chuong trinh bai 2");
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    goto bai2;
                }
                break;
            default:
                break;
        }
        Console.WriteLine("Bam 1 de tiep tuc chuong trinh");
        n = int.Parse(Console.ReadLine());
        if(n == 1)
        {
            goto menu;
        }
    }
}