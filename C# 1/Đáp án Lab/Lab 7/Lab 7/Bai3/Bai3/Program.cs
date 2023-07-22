using Bai3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Console.WriteLine("Nhap so luong sv: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            nhapten: Console.WriteLine("Nhap ten");
               string name = Console.ReadLine();
            if (students.Count == 0)
            {
                students.Add(new Student(name));
            }
            else
            {
                bool flag = false;
                foreach (Student st in students)
                {
                    if (st.hoten.Equals(name))
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        Console.WriteLine("Ten bi trung !");
                        goto nhapten;
                    }
                    else
                    {
                        students.Add(new Student(name));
                    }
                }
            }
        }
    }
}