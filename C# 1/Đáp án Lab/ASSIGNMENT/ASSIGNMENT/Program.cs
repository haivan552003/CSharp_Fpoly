
using ASSIGNMENT;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

internal class Program
{
    static List<SinhVien>dssv = new List<SinhVien>();
    public static void Main(string[] args)
    {
        int LuaChon;
        char n;
        
        chucnang:
        do
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\t\tNhập từ 1-10!");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("\t\tBảng Menu\t\t\t\t\t\t||");
            Console.WriteLine("1.  Nhập danh sách học viên\t\t\t\t\t\t||");
            Console.WriteLine("2.  Xuất danh sách học viên\t\t\t\t\t\t||");
            Console.WriteLine("3.  Tìm kiếm học viên theo khoảng điểm\t\t\t\t\t||");
            Console.WriteLine("4.  Tìm kiếm học viên theo học lực\t\t\t\t\t||");
            Console.WriteLine("5.  Tìm học viên theo mã số và cập nhật thông tin học viên\t\t||");
            Console.WriteLine("6.  Sắp xếp học viên theo điểm\t\t\t\t\t\t||");
            Console.WriteLine("7.  Xuất 5 học viên có điểm cao nhất\t\t\t\t\t||");
            Console.WriteLine("8.  Tính điểm trung bình của lớp\t\t\t\t\t||");
            Console.WriteLine("9.  Xuất danh sách học viên có điểm trên điểm trung bình của lớp\t||");
            Console.WriteLine("10. Tổng hợp số sinh viên theo học lực\t\t\t\t\t||");
            Console.WriteLine("==========================================================================");
            Console.Write("\bNhập Lựa Chọn: ");
            while (true)
            {
                try
                {
                    LuaChon = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Kiểu dữ liệu phải là số . Mời bạn nhập lại !");
                    Console.Write("\bNhập Lựa Chọn: ");
                }
            }
            switch (LuaChon)
            {
                case 1:
                    {
                        
                        Y1();
                        break;
                    }
                case 2:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        Y2();
                        break;
                    }
                case 3:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        Y3();
                        break;
                    }
                case 4:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        Y4();
                        break;
                    }
                case 5:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        y5();
                        break;
                    }
                case 6:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        y6();
                        break;
                    }
                case 7:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        y7();
                        break;
                    }
                case 8:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        y8();
                        break;
                    }
                case 9:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        
                        y9();
                        break;
                    }
                case 10:
                    {
                        if (dssv.Count == 0)
                        {
                            goto case 1;
                        }
                        y10();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Mời bạn chọn lại số chức năng được hiển thị !");
                        break;
                    }
                    
            }
        } while (LuaChon < 1 || LuaChon > 10);
        Console.Write("Bạn có muốn tiếp tục không(Y/N)?");
        n = char.Parse(Console.ReadLine());
        while (n == 'Y' || n == 'y')
        {
            Console.Clear();
            goto chucnang;
        }
    }
    
    
    static void Y1()
    {
        dssv = SinhVien.NhapDanhSachSV();  
    }
    static void Y2()
    {
        Console.WriteLine("\t2.  Xuất danh sách học viên");
        foreach (SinhVien sv in dssv)
        {
            sv.Xuat();
        }    

    }
    static void Y3()
    {
        
        Console.WriteLine("3.  Tìm kiếm học viên theo khoảng điểm");
        
        int count = 0;
        double min, max;
        Console.WriteLine("Nhập điểm thấp nhất: ");
        while (true)
        {
            try
            {
                min = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Kiểu dữ liệu phải là số . Mời bạn nhập lại !");
                Console.WriteLine("Nhập điểm thấp nhất: ");
            }
        }
        Console.WriteLine("Nhập điểm cao nhất: ");
        while (true)
        {
            try
            {
                max = double.Parse(Console.ReadLine());
                break ;
            }
            catch (Exception)
            {
                Console.WriteLine("Kiểu dữ liệu phải là số . Mời bạn nhập lại !");
                Console.WriteLine("Nhập điểm cao nhất: ");
            }
        }
        foreach (SinhVien sv in dssv)
        {
            if (sv.getDiem() >= min && sv.getDiem() <= max)
            {
                count++;
                sv.Xuat();
            }
        }
        if (count == 0)
        {
            Console.WriteLine($"Không tìm thấy sinh nào trong khoảng điểm ({min}-{max}) !");
        }

    }
    static void Y4()
    {
        Console.WriteLine("4.  Tìm kiếm học viên theo học lực");
        Console.WriteLine("\tTìm kiếm sinh viên có học lực là: ");
        string theoHocLuc = Console.ReadLine();
        int count = 0;
        foreach (SinhVien sv in dssv)
        {
            if (string.Compare(sv.getHocLuc(), theoHocLuc.ToLower(), true) == 0 || string.Compare(sv.getHocLuc(), theoHocLuc.ToUpper(), true) == 0)
            {
                count++;
                sv.Xuat();
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Không tìm thấy !");
        }
    }
    static void y5()
    {
        Console.WriteLine("5.  Tìm học viên theo mã số và cập nhật thông tin học viên");
        
        foreach (SinhVien sv in dssv)
        {
            Console.WriteLine($"Nhập mssv cho sinh viên {sv.getHoten()}: ");
        mssv:
            string maso = Console.ReadLine();
            string pmssv = "^(PC|PO|PH)[0-9]{5}";
            if (!Regex.IsMatch(maso.ToUpper(), pmssv))
            {
                Console.WriteLine("Vui long nhap lai MSSV"); goto mssv;
            }
            else
            {
                sv.MSSV = maso;
            }
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
    }
    static void y6()
    {
        Console.WriteLine("6.  Sắp xếp học viên theo điểm");
        for (int i = 0; i < dssv.Count - 1; i++)
        {
            for (int j = i + 1; j < dssv.Count; j++)
            {
                if (dssv[i].getDiem() > dssv[j].getDiem())
                {
                    SinhVien temp = dssv[i];
                    dssv[i] = dssv[j];
                    dssv[j] = temp;
                }
            }
        }
        Console.WriteLine("\tDSSV SAU KHI SẮP XẾP TĂNG DẦN \n");
        foreach (SinhVien sv in dssv)
        {
            sv.Xuat();
        }
    }
    static void y7()
    {
        
        Console.WriteLine("7.  Xuất 5 học viên có điểm cao nhất");
        dssv.Sort(new SinhVienComparerGiamDan());

        if (dssv.Count < 5)
        {
            Console.WriteLine($"Chỉ có {dssv.Count} sinh viên trong danh sách:");
            foreach (SinhVien sv in dssv)
            {
                sv.Xuat();
            }

        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                dssv[i].Xuat();
            }
        }
    }
    static void y8()
    {
        Console.WriteLine("8.  Tính điểm trung bình của lớp");
        int dem = 0;
        double tong = 0;
        for (int i = 0; i < dssv.Count; i++)
        {
            foreach (SinhVien sv in dssv)
            {
                dem++;
                tong += sv.getDiem();
            }
        }
        double dtb = tong / dem;
        foreach (SinhVien sv in dssv)
        {
            sv.Xuat();
        }
        Console.WriteLine("Tổng điểm trung bình của lớp : {0:.00}", dtb);
    }
    static void y9()
    {
        Console.WriteLine("9.  Xuất danh sách học viên có điểm trên điểm trung bình của lớp");
        int dem = 0;
        double tong = 0;
        for (int i = 0; i < dssv.Count; i++)
        {
            foreach (SinhVien sv in dssv)
            {
                dem++;
                tong += sv.getDiem();
            }
        }
        double dtb = tong / dem;
        foreach (SinhVien sv in dssv)
        {
            sv.Xuat();
        }
        Console.WriteLine("Tổng điểm trung bình của lớp : {0:.00}\n", dtb);
        Console.WriteLine("======================================");
        Console.WriteLine("DSSV có điểm trên điểm trung bình của lớp\n");
        foreach (SinhVien sv in dssv)
        {
            if (sv.getDiem() >= dtb)
            {
                sv.Xuat();            
            }
        }
    }
    static void y10()
    {
        Console.WriteLine("\n\t10. Tổng hợp số sinh vien theo học lực");
        Console.WriteLine("===========================");
        
        Console.WriteLine("Tổng hợp sinh viên theo học lực là: ");
        string theoHocLuc = Console.ReadLine();
        Console.WriteLine("==========================================");
        int count = 0;
        foreach (SinhVien sv in dssv)
        {
            if (string.Compare(sv.getHocLuc(), theoHocLuc.ToLower(), true) == 0 )
            {
                count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine("Có "+count+" học sinh theo học lực  " +theoHocLuc+" :");
        }
        else
        {
            Console.WriteLine("Không tìm thấy !\n");
        }
        Console.WriteLine("=============================");
        foreach (SinhVien sv in dssv)
        {
            if (string.Compare(sv.getHocLuc(), theoHocLuc.ToLower(), true) == 0)
            {
                sv.Xuat();
            }
        }
        
    }
}