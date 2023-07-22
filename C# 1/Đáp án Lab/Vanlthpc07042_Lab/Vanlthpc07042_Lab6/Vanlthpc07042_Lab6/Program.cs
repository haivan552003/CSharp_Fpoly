using DbManager;

internal class Program
{
    private static void Main(string[] args)
    {
        BookList ds = new BookList();
        Console.WriteLine("MENU");
        Console.WriteLine("1.Bai 1");
        Console.WriteLine("2.Bai 2");
        Console.WriteLine("Chon chuc nang");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                ds.Nhap();
                Console.WriteLine("_________________");
                ds.Xuat();
                Console.WriteLine("_________________");
                Console.WriteLine("Danh sach sau khi sap xep");
                ds.SapXep();
                ds.Xuat();
                break;
            case 2:
                DbAction db1 = new Product();
                DbAction db2 = new Order();

                db1.Insert();
                db1.Update();
                db1.Delete();
                db1.Select();

                db2.Insert();
                db2.Update();
                db2.Delete();
                db2.Select();
                break;
            default:
                Console.WriteLine("Khong co chuc nang");
                Console.Clear();
                break;
        }
    }
}