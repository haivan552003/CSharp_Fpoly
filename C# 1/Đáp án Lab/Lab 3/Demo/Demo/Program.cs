using System.Collections;

internal class Program
{
    private static void VD1()
    {
        int i, n;
        Console.Write("Nhap so phan tu cua mang: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] soNguyen = new int[n];
        for(i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu " + i + ": ");
            soNguyen[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Mang vua nhap la:"); 
        //foreach
        foreach(int x in soNguyen)
        {
            Console.WriteLine("Mang {0}: {1}", i, x);
        }
        Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Lap phuong cac phan tu"); 
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Mang " + i + ": " + Math.Pow(soNguyen[i], 3));
        }
        Console.WriteLine("-------------------------------------------");
    }
    private static void VD2()
    {
        int i, n, j;
        Console.Write("Nhap so sinh vien: ");
        n = Convert.ToInt32(Console.ReadLine());
        string[] name = new string[n];
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Ho ten " + i + ": ");
            name[i] = Console.ReadLine();
        }
        Console.WriteLine("Sinh vien da nhap");
        foreach(string x in name)
        {
            Console.WriteLine("Ho ten: " + x);
        }
        //sap xep
        Console.WriteLine("Chuoi sau khi sap xep");
        Array.Sort(name);
        foreach (string x in name)
        {
            Console.WriteLine("Ho ten: " + x);
        }
        Console.WriteLine("--------------------------");
        for(i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (String.Compare(name[i], name[j]) == 0)
                {
                    string temp = name[i];
                    name[i] = name[j];
                    name[j] = temp;
                }
            }
        }
        foreach(string x in name)
        {
            Console.WriteLine("Ho ten: " + x);
        }
    }
    private static void VD3()
        //arraylist nhap chuoi hay so dieu duoc
    {
        int count = 0;
        ArrayList a1 = new ArrayList();
        int i, n;
        Console.Write("Nhap so phan tu cua mang: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu " + i + ": ");
            a1.Add(Console.ReadLine());
        }
        Console.WriteLine("Mang vua nhap la");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("a1 " + i + ": " + a1[i]);
        }
        //dem so chan
        for (i = 0; i < n; i++)
        {
            if (int.Parse(a1[i].ToString()) % 2 == 0)
            {
                count++;
                a1.RemoveAt(i);
                n--;
            }
        }
        Console.WriteLine("--------------------------");
        /*
         * foreach (int i in a1)
        {
            if(i % 2 == 0)
            {
                count++;
                a1.RemoveAt();
            }
        }
         */
        Console.WriteLine("Co " + count + " so chan");
        Console.WriteLine("Xoa so chia het cho 2");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("a1 " + i + ": " + a1[i]);
        }
    }
    private static void VD4()
    {
        string[] nganhHoc = { "CNTT", "Kinh te", "QTKD" };
        string[][] monhoc = new string[3][];
        for(int i = 0; i < nganhHoc.Length; i++)
        {
            int n;
            Console.WriteLine("Nhap so luong mon cua " + nganhHoc[i]);
            n = Convert.ToInt32(Console.ReadLine());
            monhoc[i] = new string[n]; //khai bao so luong phan tu trong hang
            
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine("Nhap ten mon cua " + j + ": ");
                monhoc[i][j] = Console.ReadLine();
            }
        }
        Console.WriteLine("Cac mon hoc vua nhap la");
        for(int i = 0; i < monhoc.Length; i++)
        {
            Console.WriteLine("Mon cua nghanh " + nganhHoc[i]);
            for(int j = 0; j < monhoc[i].Length; j++)
            {
                Console.WriteLine(monhoc[i][j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        VD4();
    }
}