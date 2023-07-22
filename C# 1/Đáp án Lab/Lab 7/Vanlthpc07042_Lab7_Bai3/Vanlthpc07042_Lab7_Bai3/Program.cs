using System.Xml.Linq;
using Vanlthpc07042_Lab7_Bai3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> st = new List<Student>();
        Console.WriteLine("Nhap so luong sinh vien:"); 
        int n = int.Parse(Console.ReadLine());
       

        for(int i = 0; i < n; i++)
        {
            st.Add(new Student());
            Student
        }
        //for (int i = 0; i < n; i++)
        //{
        //name:
        //    Console.WriteLine("Nhap ten: ");
        //    string ten = Console.ReadLine();
        //    if (st.Count == 0)
        //    {
        //        st.Add(new Student(ten));
        //    }
        //    else
        //    {
        //        bool flag = false;
        //        foreach (Student x in st)
        //        {
        //            if (x.hoTen.Equals(ten))
        //            {
        //                flag = true;
        //            }
        //        }
        //        if (flag)
        //        {
        //            Console.WriteLine("Ten bi trung");
        //            goto name;
        //        }
        //        else
        //        {
        //            st.Add(new Student(ten));
        //        }
        //    }
        //    st.Add
        //}
    }
}