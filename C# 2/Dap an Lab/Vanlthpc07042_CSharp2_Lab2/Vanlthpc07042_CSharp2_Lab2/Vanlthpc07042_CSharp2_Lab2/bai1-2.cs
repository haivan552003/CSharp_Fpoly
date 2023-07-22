using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab2
{
    //bai 1 a
    public class ImplicitlyVariable
    {
        //var imp = 15;
        static public void bai1a()
        {
            var imp = 15;
            Console.WriteLine(imp);
        }
    }

    //bai 1 b
    class bai1b
    {

        static public void Bai1b()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("cat", 2);
            data.Add("dog", 1);
            Console.WriteLine("cat - dog = {0}", data["cat"] - data["dog"]);
        }
    }

    //bai 1 c
    class bai1c
    {
        static public void Bai1c()
        {
            GetDetail(100);
            GetDetail("Welcome to FPoly");
            GetDetail(true);
            GetDetail(20.50);
        }
        static void GetDetail(dynamic d)
        {
            Console.WriteLine(d);
        }
    }

    //bai 1 d
    class bai1d
    {
        static public void Bai1d()
        {
            var dobj = new User();
            dobj.GetDetail("Hai Van");
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void GetDetail(dynamic d)
        {
            Console.WriteLine(d);
        }
    }

    //bai 2 a
    class bai2a
    {
        public static void Bai2a()
        {
            var UserInfo = new
            {
                Id = 1,
                Name = "Hai Van",
                IsActive = true
            };

            Console.WriteLine("Id: " + UserInfo.Id);
            Console.WriteLine("Name: " + UserInfo.Name);
            Console.WriteLine("IsActive: " + UserInfo.IsActive);
        }

    }

    //bai 2 b
    class bai2b
    {
        public static void Bai2b()
        {
            var user = new
            {
                Id = 1,
                Name = "Hai Van",
                IsActive = true,
                jobInfo = new { Designation = "Lead", Location = "Hyderabad" }
            };

            Console.WriteLine("Id: " + user.Id);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("IsActive: " + user.IsActive);
            Console.WriteLine("Designation: {0}, Location: {1}", user.jobInfo.Designation, user.jobInfo.Location);
        }
    }

    class bai2c
    {
        public delegate void MathOps(int a);
        public static void Bai2c()
        {
            int y = 10;
            MathOps ops = delegate (int x)
            {
                Console.WriteLine("Add Results: {0}", x + y);
                Console.WriteLine("Subtract Resualt: {0}", x - y);
            };

            ops(90);
        }
    }
}
