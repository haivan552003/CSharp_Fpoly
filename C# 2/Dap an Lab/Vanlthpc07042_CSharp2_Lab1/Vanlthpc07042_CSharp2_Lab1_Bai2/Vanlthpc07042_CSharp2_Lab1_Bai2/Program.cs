using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab1_Bai2
{
    class Student
    {
        public string StudentName;
        public static string Course;
        public static string CollegeName = "FPT Polytechnic";
        public static string CollegeAddress = "391A Nam Ky Khoi Nghia, Q.3, TP.HO CHI MINH";


        public void SetStudentDetails(string StuName, string Cou)
        {
            StudentName = StuName;
            Course = Cou;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
        }

        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student.DisplayCollegeDetails();

            Console.WriteLine();
            Student s1 = new Student();
            Student s2 = new Student();

            s1.SetStudentDetails("Thepv", "Phd");
            s2.SetStudentDetails("Nghiemn", "MBA");
            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            Console.Read();
        }
    }
}
