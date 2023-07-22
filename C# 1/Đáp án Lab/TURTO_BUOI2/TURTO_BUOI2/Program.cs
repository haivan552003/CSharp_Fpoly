using System.Runtime.CompilerServices;
using TURTO_BUOI2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<SinhVien> dssv = new List<SinhVien>();
    chonlaichucnang:
        double max, min;
        Console.WriteLine("MENU");
        Console.WriteLine("1. Nhap danh sach hoc vien");
        Console.WriteLine("2.Xuat danh sach hoc vien");
        Console.WriteLine("3.Tim kiem theo khoang diem");
        Console.WriteLine("4.Tim kiem theo hoc luc");
        Console.WriteLine("5. Tim theo MSSV va cap nhat thong tin");
        Console.WriteLine("Chon chuc nang");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
            chucnang1:
                Console.WriteLine("Nhap danh sach sinh vien");
                Console.WriteLine("Nhap so luong sinh vien");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    SinhVien sv = new SinhVien();
                    sv.Nhap();
                    dssv.Add(sv);
                }
                break;
            case 2:
                if (dssv.Count == 0)
                {
                    goto chucnang1;
                }
                foreach (SinhVien x in dssv)
                {
                    x.Xuat();
                }
                break;
            case 3:
                if (dssv.Count == 0)
                {
                    goto chucnang1;
                }
                Console.WriteLine("Nhap diem thap nhat:");
                min = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem cao nhat:");
                max = double.Parse(Console.ReadLine());
                foreach (SinhVien x in dssv)
                {
                    if (x.getDiem() <= max && x.getDiem() >= min)
                    {
                        x.Xuat();
                    }
                }
                break;
            case 4:
                if (dssv.Count == 0)
                {
                    goto chucnang1;
                }
                Console.WriteLine("Nhap hoc luc muon tim kiem:");
                Console.WriteLine("VD: xuat sac, gioi, kha, trung binh, yeu");
                string hocLuc = Console.ReadLine();

                foreach (SinhVien x in dssv)
                {
                    if (String.Compare(hocLuc, x.getHocLuc(), true) == 0)
                    {
                        x.Xuat();
                    }
                }
                break;
            case 5:
                if (dssv.Count == 0)
                {
                    goto chucnang1;
                }
                Console.WriteLine("Nhap MSSV muon tim:");
                string MSSV = Console.ReadLine();

                foreach(SinhVien x in dssv)
                {
                    if(String.Compare(MSSV, x.getMSSV(), true) == 0)
                    {
                        x.Xuat();
                    }
                    Console.WriteLine("Ban co muon cap nhap thong tin hay khong?\n y/n");
                    string yn = Console.ReadLine();
                    if (yn == "Y" || yn == "y")
                    {
                        x.Nhap();
                    }
                }
                foreach (SinhVien x in dssv)
                {
                    x.Xuat();
                }
                break;
                case 6:
                Console.WriteLine("5.  Tìm học viên theo mã số và cập nhật thông tin học viên");

                foreach (SinhVien sv in dssv)
                {
                    Console.WriteLine("Nhập mssv cho sinh viên: ");
                    sv.MSSV = Console.ReadLine();
                    Console.WriteLine("==============================\n");
                }
                Console.Write("Nhập mã số sinh viên cần tìm: ");
                string mssv = Console.ReadLine();
                int count = 0;
                foreach (SinhVien sv in dssv)
                {
                    if (mssv == sv.MSSV)
                    {
                        count++;
                        sv.Xuat();
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Không tìm thấy !");
                    }
                    else
                    {
                        Console.WriteLine("==================================================");
                        Console.WriteLine("Bạn có muốn cập nhật thông tin sinh viên không(y/n)?");
                        char yn = char.Parse(Console.ReadLine());
                        if (yn == 'y' || yn == 'Y')
                        {
                            sv.Nhap();
                            sv.Xuat();
                        }
                    }
                }

                break;
            default:
                break;

        }
        Console.WriteLine("Ban muon tiep tuc chuong trinh khong? \nBam '1' de tiep tuc chuong trinh");
        n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            goto chonlaichucnang;
        }
    }
}