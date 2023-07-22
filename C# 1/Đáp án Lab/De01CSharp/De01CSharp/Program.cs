using De01CSharp;
using System.ComponentModel.Design;

List<HocVien> list = new List<HocVien>();
List<HocVienTinHoc> tinhoc = new List<HocVienTinHoc>();
List<HocVienDoHoa> dohoa = new List<HocVienDoHoa>();
menu:
Console.WriteLine("CHUONG TRINH QUAN LY TUYEN SINH");
Console.WriteLine("1. Nhap danh sach thi sinh");
Console.WriteLine("2. Xuat danh sach thi sinh");
Console.WriteLine("3. Tim thi sinh theo so dien thoai");
Console.WriteLine("4. Ket thuc chuong trinh");
Console.WriteLine("Chon chuc nang: ");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
    case1:
        Console.WriteLine("Nhap so luong thi sinh tin hoc: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            HocVienTinHoc th = new HocVienTinHoc();
            th.Nhap();
            tinhoc.Add(th);

        }
        Console.WriteLine("Nhap so luong thi sinh do hoa: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            HocVienDoHoa dh = new HocVienDoHoa();
            dh.Nhap();
            dohoa.Add(dh);

        }
        break;
    case 2:
        if (tinhoc.Count == 0 || dohoa.Count == 0)
        {
            goto case1;
        }
        Console.WriteLine("Hoc vien tin hoc");
        foreach (HocVienTinHoc i in tinhoc)
        {
            i.Xuat();
        }
        Console.WriteLine("Hoc vien do hoa");

        foreach (HocVienDoHoa x in dohoa)
        {
            x.Xuat();
        }
        break;
    case 3:
        if (tinhoc.Count == 0 || dohoa.Count == 0)
        {
            goto case1;
        }
        Console.WriteLine("Nhap so dien thoai can tim: ");
        string sdt = Console.ReadLine();
        foreach (HocVienTinHoc i in tinhoc)
        {
            if(sdt == i.soDienThoai)
            {
                i.Xuat();
            }
        }
        foreach (HocVienDoHoa x in dohoa)
        {
            if (sdt == x.soDienThoai)
            {
                x.Xuat();
            }
        }
        break;
    case 4:
        break;
    default:

        break;
}
Console.WriteLine("Bam 1 tiep tuc chuong trinh");
n = int.Parse(Console.ReadLine());
if (n == 1)
{
    goto menu;
}
