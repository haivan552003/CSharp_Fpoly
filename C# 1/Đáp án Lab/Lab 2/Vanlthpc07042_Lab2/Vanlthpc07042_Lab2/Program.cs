internal class Program
{
    private static void PTB1()
    {
        //BAI1
        Console.WriteLine("Giai phuong trinh bac 1");
        float a, b;
        Console.Write("Nhap a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            Console.Write("Nghiem cua phuong trinh la: " + (-b / a));
        }

        Console.ReadKey();
    }
    //BAI2
    private static void PTB2()
    {
        Console.WriteLine("Giai phuong trinh bac 2");
        float a, b, c;
        float delta;

        Console.Write("Nhap a: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = float.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        c = float.Parse(Console.ReadLine());

        delta = b * b - 4 * a * c;
        Console.WriteLine("Delta: " + delta);
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep: " + (-b / 2 * a));
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem: x1 = {0}\n\t\tx2= {1}" + x1, x2);
            }
        }
        Console.ReadKey();
    }
    //BAI 3
    //ngay thuong
    private static void DDMMYY(int day, int month, int year)
    {
        int yesterday = day - 1;
        int tomorrow = day + 1;
        Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
        Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
    }
    //ngay cuoi thang khong tinh thang 2
    private static void DayofNextMonth(int day, int month, int year)
    {
        int yesterday = day - 1;
        int nextMonth = month + 1;
        int nextYear = year + 1;
        Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
        if (month != 12)
        {
            Console.WriteLine("Ngay sau: 1/{0}/{1}", nextMonth, year);
        }
        else
        {
            Console.WriteLine("Ngay sau: 1/1/" + nextYear);
        }
    }
    //cuoi thang 2
    private static void Feb_DayofMonth(int day, int month, int year)
    {
        int yesterday = day - 1;
        int tomorrow = day + 1;
        if (day == 1)
        {
            Console.WriteLine("Ngay truoc: {0}/{1}/{2}", 31, 1, year);
            Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
        }
        else
        {
            Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
            Console.WriteLine("Ngay sau: {0}/{1}/{2}", 1, month + 1, year);
        }
    }
    //ngay dau thang
    private static void DayofLastMonth(int day, int month, int year)
    {
        int tomorrow = day + 1;
        int lastYear = year - 1;
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (month != 1)
            {
                Console.WriteLine("Ngay truoc: 30/{0}/{1}", month - 1, year);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
            }
            else
            {
                Console.WriteLine("Ngay truoc: 31/12/" + lastYear);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
            }
        }
        else
        {
            if (month != 1)
            {
                Console.WriteLine("Ngay truoc: 31/{0}/{1}", month - 1, year);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
            }
            else
            {
                Console.WriteLine("Ngay truoc: 31/12/" + lastYear);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
            }
        }

    }
    //ham chinh bai 3
    private static void DayofMonth()
    {
        Console.WriteLine("Chuong trinh Ngay, thang, nam");
        int day, month, year;
        do
        {
            Console.Write("Nhap ngay hom nay: ");
            day = Convert.ToInt32(Console.ReadLine());
        } while (day < 1 || day > 31);

        Console.Write("Nhap thang hom nay: ");
        month = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.Write("Nhap nam hom nay: ");
            year = Convert.ToInt32(Console.ReadLine());
        } while (year < 0);
        Console.WriteLine("\nHom nay la ngay {0} thang {1} nam {2}\n", day, month, year);
        //kiem tra thang co bao nhieu ngay                    
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                {
                    if (day == 1)
                    {
                        DayofLastMonth(day, month, year);
                    }
                    else if (day == 31)
                    {
                        DayofNextMonth(day, month, year);
                    }
                    else
                    {
                        DDMMYY(day, month, year);
                    }
                    Console.WriteLine("Thang co 31 ngay");
                    break;
                }
            case 4:
            case 6:
            case 9:
            case 11:
                {
                    if (day == 1)
                    {
                        DayofLastMonth(day, month, year);
                    }
                    else if (day == 30)
                    {
                        DayofNextMonth(day, month, year);
                    }
                    else
                    {
                        DDMMYY(day, month, year);
                    }
                    Console.WriteLine("Thang co 30 ngay");
                    break;
                }
            case 2:
                {
                    //kiem tra nam nhuan
                    if (year % 4 == 0)
                    {
                        if (day != 28 && day != 29 && day != 1) //ngay thuong 
                        {
                            DDMMYY(day, month, year);
                        }
                        else
                        {
                            Feb_DayofMonth(day, month, year);
                        }
                        Console.WriteLine("Thang co 29 ngay");
                    }
                    else
                    {
                        if (day == 29)
                        {
                            Console.WriteLine("Nam khong nhuan khong co ngay 29 thang 2");
                        }
                        else
                        {
                            if (day != 28 && day != 29 && day != 1) //ngay thuong 
                            {
                                DDMMYY(day, month, year);
                            }
                            else
                            {
                                Feb_DayofMonth(day, month, year);
                            }
                        }
                        Console.WriteLine("Thang co 28 ngay");
                    }
                    break;
                }
            default:
                Console.WriteLine("Thang khong ton tai");
                break;
        }
    }

    //BAI 4
    static void SoNguyenTo()
    {
        Console.WriteLine("Chuong trinh xac dinh so nguyen to");
        int i, n;
        bool ok = true;
        Console.Write("Nhap n: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 2; i < n - 1; i++)
        {
            if (n % i == 0)
            {
                ok = false;
                break;
            }
        }
        if (ok == true)
        {
            Console.WriteLine(n + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(n + " khong phai la so nguyen to");
        }

        Console.ReadKey();
    }
    //BAI 5
    static void BangCuuChuong()
    {
        Console.WriteLine("Chuong trinh bang cuu chuong");
        int i, bangCuuChuong, ketQua;
        do
        {
            Console.Write("Nhap bang cuu chuong: ");
            bangCuuChuong = Convert.ToInt32(Console.ReadLine());
        } while (bangCuuChuong < 2 || bangCuuChuong > 9);

        Console.WriteLine("Bang cuu chuong " + bangCuuChuong);
        for (i = 1; i <= 10; i++)
        {
            ketQua = bangCuuChuong * i;
            Console.WriteLine("{0} x {1} = {2}", bangCuuChuong, i, ketQua);
        }

        Console.ReadKey();
    }
    //CAC BAI TAP DEMO
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

        if (luongThuong < 9000000)
        {
            thue = 0;
        }
        else if (luongThuong < 15000000)
        {
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
    private static void TrungBinhCong()
    {
        int count = 0;
        int tong = 0; ;
        int i = 27;
        while (i <= 250)
        {
            if (i % 3 == 0)
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
        for (i = 0; i < 10; i++)
        {
            a1[i] = rd.Next(1, 10);
        }
        foreach (int val in a1)
        {
            Console.Write(val + " ");
        }
    }
    private static void Main(string[] args)
    {
        TiepTuc:
        int choose;
        Console.WriteLine("MENU CHUC NANG");
        Console.WriteLine("1. Giai phuong trinh bac 1");
        Console.WriteLine("2. Giai phuong trinh bac 2");
        Console.WriteLine("3. Ngay thang nam");
        Console.WriteLine("4. Xac dinh so nguyen to");
        Console.WriteLine("5. Bang cuu chuong");
        Console.WriteLine("CAC BAI DEMO");
        Console.WriteLine("6. Can bac hai");
        Console.WriteLine("7. Tinh thue");
        Console.WriteLine("8. Tinh trung binh cong");
        Console.WriteLine("9. Nhap diem");
        Console.WriteLine("10. Demo vong lap foreach");
        Console.WriteLine("______________________________");
        Console.WriteLine("Chon chuc nang: ");
        choose = Convert.ToInt32(Console.ReadLine());
        switch(choose)
        {
            case 1:
                PTB1();
                break;
            case 2:
                PTB2();
                break;
            case 3:
                DayofMonth();
                break;
            case 4:
                SoNguyenTo();
                break;
            case 5:
                BangCuuChuong();
                break;
            case 6:
                CanBac2();
                break;
            case 7:
                Thue();
                break;
            case 8:
                TrungBinhCong();
                break;
            case 9:
                NhapDiem();
                break;
            case 10:
                VongLapForeach();
                break;
            default:
                Console.WriteLine("Khong co chuc nang");
                break;
        }
        Console.WriteLine("\nCHON 1 DE TIEP TUC CHUONG TRINH");
        choose= Convert.ToInt32(Console.ReadLine());
        if(choose == 1)
        {
            goto TiepTuc;
        }
    }
}