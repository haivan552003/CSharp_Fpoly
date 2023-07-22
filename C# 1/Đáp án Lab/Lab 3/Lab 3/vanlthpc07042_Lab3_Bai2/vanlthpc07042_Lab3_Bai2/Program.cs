using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hoc luc sinh vien");
        int i, n;
        Console.Write("Nhap so luong sinh vien: ");
        n = Convert.ToInt32(Console.ReadLine());
        string[] name = new string[n];
        double[] point = new double[n];
        for(i = 0; i < n; i++)
        {
            Console.Write("Nhap ten sinh vien thu 0" + i + ": ");
            name[i] = Console.ReadLine();
            Console.Write("Nhap diem: ");
            point[i] = Convert.ToDouble(Console.ReadLine());
            
        }
        
        //xap xep
        double temp;
        int j;
        for(i = 0; i < n; i++)
        {
            for(j = i + 1; j < n; j++)
            {
                if (point[i] > point[j])
                {
                    temp = point[i];
                    point[i] = point[j];
                    point[j] = temp;
                }
            }
        }
        Console.WriteLine("___________________________________\nTHONG TIN SINH VIEN");
        for(i = 0; i < n; i++)
        {
            Console.WriteLine("Ho ten: " + name[i].ToUpper());
            Console.WriteLine("Diem: " + point[i]);
            //xet hoc luc
            if (point[i] > 0 && point[i] < 5)
            {
                Console.WriteLine("Hoc luc: Yeu");
            }
            else if (point[i] >= 5 && point[i] < 6.5)
            {
                Console.WriteLine("Hoc luc: Trung binh");
            }
            else if (point[i] >= 6.5 && point[i] < 7.5)
            {
                Console.WriteLine("Hoc luc: Kha");
            }
            else if (point[i] >= 7.5 && point[i] < 9)
            {
                Console.WriteLine("Hoc luc: Gioi");
            }
            else if (point[i] >= 9 && point[i] <= 10)
            {
                Console.WriteLine("Hoc luc: Xuat sac");
            }
            Console.WriteLine("...........................");
        }
        Console.ReadKey();
    }
        */
        ArrayList sinhVien = new ArrayList();
        int n;
        Console.WriteLine("Hoc luc sinh vien");
        Console.WriteLine("Nhap so phan tu cua mang");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thong tin sinh vien");
        int i;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap ten sinh vien thu 0" + i + ": ");
            sinhVien.Add(Console.ReadLine());
            for(int j = 0; j < 1; j++)
            {
                Console.WriteLine("Nhap diem:");
                sinhVien.Add(Console.ReadLine());
            }
           
        }
        Console.WriteLine("THONG TIN SINH VIEN");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap ten sinh vien thu 0" + i + ": " + sinhVien[i]);
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("Nhap diem:" + sinhVien[j]);
               
            }
        }
    }
}