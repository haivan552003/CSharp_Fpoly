internal class Program
{
    private static void canbac2()
    {
        int so;
        try
        {
            Console.WriteLine("Nhap so = ");
            so = int.Parse(Console.ReadLine());
            if (so > 0)
            {
                Console.WriteLine("Can bac 2 la " + Math.Sqrt(so));
            }
            else
            {
                Console.WriteLine("Can bac 2 khong am");
            }
        }
        catch
        {
            Console.WriteLine("Loi ");
        }
    }
    private static void thue()
    {
        double luong, thuong, thue;
        Console.WriteLine("Nhap luong =");
        luong= double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap luong =");
        thuong = double.Parse(Console.ReadLine());
        double luongthuong = luong + thuong;
        if(luongthuong<9000000)
        {
            thue = 0; 
        }else if(luongthuong<15000000)
        {
            thue = 0.1 * luongthuong;
        }else if(luongthuong<30000000)
        {
            thue= 0.15 * luongthuong;
        }else
        {
            thue = 0.2 * luongthuong;
        }
        Console.WriteLine("Thue = {0}", thue);
    }
    private static void ngaydauthang(int ngay, int thang, int nam)
    {
        int ngaytruoc = 0;
        int ngaysau = 0;
        if(thang==1)
        Console.WriteLine("Ngay truoc: {0}/{1}/{2}", 31, 12, nam - 1);
        else
        {

        }
        Console.WriteLine("Ngay sau: {0}/{1}/{2}", ngay+1, thang, nam);
    }
    private static void ngaytruocsau(int ngay, int thang, int nam)
    {
        int ngaytruoc = ngay - 1;
        int ngaysau = ngay + 1;
        Console.WriteLine("Ngay truoc: {0}/{1}/{2}", ngaytruoc, thang, nam);
        Console.WriteLine("Ngay sau: {0}/{1}/{2}", ngaysau, thang, nam);
    }

    private static void ngaycuoithang(int ngay, int thang, int nam)
    {
        int ngaytruoc = ngay - 1;
        int ngaysau = 1;
        Console.WriteLine("Ngay truoc: {0}/{1}/{2}", ngaytruoc, thang, nam);
        if (thang == 12)
            Console.WriteLine("Ngay sau: {0}/{1}/{2}", ngaysau,1, nam+1);
        else
            Console.WriteLine("Ngay sau: {0}/{1}/{2}", ngaysau, thang + 1, nam);
    }

    private static void ngayofthang()
    {
        int ngay, thang, nam;
        Console.WriteLine("Nhap ngay: ");
        ngay = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thang: ");
        thang = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap nam: ");
        nam = int.Parse(Console.ReadLine());
        switch(thang)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            {
                    if(thang==1)
                    {
                        int ngaytruoc=0, ngaysau=0;
                        int thangtruoc = 0, thangsau = 0;
                        if (ngay == 1)
                        {
                            ngaydauthang(ngay, thang, nam);
                        }
                        else if (ngay == 31)
                        {
                            ngaycuoithang(ngay, thang, nam);
                        }
                        else
                        {
                            ngaytruocsau(ngay, thang,nam);
                        }

                        
                    }
                    Console.WriteLine("Thang co 31 ngay");
                    break;
            }
            case 4: case 6: case 9: case 11:
            {
                    Console.WriteLine("Thang co 30 ngay");
                    break;
            }
            case 2:
            {
                    break;
            }
            default:
            {
                    Console.WriteLine("Thang khong ton tai");
                    break;
            }
        }

    }
    private static void Main(string[] args)
    {
        // canbac2();
        //thue();
        ngayofthang();
    }
}