using System.Collections;
internal class Program
{
    private static void VD1()
    {
        int i, n;
        Console.Write("Nhap so phan tu cua mang: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] soNguyen = new int[n];
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu " + i + ": ");
            soNguyen[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Mang vua nhap la:");
        //foreach
        foreach (int x in soNguyen)
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
        foreach (string x in name)
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
        for (i = 0; i < n; i++)
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
        foreach (string x in name)
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
        for (i = 0; i < n; i++)
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
        for (int i = 0; i < nganhHoc.Length; i++)
        {
            int n;
            Console.WriteLine("Nhap so luong mon cua " + nganhHoc[i]);
            n = Convert.ToInt32(Console.ReadLine());
            monhoc[i] = new string[n]; //khai bao so luong phan tu trong hang

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Nhap ten mon cua " + j + ": ");
                monhoc[i][j] = Console.ReadLine();
            }
        }
        Console.WriteLine("Cac mon hoc vua nhap la");
        for (int i = 0; i < monhoc.Length; i++)
        {
            Console.WriteLine("Mon cua nghanh " + nganhHoc[i]);
            for (int j = 0; j < monhoc[i].Length; j++)
            {
                Console.WriteLine(monhoc[i][j]);
            }
        }
    }
    private static void Bai1()
    {
        int i, j, n;
        int count = 0;
        float result = 0;
        int temp;
        Console.Write("Nhap so phan tu mang thong thuong: ");
        n = Convert.ToInt32(Console.ReadLine());

        //thong thuong
        int[] array1 = new int[n];
        Console.WriteLine("Nhap mang array1");
        for (i = 0; i < n; i++)
        {
            Console.Write("array1[" + i + "]: ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        //ArrayList
        Console.Write("Nhap so phan tu ArrayList: ");
        int m = Convert.ToInt32(Console.ReadLine());
        ArrayList array2 = new ArrayList();
        Console.WriteLine("Nhap mang array2");
        for (i = 0; i < m; i++)
        {
            Console.Write("array1[" + i + "]: ");
            array2.Add(int.Parse(Console.ReadLine()));

        }
        //sap xep va xuat mang
        Console.WriteLine("________________________\nMang vua nhap la");
        Console.WriteLine("Mang array 1\n");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("array1[" + i + "]: " + array1[i]);
        }
        Console.WriteLine(".......................");
        Console.WriteLine("Mang array 2\n");
        for (i = 0; i < m; i++)
        {
            Console.WriteLine("array2[" + i + "]: " + array2[i]);
        }
        Console.WriteLine("________________________\nSap xep tang dan");
        Console.WriteLine("Mang array 1\n");
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (array1[i] > array1[j])
                {
                    temp = array1[i];
                    array1[i] = array1[j];
                    array1[j] = temp;
                }
            }
        }
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("array1[" + i + "]: " + array1[i]);
        }
        Console.WriteLine(".......................");
        Console.WriteLine("Mang array 2\n");
        array2.Sort();
        for (i = 0; i < m; i++)
        {
            Console.WriteLine("array2[" + i + "]: " + array2[i]);
        }
        //tim min
        Console.WriteLine("________________________\nGia tri nho nhat trong mang");
        int min = array1[0];
        for (i = 0; i < n; i++)
        {
            if (array1[i] < min)
            {
                min = array1[i];
            }
        }

        Console.WriteLine("Ket qua array 1: " + min);

        min = int.Parse(array2[0].ToString());
        for (i = 0; i < m; i++)
        {
            if (int.Parse(array2[0].ToString()) < min)
            {
                min = int.Parse(array2[i].ToString());
            }
        }

        Console.WriteLine(".......................");
        Console.WriteLine("Ket qua array 2: " + min);
        //trung binh cong cac phan tu chia het cho 3
        Console.WriteLine("________________________\nTrung binh cong cac phan tu chia het cho 3");
        for (i = 0; i < n; i++)
        {
            if (array1[i] % 3 == 0)
            {
                result += array1[i];
                count++;
            }
        }

        Console.WriteLine("Ket qua array 1: " + result / count);
        for (i = 0; i < m; i++)
        {
            if (int.Parse(array2[i].ToString()) % 3 == 0)
            {
                result += int.Parse(array2[i].ToString());
                count++;
            }
        }

        Console.WriteLine(".......................");
        Console.WriteLine("Ket qua array 2: " + result / count);
    }
    private static void Bai2()
    {
        Console.WriteLine("Hoc luc sinh vien");
        int i, n;
        Console.Write("Nhap so luong sinh vien: ");
        n = Convert.ToInt32(Console.ReadLine());
        string[] name = new string[n];
        double[] point = new double[n];
        for (i = 0; i < n; i++)
        {
            Console.Write("Nhap ten sinh vien thu 0" + i + ": ");
            name[i] = Console.ReadLine();
            Console.Write("Nhap diem: ");
            point[i] = Convert.ToDouble(Console.ReadLine());

        }

        //xap xep
        double temp;
        int j;
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
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
        for (i = 0; i < n; i++)
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
    private static void Main(string[] args)
    {
        Repeat:
        Console.WriteLine("MENU");
        Console.WriteLine("1. Vi du 1");
        Console.WriteLine("2. Vi du 2");
        Console.WriteLine("3. Vi du 3");
        Console.WriteLine("4. Vi du 4");
        Console.WriteLine("5. Bai 1");
        Console.WriteLine("6. Bai 2");
        Console.WriteLine("Chon chuc nang: ");
        int choose = int.Parse(Console.ReadLine());
        switch(choose)
        {
            case 1:
                Console.WriteLine("Vi du 1");
                VD1();
                break;
            case 2:
                Console.WriteLine("Vi du 2");
                VD2();
                break;
            case 3:
                Console.WriteLine("Vi du 3");
                VD3();
                break;
            case 4:
                Console.WriteLine("Vi du 4");
                VD4();
                break;
            case 5:
                Console.WriteLine("Bai 1");
                Bai1();
                break;
            case 6:
                Console.WriteLine("Bai 2");
                Bai2();
                break;
            default:
                Console.WriteLine("Khong co chuc nang");
                Console.Clear();
                Console.WriteLine("Vui long chon lai chuc nang");
                Console.WriteLine("-----------------------------");
                goto Repeat;
                break;
        }
        Console.WriteLine("Ban muon tiep tuc chuong trinh khong?\n 1 = Co");
        choose = int.Parse(Console.ReadLine());
        if(choose == 1)
        {
            Console.Clear();
            goto Repeat;
        }
    }
}