using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab6
{
    //bai1
    class bai1
    {
        public static void Bai1()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 202, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("So chan dau tien trong IList: {0}", intList.First(i => i % 2 == 0));
            Console.WriteLine("Phan tu cuoi cung > 200 trong IList: {0}", intList.Last(i => i > 200));
            Console.WriteLine("Phan tu dau tien trong IList co ky tu bat dau bang 'T': {0}", strList.Skip(1).FirstOrDefault(s => s.Contains("T")));
            Console.WriteLine("Tong gia tri vi tri index le trong Ilist: {0}", intList.Where((value, index) => index % 2 != 0).Sum());
        }
    }

    //bai 2
    class bai2
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int StandardID { get; set; }
        }
        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }

        public static void Bai2()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student()
                {
                    StudentID = 1,
                    StudentName = "Hai",
                    StandardID = 1,
                },
                new Student()
                {
                    StudentID = 2,
                    StudentName = "Van",
                    StandardID = 1,
                },
                new Student()
                {
                    StudentID = 3,
                    StudentName = "Minh",
                    StandardID = 2,
                },
                new Student()
                {
                    StudentID = 4,
                    StudentName = "Phuoc",
                    StandardID = 2,
                },
                new Student()
                {
                    StudentID = 5,
                    StudentName = "Dat",
                },
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard()
                {
                    StandardID = 1,
                    StandardName = "Standard 1"
                },
                new Standard()
                {
                    StandardID = 2,
                    StandardName = "Standard 2"
                },
                new Standard()
                {
                    StandardID = 3,
                    StandardName = "Standard 3"
                },
            };

            //a
            Console.WriteLine("\nBai 2a");
            var innerjoin = studentList.Join(
                            standardList,
                            stu => stu.StudentID,
                            sta => sta.StandardID,
                            (stu, sta) => new
                            {
                                StudentName = stu.StudentName,
                                StandardName = sta.StandardName
                            }
                );
            foreach (var item in innerjoin)
            {
                Console.WriteLine("{0} - {1}", item.StudentName, item.StandardName);
            }

            //b
            Console.WriteLine("\nBai 2b");
            var groupjoin = from stu in studentList
                            join sta in standardList
                            on stu.StudentID equals sta.StandardID
                            into StuSta
                            from ss in StuSta.DefaultIfEmpty()
                            select new
                            {
                                StudentName = stu.StudentName,
                                StandardName = ss == null ? "No Sandard" : ss.StandardName
                            };
            foreach (var item in groupjoin)
            {
                Console.WriteLine("{0}: {1},", item.StandardName, item.StudentName);
            };
        }
    }
    //bai 3
    class bai3
    {
        public static void Bai3()
        {
            int[] little = { 0, 1, 2, 3, 4, 5, 6 };
            int[] big = { 5, 6, 7, 8, 9, 10 };

            //a
            Console.WriteLine("\nBai 3a");
            var union = (from num in little
                         select num).Union(big).ToList();

            foreach (var item in union)
            {
                Console.Write(item + " ");
            }
            //b
            Console.WriteLine("\n\nBai 3b");
            var intersect = (from num in little
                            select num).Intersect(big).ToList();

            foreach (var item in intersect)
            {
                Console.Write(item + " ");
            }

            //c
            Console.WriteLine("\n\nBai 3c");
            var concat = (from num in little
                             select num).Concat(big).ToList();

            foreach (var item in concat)
            {
                Console.Write(item + " ");
            }

            //d
            Console.WriteLine("\n\nBai 3d");
            var except = little.Except(big);
            foreach (var item in except)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
