using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab3
{
    //bai 1 a
    class bai1a
    {
        public static void Bai1a()
        {
            try
            {
                string file = @"D:\example.txt";

                FileStream fs = new FileStream(file, FileMode.Create);
                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                fs.Write(bdata, 0, bdata.Length);
                Console.WriteLine("Data Added");
                fs.Close();

                string data;

                FileStream fsread = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fsread))
                {
                    data = sr.ReadToEnd();
                }
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
    //bai 1 b
    class bai1b
    {
        public static void Bai1b()
        {
            string file = @"D:\example.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Successfully Added Current Date And Time");
            }

            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine("Reading Current Time: ");
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }

    //bai 1 c
    class bai1c
    {
        public static void Bai1c()
        {
            string file = @"D:\example.txt";

            using (TextWriter writer = File.CreateText(file))
            {
                writer.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Successfully Added Current Date And Time");
            }

            using (TextReader reader = File.OpenText(file))
            {
                Console.WriteLine("Reading Current Time: ");
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }

    //bai 2 
    class bai2
    {
        //tao thu muc
        public static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("D:\\example");
            try
            {
                if (dir.Exists)
                {
                    Console.WriteLine("Directonary Already Exists");
                    Console.WriteLine("Directory Name: " + dir.Name);
                    Console.WriteLine("Path: " + dir.FullName);
                    Console.WriteLine("Directory is Create on: " + dir.CreationTime);
                    Console.WriteLine("Directory is Last Accessed on: " + dir.LastAccessTime);
                }
                else
                {
                    dir.Create();
                    Console.WriteLine("Directory Create Successfully. Information of Directory");
                    Console.WriteLine("Directory Name: " + dir.Name);
                    Console.WriteLine("Directory is Create on: " + dir.CreationTime);
                    Console.WriteLine("Directory is Last Accessed on: " + dir.LastAccessTime);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine(d.Message.ToString());
            }
        }

        //tao file
        public static void CreateFile()
        {
            FileInfo file = new FileInfo("D:\\example\\test.txt");
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("Le Thi Hai Van - PC07042");
            }

            Console.WriteLine("\n\n*****Display File Info*****");
            Console.WriteLine("File Create on: " + file.CreationTime);
            Console.WriteLine("Directory Name: " + file.DirectoryName);
            Console.WriteLine("Full Name of File: " + file.FullName);
            Console.WriteLine("File is Accessed on: " + file.LastAccessTime);
        }
    }

}
