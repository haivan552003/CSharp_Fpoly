using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab7
{
    class bai1
    {  
        public static void Bai1()
        {
            //bai 1a
            Console.WriteLine("Bai 1a\n");
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var num = (from n in n1
                       where n % 2 == 0 && n > 4
                       select Math.Pow(n, 2)).Sum();

            Console.WriteLine("Binh phuong so chan lon hon 4: {0}", num);

            //bai1 b
            Console.WriteLine("Bai 1b\n");
            String str;
            Console.WriteLine("Nhap chuoi: ");
            str = Console.ReadLine();
            Dictionary<Char, int> str1 = new Dictionary<Char, int>();
                

            foreach (Char item in str.Replace(" ", String.Empty))
            {
                if (str1.ContainsKey(item))
                {
                    str1[item] += 1;
                }
                else
                {
                    str1.Add(item, 1);
                }
                
            }
            foreach (var item in str1.Keys)
            {
                Console.WriteLine(item + ": " + str1[item]);
            }

            //bai1 C
            Console.WriteLine("Bai 1c\n");
            String strNew;
            Console.WriteLine("Nhap chuoi: ");
            strNew = Console.ReadLine();

            Console.WriteLine("Chuoi co UPPER CASE");
            var ucWord = WordFit(strNew);
            foreach (String item in ucWord)
            {
                Console.WriteLine(item);
            }
        }
        //bai1 C
        static IEnumerable<string> WordFit(String mystr)
        {
            var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(),
                                                                StringComparison.Ordinal));
            return upWord;
        }
    }
    class bai2
    {
        public static void Bai2()
        {
            NorthWindDBDataContext db = new NorthWindDBDataContext();
            //bai 2a
            Console.WriteLine("Bai 2a\n");
            var customer = db.Customers.ToList();
            var orders = db.Orders.ToList();

            var output = from cus in customer
                         join ord in orders
                         on cus.CustomerID equals ord.CustomerID
                         select new
                         {
                             ContactName = cus.ContactName,
                             ShipName = ord.ShipName
                         };

            foreach (var item in output)
            {
                Console.WriteLine("ContactName: {0}, ShipName: {1}", item.ContactName, item.ShipName);
            }

            //bai 2b
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Bai 2b\n");
            var bai2b = new Customer()
            {
                CustomerID = "FPoly",
                CompanyName = "PFT"
            };

            Console.WriteLine("CustomerID: {0}, CompanyName: {1}\n", bai2b.CustomerID, bai2b.CompanyName);
            //foreach (var item in customer)
            //{
            //    Console.WriteLine("CustomerID: {0}, CompanyName: {1}, City: {2}", item.CustomerID, item.CompanyName, item.City);
            //}


            //bai 2c
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Bai 2c\n");
            var bai2c = db.Customers
                        .Where(c => c.CustomerID == "Fpoly")
                        .FirstOrDefault();
            bai2c.CompanyName = "FE";
            db.SubmitChanges();

            Console.WriteLine("CustomerID: {0}, CompanyName: {1}\n", bai2c.CustomerID, bai2c.CompanyName);
            //foreach (var item in customer)
            //{
            //    Console.WriteLine("CustomerID: {0}, CompanyName: {1}, City: {2}", item.CustomerID, item.CompanyName, item.City);
            //}


            //bai 2d
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Bai 2d\n");

            //var bai2d_2 = db.CustomerCustomerDemos
            //             .Where(c => c.CustomerID == "ALFKI")
            //             .FirstOrDefault();

            var bai2d_1 = db.Orders
                         .Where(c => c.CustomerID == "ALFKI")
                         .FirstOrDefault();

            var bai2d = db.Customers
                        .Where(c => c.CustomerID == "ALFKI")
                        .FirstOrDefault();

            //db.CustomerCustomerDemos.DeleteOnSubmit(bai2d_2);
            db.Orders.DeleteOnSubmit(bai2d_1);
            db.Customers.DeleteOnSubmit(bai2d);
                     
            db.SubmitChanges();

            Console.WriteLine("CustomerID: {0}, CompanyName: {1}\n", bai2d.CustomerID, bai2d.CompanyName);
            //foreach (var item in customer)
            //{
            //    Console.WriteLine("CustomerID: {0}, CompanyName: {1}, City: {2}", item.CustomerID, item.CompanyName, item.City);
            //}
        }
    }
}
