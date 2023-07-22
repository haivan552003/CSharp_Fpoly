using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab3_Bai1
{
    class Program
    {
        static void Main(string[] args)
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
            for(i = 0; i < n; i++)
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
                    if(array1[i] > array1[j])
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
                if(array1[i] < min)
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
                if(array1[i] % 3 == 0)
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
            
                Console.ReadKey();
        }
    }
}
