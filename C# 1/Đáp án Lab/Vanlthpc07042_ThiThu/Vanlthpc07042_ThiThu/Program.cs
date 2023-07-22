using ThiThu;

internal class Program
{
    private static void Main(string[] args)
    {
        List<CanBo> canBos = new List<CanBo>();
        List<KySu> kySus = new List<KySu>();
        int count_tuoi = 0;
    menu:
        Console.WriteLine("MENU");
        Console.WriteLine("1. Nhap - Xuat");
        Console.WriteLine("2. Danh sach an bo nu 18 - 30");
        Console.WriteLine("3. So luong nam nu:");
        Console.WriteLine("4. Nhap - Xuat ky su");
        Console.WriteLine("5.Thoat");
        Console.WriteLine("chon chuc nang");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
            case1:
                Console.WriteLine("Nhap so luong can bo");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    CanBo cb = new CanBo();
                    cb.Nhap();
                    canBos.Add(cb);
                }
                foreach (CanBo x in canBos)
                {
                    x.Xuat();
                }
                break;
            case 2:
                if (canBos.Count == 0)
                {
                    goto case1;
                }
                foreach (CanBo x in canBos)
                {
                    if (x.gioiTinh == "nu" && x.getTuoi() >= 18 && x.getTuoi() <= 30)
                    {
                        count_tuoi++;
                        x.Xuat();
                    }
                }
                Console.WriteLine("Can bo nu tu 18 den 30: " + count_tuoi);
                break;
            case 3:
                if (canBos.Count == 0)
                {
                    goto case1;
                }
                int count_nu = 0, count_nam = 0;
                foreach (CanBo x in canBos)
                {

                    if (x.gioiTinh == "nu")
                    {
                        count_nu++;

                    }
                    else
                    {
                        count_nam++;

                    }
                }
                Console.WriteLine("Can bo nam: " + count_nam);
                Console.WriteLine("Can bo nu: " + count_nu);
                break;
            case 4:
                Console.WriteLine("Nhap so luong ky su");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    KySu ks = new KySu();
                    ks.Nhap();
                    kySus.Add(ks);
                }
                foreach (KySu x in kySus)
                {
                    x.Xuat();
                }
                break;
            case 5:
                break;
            default:
                break;
        }

        Console.WriteLine("Bam 1 de tiep tuc chuong trinh");
        n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            goto menu;
        }


    }
}