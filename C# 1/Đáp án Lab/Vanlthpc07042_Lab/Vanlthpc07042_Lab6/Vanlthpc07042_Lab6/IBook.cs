using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbManager;

namespace DbManager
{
    interface IBook
    {
        string tenSach { get; set; }
        string tenTG { get; set; }
        string nhaXuatBan { get; set; }
        int namXuatBan { get; set; }
        int ISBN { get; set; }
        string[] Chuong { get; set; }
    }
}
class Book: IBook, IComparable<Book> //da ke thua
{
    private string tensach;
    private string tentacgia;
    private string nhaxuatban;
    private int namxuatban;
    private int isbn { get; set; }
    private string[] chuong;

    public string tenSach { get => this.tensach; set => this.tensach = value; }
    public string tenTG { get => this.tentacgia; set => this.tentacgia = value; }
    public int namXuatBan { get => this.namxuatban; set => this.namxuatban = value; }
    public string[] Chuong { get => this.chuong; set => this.chuong = value; }
    public string nhaXuatBan { get => this.nhaxuatban; set => this.nhaxuatban = value; }
    public int ISBN { get => this.isbn; set => this.isbn = value; }

    public int CompareTo(Book? other)
    {
        /* return this.tenSach.CompareTo(other.tenSach);*/
        if (this.namXuatBan < other.namXuatBan)
            return 1;
        else
            return -1;
    }
}
class SapXepTheoTen : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        string tensach1 = x.tenSach;
        string tensach2 = y.tenSach;
        int n;
        int flag = 0;
        if (tensach1.Length > tensach2.Length)
            n = tensach2.Length;
        else
            n = tensach1.Length;
        for(int i = 0; i < n; i++)
        {
            if (tensach1[i] > tensach2[i])
            {
                flag = 1;
                break;
            }  
            else if (tensach1[i] < tensach2[i])
            {
                flag = -1;
                break;
            }
        }
        if (flag == 0)
        {
            if (tensach1.Length == n)
                flag = -1;
            else
                flag = 1;
        }
        return flag;
    }
}
class BookList
{
    public List<Book> Books = new List<Book>();
    public void Nhap()
    {
        Console.WriteLine("Nhap so luong sach: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            {
                Console.WriteLine("Nhap quyen sach thu " + i);
                Book sach = new Book();
                Console.WriteLine("Nhap ten sach: ");
                sach.tenSach = Console.ReadLine();
                Console.WriteLine("Nhap ten tac gia: ");
                sach.tenTG = Console.ReadLine();
                Console.WriteLine("Nhap nha xuat ban: ");
                sach.nhaXuatBan = Console.ReadLine();
                Console.WriteLine("Nhap nam xuat ban: ");
                sach.namXuatBan = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so hieu ISBN: ");
                sach.ISBN = Convert.ToInt32(Console.ReadLine());
                Books.Add(sach);
            }
        }
    }
    public void Xuat()
    {
        foreach(Book sach in Books)
        {
            Console.WriteLine("Ten sach: " + sach.tenSach);
            Console.WriteLine("Tac gia: " + sach.tenTG);
            Console.WriteLine("Nam xuat ban: " + sach.namXuatBan);
        }
    }
    public void SapXep()
    {
        Books.Sort(new SapXepTheoTen());
    }
}