using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanlthpc07042_Lab2_Bai3
{
    class Program
    {
        //ngay thuong
        private static void DDMMYY(int day, int month, int year)
        {
            int yesterday = day - 1;
            int tomorrow = day + 1;
            Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
            Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
        }
        //ngay cuoi thang khong tinh thang 2
        private static void DayofNextMonth(int day, int month, int year)
        {
            int yesterday = day - 1;
            int nextMonth = month + 1;
            int nextYear = year + 1;
            Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
            if (month != 12)
            {
                Console.WriteLine("Ngay sau: 1/{0}/{1}", nextMonth, year);
            }
            else
            {
                Console.WriteLine("Ngay sau: 1/1/" + nextYear);
            }
        }
        //cuoi thang 2
        private static void Feb_DayofMonth(int day, int month, int year)
        {
            int yesterday = day - 1;
            int tomorrow = day + 1;
            if(day == 1)
            {
                Console.WriteLine("Ngay truoc: {0}/{1}/{2}", 31, 1, year);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
            }
            else
            {
                Console.WriteLine("Ngay truoc: {0}/{1}/{2}", yesterday, month, year);
                Console.WriteLine("Ngay sau: {0}/{1}/{2}", 1, month + 1, year);
            }
        }
        //ngay dau thang
        private static void DayofLastMonth(int day, int month, int year)
        {
            int tomorrow = day + 1;
            int lastYear = year - 1;
            if(month == 1 || month == 3 || month == 5 ||month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (month != 1)
                {
                    Console.WriteLine("Ngay truoc: 30/{0}/{1}", month - 1, year);
                    Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
                }
                else
                {
                    Console.WriteLine("Ngay truoc: 31/12/" + lastYear);
                    Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
                }
            }
            else
            {
                if (month != 1)
                {
                    Console.WriteLine("Ngay truoc: 31/{0}/{1}", month - 1, year);
                    Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
                }
                else
                {
                    Console.WriteLine("Ngay truoc: 31/12/" + lastYear);
                    Console.WriteLine("Ngay sau: {0}/{1}/{2}", tomorrow, month, year);
                }
            }
           
        }
        //ham chinh
        private static void DayofMonth()
        {
            Console.WriteLine("Chuong trinh Ngay, thang, nam");
            int day, month, year;
            do
            {
                Console.Write("Nhap ngay hom nay: ");
                day = Convert.ToInt32(Console.ReadLine());
            } while (day < 1 || day > 31);

            Console.Write("Nhap thang hom nay: ");
            month = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap nam hom nay: ");
                year = Convert.ToInt32(Console.ReadLine());
            } while (year < 0);
            Console.WriteLine("\nHom nay la ngay {0} thang {1} nam {2}\n", day, month, year);
            //kiem tra thang co bao nhieu ngay                    
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if(day == 1)
                        {
                            DayofLastMonth(day, month, year);
                        }
                        else if(day == 31)
                        {
                            DayofNextMonth(day, month, year);
                        }
                        else
                        {
                            DDMMYY(day, month, year);
                        }
                        Console.WriteLine("Thang co 31 ngay");
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (day == 1)
                        {
                            DayofLastMonth(day, month, year);
                        }
                        else if (day == 30)
                        {
                            DayofNextMonth(day, month, year);
                        }
                        else
                        {
                            DDMMYY(day, month, year);
                        }
                        Console.WriteLine("Thang co 30 ngay");
                        break;
                    }
                case 2:
                    {
                        //kiem tra nam nhuan
                        if (year % 4 == 0)
                        {
                            if (day != 28 && day != 29 && day != 1) //ngay thuong 
                            {
                                DDMMYY(day, month, year);
                            }
                            else
                            {
                                Feb_DayofMonth(day, month, year);
                            }
                            Console.WriteLine("Thang co 29 ngay");
                        }
                        else
                        {
                            if(day == 29)
                            {
                                Console.WriteLine("Nam khong nhuan khong co ngay 29 thang 2");
                            }
                            else
                            {
                                if (day != 28 && day != 29 && day != 1) //ngay thuong 
                                {
                                    DDMMYY(day, month, year);
                                }
                                else
                                {
                                    Feb_DayofMonth(day, month, year);
                                }
                            }
                            Console.WriteLine("Thang co 28 ngay");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Thang khong ton tai");
                    break;
            }
        }
        static void Main(string[] args)
        {
            DayofMonth();
            Console.ReadKey();
        }
    }
}
