using Demo_Slide5;
using DemoLab5;
using System.Collections;
using Vanlthpc07042_Lab5;
using Vanlthpc07042_Lab5_Bai1;
using Vanlthpc07042_Lab5_Bai2;

internal class Program
{
    private static void Main(string[] args)
    {
    Reset:
        Console.WriteLine("MENU");
        Console.WriteLine("1. Chu Vi - Dien Tich");
        Console.WriteLine("2. Sinh Vien Poly");
        Console.WriteLine("3. Demo Slide 5");
        Console.WriteLine("4. Demo lop truu tuong");
        Console.WriteLine("Chon chuc nang: ");
        int choose = Convert.ToInt32(Console.ReadLine());
        switch (choose)
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
                } while (vu.dai != vu.rong);
                vu.Xuat();
                break;
            case 2:
                List<SinhVienPoly> dssv = new List<SinhVienPoly>();

                Console.WriteLine("Nhap so luong sinh vien IT: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap sinh vien thu " + i + 1);
                    SinhVienIT temp = new SinhVienIT();
                    temp.Nhap();
                    dssv.Add(temp);
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Nhap so luong sinh vien Biz: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap sinh vien thu " + i + 1);
                    SinhVienBiz temp = new SinhVienBiz();
                    temp.Nhap();
                    dssv.Add(temp);
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sinh vien vua nhap la");
                foreach (SinhVienPoly x in dssv)
                {
                    x.Xuat();
                    Console.WriteLine("............................");
                }
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Danh sach sinh vien hoc luc gioi");
                foreach (SinhVienPoly x in dssv)
                {
                    if (x.getHocLuc() == "Gioi")
                    {
                        x.Xuat();
                    }
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sinh vien sau khi xap xep");
                for (int i = 0; i < dssv.Count; i++)
                {
                    for (int j = i + 1; j < dssv.Count; j++)
                    {
                        if (dssv[i].getDiem() > dssv[j].getDiem())
                        {
                            SinhVienPoly sv_temp = dssv[i];
                            dssv[i] = dssv[j];
                            dssv[j] = sv_temp;
                        }
                    }
                }
                foreach (SinhVienPoly x in dssv)
                {
                    x.Xuat();
                    Console.WriteLine("............................");
                }
                break;
            case 3:
                Con cc = new Con();
                cc.ConKeu();
                Console.WriteLine("-----------------------------");
                KeToan kt = new KeToan();
                Console.WriteLine("Luong: " + kt.luong);
                Console.WriteLine("Thuong: " + kt.tienThuong);
                Console.WriteLine(".............................");
                LapTrinhVien ltv = new LapTrinhVien();
                Console.WriteLine("Luong: " + ltv.luong);
                Console.WriteLine("Thuong: " + ltv.tienThuong);
                Console.WriteLine(".............................");
                QuanTriVien qtv = new QuanTriVien();
                Console.WriteLine("Luong: " + qtv.luong);
                Console.WriteLine("Thuong: " + qtv.tienThuong);
                Console.WriteLine("-----------------------------");


                Nhanvien nv = new Nhanvien("Cao dang", "PC07042", "Van", "Nu");
                Console.WriteLine("Ma so: " + nv.maSo);
                Console.WriteLine("Ho ten: " + nv.hoTen);
                Console.WriteLine("Gioi tinh: " + nv.gioiTinh);
                Console.WriteLine("Bang cap: " + nv.bangCap);

                Console.WriteLine("-----------------------------");
                ArrayList dsnv = new ArrayList();
                Console.Write("Nhap so luong nhan vien: ");
                int m = int.Parse(Console.ReadLine());
                for (int i = 0; i < m; i++)
                {
                    Nhanvien nvien = new Nhanvien();
                    nvien.Nhap();
                    dsnv.Add(nvien);
                }
                Console.WriteLine(".............................");
                foreach (Nhanvien x in dsnv)
                {
                    Console.WriteLine("Ho ten: " + x.hoTen);
                    Console.WriteLine("Gioi tinh: " + x.gioiTinh);
                    Console.WriteLine("Bang cap: " + x.bangCap);
                    Console.WriteLine(".............................");
                }


                Console.WriteLine("-----------------------------");//nap chong
                tinhtoan tt = new tinhtoan();
                int tong = tt.sum(3, 4);
                double tong2 = tt.sum(7.0, 8.5);
                Console.WriteLine(tong2);

                Console.WriteLine("-----------------------------");

                con c1 = new con();
                c1.show();
                break;
            case 4:
                SvCSharp svcsharp = new SvCSharp(9, 7, 10);
                SvWeb svWeb = new SvWeb(9, 7, 10);
                Console.WriteLine("C#: " + svcsharp.getdiemTB());
                Console.WriteLine("Web: " + svWeb.getdiemTB());
                break;
            default:
                Console.WriteLine("Khong co chuc nang");
                Console.Clear();
                goto Reset;
                break;    
        }
        Console.WriteLine("Bam '1' de tiep tuc chuong trinh");
        choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            Console.Clear();
            goto Reset;
        }
    }
}