using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab2_Bai1
{
    static class MyCollege
    {
        public static string CollegeName;
        public static string Address;

        static MyCollege()
        {
            CollegeName = "FPT Polytechnic";
            Address = "391A Nam Ky Khoi Nghia, Q.3, TP.HO CHI MINH";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();
        }
    }
}
