using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_ASM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        ChonLaiChucNang:
            int n, choose;
            int count = 0;
            double tong = 0;
            double DTB;
            Console.WriteLine("\t\tMENU CHUONG TRINH");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. Dùng LinQ to SQL nhập danh sách xe");
            Console.WriteLine(".....................................................");
            Console.WriteLine("2. Xuất danh sách xe");
            Console.WriteLine(".....................................................");
            Console.WriteLine("3. Tìm kiếm thông tin xe theo khoảng giá");
            Console.WriteLine(".....................................................");
            Console.WriteLine("4. Tìm kiếm xe theo MaXe và cập nhập thông tin");
            Console.WriteLine(".....................................................");
            Console.WriteLine("5. Xuất thông tin xe theo giá từ cao đến thấp");
            Console.WriteLine(".....................................................");
            Console.WriteLine("6. Xuất 5 xe có giá tiền cao nhất");
            Console.WriteLine(".....................................................");
            Console.WriteLine("7. Tạo Thread tính giá xe trung bình");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Chọn chức năng");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                y1:
                    Console.WriteLine(" Dùng LinQ to SQL");
                    Console.WriteLine(".....................................................");
                    Console.WriteLine("1. Nhập danh sách mã loại xe");
                    Console.WriteLine("2. Nhập danh sách xe: MaLoaiXe, TenXe, Gia, MauXe, DongCo, KhoiLuong");
                    Console.WriteLine(".....................................................");
                    Console.WriteLine("Chọn chức năng");
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            //ham nhap ma xe
                            y11();
                            break;
                        case 2:
                            //ham nhap xe
                            y12();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Khong co chuc nang");
                            goto y1;
                            break;

                            try
                            {
                                Console.WriteLine("Bam '1' de tiep tuc chuong trinh");
                                choose = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e) { }

                            if (choose == 1)
                            {
                                Console.Clear();
                                goto y1;
                            }
                    }
                    break;
                case 2:
                    //ham xuat danh sach xe
                    y2();
                    break;
                case 3:
                    //ham tim xe theo khoang gia
                    y3();
                    break;
                case 4:
                    //ham tim khiem va cap nhap theo ma xe
                    y4();
                    break;
                case 5:
                    //xuat thong tin theo gia tu cao den thap
                    y5();
                    break;
                case 6:
                    //xuat 5 xe co gia tien cao nhat
                    y6();
                    break;
                case 7:
                    //thread
                    y7();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Khong co chuc nang");
                    goto ChonLaiChucNang;
                    break;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            try
            {
                Console.WriteLine("Bam '1' de tiep tuc chuong trinh");
                choose = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) { }

            if (choose == 1)
            {
                Console.Clear();
                goto ChonLaiChucNang;
            }
        }


        //y1 
        static void y11()
        {
            Console.WriteLine("Nhập danh sách mã loại xe");
        }

        
        static void y12()
        {
            Console.WriteLine("Nhập danh sách xe: MaLoaiXe, TenXe, Gia, MauXe, DongCo, KhoiLuong");
        }

        //y2
        static void y2()
        {
            Console.WriteLine("Xuất danh sách xe");
        }

        //y3
        static void y3()
        {
            Console.WriteLine("Tìm kiếm thông tin xe theo khoảng giá");
        }

        //y4
        static void y4()
        {
            Console.WriteLine("Tìm kiếm xe theo MaXe và cập nhập thông tin");
        }

        //y5
        static void y5()
        {
            Console.WriteLine("Xuất thông tin xe theo giá từ cao đến thấp");
        }

        //y6
        static void y6()
        {
            Console.WriteLine("Xuất 5 xe có giá tiền cao nhất");
        }

        //y7
        static void y7()
        {
            Console.WriteLine("Tạo Thread tính giá xe trung bình");
        }
    }
}
