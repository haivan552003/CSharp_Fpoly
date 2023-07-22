using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    public class SinhVienComparerGiamDan : IComparer<SinhVien>
    {
        public int Compare(SinhVien? x, SinhVien? y)
        {
            double diem1 = x.diem;
            double diem2 = y.diem;
            int flag = 0;
            if (diem1 < diem2)
            {
                return flag = 1;
            }
            else if (diem1 > diem2)
            {
                return flag = -1;
            }
            else
            {
                return flag = 0;
            }
        }
    }
    public class SinhVien
    {
        private int n;
        private string hoten;
        private string email;
        private string hocluc;
        private string theoHocLuc;
        public string MSSV;
        public double diem;
        private double Max, Min;
         
       
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\n\tNhập Thông tin Sinh Viên");
            Console.WriteLine("Họ và Tên : ");
        ten: this.hoten = Console.ReadLine();
            string photen = "^([a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ]+)((\\s{1}[a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ]+){1,})$";
            if (!Regex.IsMatch(this.hoten.ToLower(), photen))
            {
                Console.WriteLine("Vui long nhập lại họ tên !"); goto ten;
            }
            Console.WriteLine("Email : ");           
            tkemail: this.email = Console.ReadLine();
            string pmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(this.email.ToLower(), pmail))
            {
                Console.WriteLine("Vui long nhập lại email của bạn !"); goto tkemail;
            }
            Console.WriteLine("Điểm : ");
            while (true)
            {
                try
                {
                    this.diem = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Kiểu dữ liệu phải là số . Mời bạn nhập lại !");
                    Console.WriteLine("Điểm : ");
                }
            }
            if (this.diem < 3)
            {
                this.hocluc = "Kém";
            }
            else if (this.diem < 5)
            {
                this.hocluc = "Yếu";
            }
            else if (this.diem < 6.5)
            {
                this.hocluc = "Trung Bình";
            }
            else if (this.diem < 7.5)
            {
                this.hocluc = "Khá";
            }
            else if (this.diem < 9)
            {
                this.hocluc = "Giỏi";
            }
            else
            {
                this.hocluc = "Xuất Sắc";
            }
        }
        public string getHoten()
        {
            return this.hoten;
        }
        public static List<SinhVien> NhapDanhSachSV()
        {
            List<SinhVien> dssv = new List<SinhVien>();

            while (true)
            {
                SinhVien sv = new SinhVien();
                sv.Nhap();
                if (CheckHoTenSV(dssv, sv))
                {
                    dssv.Add(sv);
                }
                else
                {
                    Console.WriteLine("Sinh viên vừa nhập bị trùng tên. Không được thêm vào danh sách!");
                }
                Console.WriteLine("Ban có muốn tiếp tục thêm sinh viên không (Y/N)?");
                char isExist = char.Parse(Console.ReadLine());
                if (isExist == 'N' || isExist == 'n')
                {
                    break;
                }
            }
            return dssv;
        }            

            
        
        public static bool CheckHoTenSV(List<SinhVien> dssv, SinhVien sv)
        {
            bool isOK = true;

            foreach (SinhVien item in dssv)
            {
                if (sv.getHoten().ToLower() == item.getHoten().ToLower())
                {
                    isOK = false;
                    break;
                }
            }
            return isOK;
        }

        public double getDiem()
        {
            return this.diem;
        }
        
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
           
            
            Console.WriteLine("Họ và Tên : " + this.hoten);
            Console.WriteLine("Email : " + this.email);
            Console.WriteLine("Điểm : " + this.diem);
            Console.WriteLine("Học Lực :  " + this.hocluc);
            Console.WriteLine("===========================");
            
        }
        public string getHocLuc()
        {
            return this.hocluc;
        }
        
        
    }
}
