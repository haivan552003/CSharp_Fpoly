using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vanlthpc07042_Csharp2_ASM_GD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        ChonLaiChucNang:
            int choose;
            Console.WriteLine("\t\tMENU CHUONG TRINH");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. Dùng LinQ to SQL nhập danh sách xe");
            Console.WriteLine(".....................................................");
            Console.WriteLine("2. Xuất danh sách xe theo phân khối");
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
            try
            {
                choose = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                goto ChonLaiChucNang;
            }

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
                    try
                    {
                        choose = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        goto y1;
                    }

                    switch (choose)
                    {
                        case 1:
                            //ham nhap ma xe
                            baitap.NhapLoaiXe();
                            break;
                        case 2:
                            //ham nhap xe
                            baitap.NhapThongTinXe();
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
                    baitap.XuatThongTinXe();
                    break;
                case 3:
                    //ham tim xe theo khoang gia
                    baitap.TimXeTheoGia();
                    break;
                case 4:
                    //ham tim khiem va cap nhap theo ma xe
                    baitap.TimMaxe();
                    break;
                case 5:
                    //xuat thong tin theo gia tu cao den thap
                    baitap.XuatGiamDan();
                    break;
                case 6:
                    //xuat 5 xe co gia tien cao nhat
                    baitap.XuatTop5();
                    break;
                case 7:
                    //thread
                    baitap.ThreadY7();
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
            Console.ReadLine();
        }
    }
}
