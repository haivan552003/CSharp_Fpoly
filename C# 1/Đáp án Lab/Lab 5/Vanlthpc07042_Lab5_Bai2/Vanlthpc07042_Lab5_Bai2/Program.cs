using System.Collections;
using Vanlthpc07042_Lab5_Bai1;
using Vanlthpc07042_Lab5_Bai2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<SinhVienPoly> dssv = new List<SinhVienPoly>();

        Console.WriteLine("Nhap so luong sinh vien IT: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap sinh vien thu "+ i + 1);
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
        foreach(SinhVienPoly x in dssv)
        {
            if(x.getHocLuc() == "Gioi")
            {
                x.Xuat();
            }
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Sinh vien sau khi xap xep");
        for(int i = 0; i < dssv.Count; i++)
        {
            for(int j = i + 1; j < dssv.Count; j++)
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
    }
}