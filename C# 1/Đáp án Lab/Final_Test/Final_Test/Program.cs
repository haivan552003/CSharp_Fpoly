using Final_Test;

internal class Program
{
    private static void Main(string[] args)
    {
        List<QuanLyThiSinh> ts = new List<QuanLyThiSinh>();
        List<QuanLyThiSinh> tsdl = new List<QuanLyThiSinh>();
    menu:
        Console.WriteLine("===============CHƯƠNG TRÌNH QUẢN LÝ TUYỂN SINH=============");
        Console.WriteLine("============ 1. Nhập danh sách thí sinh. =============");
        Console.WriteLine("============ 2. Xuất danh sách thí sinh. =============");
        Console.WriteLine("============ 3. Tìm thí sinh theo mã. =============");
        Console.WriteLine("============ 4. Kết thúc chương trình. =============");
        Console.WriteLine("===========LE THI HAI VAN – PC07042 – FINAL TEST============");
        Console.WriteLine("chon chuc nang: ");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
            chucnang1:
                Console.WriteLine("Nhap so luong thi sinh:");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    QuanLyThiSinh thiSinh = new QuanLyThiSinh();
                    thiSinh.NhapCNTT();
                    ts.Add(thiSinh);
                }
                for (int i = 0; i < n; i++)
                {
                    QuanLyThiSinh dl = new QuanLyThiSinh();
                    dl.NhapDLNHKS();
                    tsdl.Add(dl);

                }
                break;
            case 2:
                if (ts.Count == 0)
                {
                    goto chucnang1;
                }
                foreach (QuanLyThiSinh x in ts)
                {
                    x.XuatCNTT();
                }
                Console.WriteLine("--------------");
                foreach (QuanLyThiSinh x in tsdl)
                {
                    x.XuatDLNHKS();
                }
                break;
            case 3:
                if (ts.Count == 0)
                {
                    goto chucnang1;
                }
                Console.WriteLine("Nhap MTS can tim:");
                string timkiem = Console.ReadLine();
                foreach (QuanLyThiSinh x in ts)
                {
                    if (timkiem.ToUpper() == x.MTS.ToUpper())
                    {
                        x.XuatCNTT();
                    }
                    else
                    {
                        Console.WriteLine("Khong co CNTT");
                    }
                }
                foreach(QuanLyThiSinh x in tsdl)
                {
                    if (timkiem.ToUpper() == x.MTS.ToUpper())
                    {
                        x.XuatDLNHKS();
                    }
                    else
                    {
                        Console.WriteLine("Khong co DLNHKS");
                    }
                }

                break;
            case 4:
                break;
            default:
                break;
        }
        Console.WriteLine("Tiep tuc chuong trinh bam 1");
        n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            goto menu;
        }
    }
}