using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Vanlthpc07042_Asigment_CSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        List<SinhVien> dssv = new List<SinhVien>();  

        ChonLaiChucNang:
        int n, choose;
        int count = 0;
        double tong = 0;
        double DTB;
        Console.WriteLine("\t\tMENU CHUONG TRINH");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("1. Nhập danh sách học viên");
        Console.WriteLine(".....................................................");
        Console.WriteLine("2. Xuất danh sách học viên");
        Console.WriteLine(".....................................................");
        Console.WriteLine("3. Tìm kiếm thông tin học viên theo khoảng điểm");
        Console.WriteLine(".....................................................");
        Console.WriteLine("4. Tìm kiếm học viên theo học lực");
        Console.WriteLine(".....................................................");
        Console.WriteLine("5. Tìm kiếm thông tin theo MSSV và cập nhật thông tin");
        Console.WriteLine(".....................................................");
        Console.WriteLine("6. Sắp xếp học viên theo điểm");
        Console.WriteLine(".....................................................");
        Console.WriteLine("7. Xuất 5 học viên có điểm cao nhất");
        Console.WriteLine(".....................................................");
        Console.WriteLine("8. Tính điểm trung bình của lớp");
        Console.WriteLine(".....................................................");
        Console.WriteLine("9. Danh sách học viên có điểm trên điểm trung bình");
        Console.WriteLine(".....................................................");
        Console.WriteLine("10. Tổng hợp số học viên theo học lực");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Chọn chức năng");
        choose = Convert.ToInt32(Console.ReadLine());
       
        switch (choose)
        {
            case 1:
                chucnang1:
                Console.WriteLine("Nhập danh sách học viên");
                Console.WriteLine("-----------------------");
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
                Console.WriteLine("Xuất danh sách học viên");
                Console.WriteLine("-----------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                foreach (SinhVien x in dssv)
                {
                    x.Xuat();
                }
                break;
            case 3:
                Console.WriteLine("Tìm kiếm thông tin học viên theo khoảng điểm");
                Console.WriteLine("--------------------------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                Console.WriteLine("Nhập điểm thấp nhất: ");
                double min = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm cao nhất: ");
                double max = double.Parse(Console.ReadLine());
                foreach (SinhVien x in dssv)
                {   
                    if(x.getDiem() <= max && x.getDiem() >= min)
                    x.Xuat();
                }
                break;
            case 4:
                Console.WriteLine("Tìm kiếm học viên theo học lực");
                Console.WriteLine("------------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                Console.WriteLine("Nhập học lực muốn tìm kiếm: ");
                Console.WriteLine("VD: xuất sắc, giỏi, khá, trung bình, yếu");
                string hocLuc = Console.ReadLine();
                
                foreach (SinhVien x in dssv)
                {
                    if (String.Compare(hocLuc, x.getHocLuc(), true) == 0)
                        x.Xuat();
                }
                break;
            case 5:
                Console.WriteLine("Tìm kiếm thông tin theo MSSV và cập nhật thông tin");
                Console.WriteLine("--------------------------------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                foreach(SinhVien x in dssv)
                {
                    MSSV:
                    Console.WriteLine("Cập nhật mã số sinh viên");
                    x.MSSV = Console.ReadLine();
                    string pMSSV = "(PC|PH)[0-9a-zA-Z]{5}";
                    if (Regex.IsMatch(x.MSSV.ToUpper(), pMSSV))
                    {
                        Console.WriteLine("MSSV hợp lệ");
                    }
                    else
                    {
                        Console.WriteLine("MSSV không hợp lệ");
                        goto MSSV;
                    }
                }
                Console.WriteLine("Đã cập nhật xong");
                suaMSSV:
                Console.WriteLine("Nhập MSSV muốn tìm: ");
                string MSSV = Console.ReadLine();
                foreach (SinhVien x in dssv)
                {
                    if (String.Compare(MSSV, x.MSSV, true) == 0)
                    {
                        x.Xuat();
                        Console.WriteLine(".....................................................");
                        Console.WriteLine("Bạn có muốn cập nhập thông tin sinh viên lại không?\n Y/N");
                        string y = Console.ReadLine();
                        if (y == "Y" || y == "y")
                        {
                            x.Nhap();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không có sinh viên");
                        goto suaMSSV;
                    }
                        
                }
                foreach (SinhVien x in dssv) 
                {
                    x.XuatY5();
                    x.Xuat(); 
                }
                break;
            case 6:
                Console.WriteLine("Sắp xếp học viên theo điểm");
                Console.WriteLine("--------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                dssv.Sort(new SapXepTheoDiem());
                foreach(SinhVien x in dssv)
                {
                    x.Xuat();
                }    
                break;
            case 7:
                Console.WriteLine("Xuất 5 học viên có điểm cao nhất");
                Console.WriteLine("--------------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                dssv.Sort(new SapXepTheoDiemY7());
                if (dssv.Count < 5)
                {
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        dssv[i].Xuat();
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        dssv[i].Xuat();
                    }
                }
                break;
            case 8:
                Console.WriteLine("Tính điểm trung bình của lớp");
                Console.WriteLine("----------------------------");
                if (dssv.Count == 0)
                    goto chucnang1;
                for (int i = 0; i < dssv.Count; i++)
                {
                    foreach (SinhVien x in dssv)
                    {
                        count++;
                        tong += x.getDiem();
                    }
                }
                DTB = tong / count;
                Console.WriteLine("Điểm trung binh của lớp: " + DTB);
                break;
            case 9:
                Console.WriteLine("Danh sách học viên có điểm trên điểm trung bình");
                Console.WriteLine("-----------------------------------------------");
                for (int i = 0; i < dssv.Count; i++)
                {
                    foreach (SinhVien x in dssv)
                    {
                        count++;
                        tong += x.getDiem();
                    }
                }
                DTB = tong / count;
                foreach (SinhVien x in dssv)
                {
                    if(x.getDiem() > DTB)
                    {
                        x.Xuat();
                    }
                }
                break;
            case 10:
                Console.WriteLine("Tổng hợp số học viên theo học lực");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nhập học lực muốn tổng: ");
                Console.WriteLine("VD: xuất sắc, giỏi, khá, trung bình, yếu");
                string theoHocLuc = Console.ReadLine();
               
                foreach (SinhVien x in dssv)
                {
                    if (String.Compare(theoHocLuc, x.getHocLuc(), true) == 0)
                        count++;
                }
                if(count != 0)
                {
                    Console.WriteLine("Tổng số học lực loại '{0}' là: {1}", theoHocLuc, count);
                }
                else
                {
                    Console.WriteLine("Không có học sinh xếp loại '{0}'", theoHocLuc);
                }
                break;
            default:
                Console.Clear();
                Console.WriteLine("Khong co chuc nang");
                goto ChonLaiChucNang;
                break;
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        try
        {
            Console.WriteLine("Bam '1' de tiep tuc chuong trinh");
            choose = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e) {}
        
        if(choose== 1)
        {
            Console.Clear();
            goto ChonLaiChucNang;
        }        
    }

}
/*
 Console.WriteLine("Nhap ma CN:");
        string ma = Console.ReadLine();
        string pma = ;
        
 */