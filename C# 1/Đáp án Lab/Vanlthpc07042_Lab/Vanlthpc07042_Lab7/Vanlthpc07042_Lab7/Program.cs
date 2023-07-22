using Vanlthpc07042_Lab7;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Bai 1");
        Console.WriteLine("2. Bai 3");
        Console.WriteLine("Chon chuc nang");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                TinhToan tt = new TinhToan();
                Toan toan = tt.tong;
                toan += tt.hieu;
                toan += tt.Tich;
                toan += tt.Thuong;
                toan(90, 10);
                break;
            case 2:
                List<Student> students = new List<Student>();
                Console.WriteLine("Nhap so luong sv: ");
                n = int.Parse(Console.ReadLine());
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
                break;
            default:
                break;
        }
    }
}