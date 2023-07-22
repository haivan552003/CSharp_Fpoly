internal class Program
{
    private static void CanBac2()
    {
        int so;
        try
        {
            Console.WriteLine("Nhap so: ");
            so = Convert.ToInt32(Console.ReadLine());
            if (so > 0)
            {
                Console.WriteLine("Can bac 2 la: " + Math.Sqrt(so));
            }
            else
            {
                Console.WriteLine("Can bac 2 khong am");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Phai nhap so nguyen");
        }

    }
    private static void Thue()
    {
        double luong, thue, thuong;
        Console.Write("Nhap luong: ");
        luong = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap thuong: ");
        thuong = Convert.ToDouble(Console.ReadLine());

        double luongThuong = luong + thuong;

        if(luongThuong < 9000000)
        {
            thue = 0;
        }else if (luongThuong < 15000000) {
            thue = 0.1 * luongThuong;
        }
        else if (luongThuong < 30000000)
        {
            thue = 0.15 * luongThuong;
        }
        else
        {
            thue = 0.2 * luongThuong;
        }
        Console.WriteLine("Thue la: " + thue);
    }
    private static void DDMMYY()
    {
        int thang, nam;
        Console.Write("Nhap thang: ");
        thang = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap nam: ");
        nam = Convert.ToInt32(Console.ReadLine());

        switch(thang)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                Console.WriteLine("Thang co 31 ngay");
                break;
            case 4: case 6: case 9: case 11:
                Console.WriteLine("Thang co 30 ngay");
                break;
            case 2:
                if (nam % 4 == 0)
                {
                    Console.WriteLine("Thang co 29 ngay");
                }
                else
                {
                    Console.WriteLine("Thang co 28 ngay");
                }
                break;
            default:
                Console.WriteLine("Thang khong ton tai");
                break;
        }
    }
    private static void BangCuuChuong()
    {
        int i = 1, j;
        Console.WriteLine("Dung while");
        while (i <= 10)
        {

            j = 1;
            while (j <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                j++;
            }


            i++;

        }

        Console.WriteLine("Dung for");
        for(i = 1; i <= 9; i++)
        {
            for(j = 2; j <= 10; j++) {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
            Console.WriteLine("...................");
        }
    }
    private static void TrungBinhCong()
    {
        int count = 0;
        int tong = 0; ;
        int i = 27;
        while(i <= 250)
        {
            if(i % 3 == 0)
            {
                tong += i;
                count++;
            }
            i++;
        }
        Console.WriteLine("Ket qua: " + tong / count);
    }
    private static void NhapDiem()
    {
        double diem;
        do
        {
            Console.Write("Nhap diem: ");
            diem = Convert.ToInt32(Console.ReadLine());
        } while (diem < 0 || diem > 10);
        Console.WriteLine("Diem la: " + diem);
    }
    private static void VongLapForeach()
    {
        int[] a1 = new int[10];
        Random rd = new Random();
        int i;
        for(i = 0; i< 10; i++)
        {
            a1[i] = rd.Next(1, 10);
        }
        foreach(int val in a1)
        {
            Console.Write(val + " ");
        }
    }
    private static void Main(string[] args)
    {
        int choose;
        Console.WriteLine("DANH SACH CHUC NANG\n1. Tinh can bac 2\n2. Tinh thue\n3. Ngay, thang, nam\n4.\n5.\n6.\n7.");
        Console.WriteLine("Chon chuc nang: ");
        choose = Convert.ToInt32(Console.ReadLine());
        switch (choose)
        {
            case 1: 
                CanBac2();
                break;
            case 2: 
                Thue();
                break;
            case 3:
                DDMMYY();
                break;
            case 4:
                BangCuuChuong();
                break;
            case 5:
                TrungBinhCong();
                break;
            case 6:
                NhapDiem();
                break;
            case 7:
                VongLapForeach();
                break;
            default:
                Console.WriteLine("Khong co chuc nang");
                break;
        }
        Console.ReadKey();
    }
}