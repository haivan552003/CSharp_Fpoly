using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vanlthpc07042_Csharp2_ASM_GD2
{
    class baitap
    {
        //y1 Nhập danh sach xe

        public static void NhapLoaiXe()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();
            nhapLai:
            try
            {
                Console.WriteLine("Nhập số lượng MaLoaiXe: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhập MaLoaiXe: ");
                    String MaLoaiXe = Console.ReadLine();

                    Console.WriteLine("Nhập TenLoaiXe: ");
                    String TenLoaiXe = Console.ReadLine();
                    var NhapLoaiXe = new LOAIXE()
                    {
                        MaLoaiXe = MaLoaiXe,
                        TenLoaiXe = TenLoaiXe
                    };
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập sai dữ liệu đầu vào, nhập lại");
                goto nhapLai;
            }

            Console.WriteLine("Thông tin LOAIXE");
            foreach (var item in qlxHD.LOAIXEs.ToList())
            {
                Console.WriteLine("{0} - {1}", item.MaLoaiXe, item.TenLoaiXe);
            }
        }
        public static void NhapThongTinXe()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();
            nhapLai:
            try
            {
                Console.WriteLine("Nhập số lượng MaLoaiXe: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhập MaXe: ");
                    String MaXe = Console.ReadLine();

                    Console.Write("Nhập MaLoaiXe: ");
                    String MaLoaiXe = Console.ReadLine();

                    Console.Write("Nhập TenXe: ");
                    String TenXe = Console.ReadLine();

                    Console.Write("Nhập Gia: ");
                    float Gia = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập MauXe: ");
                    String MauXe = Console.ReadLine();

                    Console.Write("Nhập DongCo: ");
                    int DongCo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập KhoiLuong: ");
                    float KhoiLuong = Convert.ToInt32(Console.ReadLine());

                    var ThongTinXe = new THONGTINXE()
                    {
                        MaXe = MaXe,
                        MaLoaiXe = MaLoaiXe,
                        TenXe = TenXe,
                        Gia = Gia,
                        MauXe = MauXe,
                        DongCo = DongCo,
                        KhoiLuong = KhoiLuong,
                    };

                    qlxHD.THONGTINXEs.InsertOnSubmit(ThongTinXe);

                }
            }
            catch(Exception)
            {
                Console.WriteLine("Nhập sai dữ liệu đầu vào, nhập lại");
                goto nhapLai;

            }

            qlxHD.SubmitChanges();

            Console.WriteLine("Thông tin THONGTINXE");

            foreach (var item in qlxHD.THONGTINXEs.ToList())
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
            }
        }

        //y2 Xuat thong tin xe
        public static void XuatThongTinXe()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();

            var loaixe = qlxHD.LOAIXEs.ToList();
            var thongtin = qlxHD.THONGTINXEs.ToList();

            var xuatxe110_175 = from lx in loaixe
                         join tt in thongtin
                         on lx.MaLoaiXe equals tt.MaLoaiXe
                         where tt.DongCo >= 110 && tt.DongCo < 175
                         select new
                         {
                             lx.MaLoaiXe,
                             lx.TenLoaiXe,
                             tt.MaXe,
                             tt.TenXe,
                             tt.Gia,
                             tt.DongCo,
                             tt.MauXe,
                             tt.KhoiLuong
                         };

            var xuatxe175 = from lx in loaixe
                                join tt in thongtin
                                on lx.MaLoaiXe equals tt.MaLoaiXe
                                where tt.DongCo >= 175
                                select new
                                {
                                    lx.MaLoaiXe,
                                    lx.TenLoaiXe,
                                    tt.MaXe,
                                    tt.TenXe,
                                    tt.Gia,
                                    tt.DongCo,
                                    tt.MauXe,
                                    tt.KhoiLuong
                                };
            Console.WriteLine("Xe có phân khối từ 110cc đến 175cc");
            foreach (var item in xuatxe110_175)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}", item.TenLoaiXe, item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
            }

            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("Xe có phân khối trên 175cc");
            foreach (var item in xuatxe175)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}", item.TenLoaiXe, item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
            }
        }

        //y3 Tim kiem theo khoang gia
        public static void TimXeTheoGia()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();

            nhapMM:
            int count = 0;

            try
            {

                Console.WriteLine("Nhập giá nhỏ nhất: ");
                float giaMin = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nhập giá lớn nhất: ");
                float giaMax = Convert.ToInt32(Console.ReadLine());

                //hoan vi gia min max
                if (giaMin > giaMax)
                {
                    float temp = giaMin;
                    giaMin = giaMax;
                    giaMax = temp;
                }

                //lay khoang gia
                var TheoGia = from tt in qlxHD.THONGTINXEs.ToList()
                              where tt.Gia >= giaMin && tt.Gia <= giaMax
                              select tt;

                foreach (var item in TheoGia)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
                    count++;
                }

                if (count == 0)
                {
                    Console.WriteLine("Không có xe trong khoảng giá này");
                }
            }
            catch
            {
                goto nhapMM;
            }
        }

        //y4 Tim kiem theo Maxe va cap nhap thong tin
        public static void TimMaxe()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();

            int count = 0;
            Console.WriteLine("Nhập Maxe cần cập nhật: ");
            String MaXe = Console.ReadLine();

            //lay Maxe
            var TheoMaXe = qlxHD.THONGTINXEs
                           .Where(c => c.MaXe == MaXe);
                          
            foreach (var item in TheoMaXe)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("Không có Maxe này");
            }
            else
            {
                Console.WriteLine("Bạn có muốn cập nhật xe này không?\n1. Có\n2. Không");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    Console.WriteLine("Bạn chọn cập nhật");
                    Console.WriteLine("Không được cập nhật MaLoaiXe và MaXe");

                    var CapNhatThongTinXe = qlxHD.THONGTINXEs
                        .Where(c => c.MaXe == MaXe).FirstOrDefault();
                    
                    Console.Write("Nhập TenXe: ");
                    String TenXe = Console.ReadLine();
                    
                    Console.Write("Nhập Gia: ");
                    float Gia = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập MauXe: ");
                    String MauXe = Console.ReadLine();

                    Console.Write("Nhập DongCo: ");
                    int DongCo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập KhoiLuong: ");
                    float KhoiLuong = Convert.ToInt32(Console.ReadLine());

                    CapNhatThongTinXe.TenXe = TenXe;
                    CapNhatThongTinXe.DongCo = DongCo;
                    CapNhatThongTinXe.MauXe = MauXe;
                    CapNhatThongTinXe.Gia = Gia;
                    CapNhatThongTinXe.KhoiLuong = KhoiLuong;
                    qlxHD.SubmitChanges(); //khong cap nhat duoc khoa chinh

                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", CapNhatThongTinXe.MaLoaiXe, CapNhatThongTinXe.MaXe, CapNhatThongTinXe.TenXe, CapNhatThongTinXe.Gia, CapNhatThongTinXe.MauXe, CapNhatThongTinXe.DongCo, CapNhatThongTinXe.KhoiLuong);
                }
            }         
        }

        //y5 Xuat thong tin theo gia tu cao den thap
        public static void XuatGiamDan()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();

            foreach (var item in qlxHD.THONGTINXEs.OrderByDescending(x => x.Gia))
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
            }
        }

        //y6 xuat 5 xe co gia tien cao nhat
        public static void XuatTop5()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();

            foreach (var item in qlxHD.THONGTINXEs.OrderByDescending(x => x.Gia).Take(5))
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", item.MaLoaiXe, item.MaXe, item.TenXe, item.Gia, item.MauXe, item.DongCo, item.KhoiLuong);
            }
        }

        //y7 Trung binh gia xe
        public static void TrungBinhGia()
        {
            qlxHDDataContext qlxHD = new qlxHDDataContext();


            List<LOAIXE> ttXe = qlxHD.LOAIXEs.ToList<LOAIXE>();
            String fileData = "";
            foreach (var item in ttXe)
            {
                Double TBGiaXe = qlxHD.THONGTINXEs
                            .Where(x => x.MaLoaiXe == item.MaLoaiXe)
                            .ToList()
                            .Average(x => (double)x.Gia);
                Console.WriteLine(item.TenLoaiXe + " giá trung bình: " + Math.Round(TBGiaXe, 2) + "\n");
                fileData += item.TenLoaiXe + " giá trung bình: " + Math.Round(TBGiaXe, 2) + "\n";
            }
            String filePath = @"D:\TBGiaXe.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (TextWriter tw = File.CreateText(filePath))
            {
                tw.Write(fileData);
            }
        }

        public static void ThreadY7()
        {
            Console.WriteLine("Đang tính trung bình giá...");
            Thread y7 = new Thread(new ThreadStart(TrungBinhGia));
            y7.Start();
        }
    }
}
