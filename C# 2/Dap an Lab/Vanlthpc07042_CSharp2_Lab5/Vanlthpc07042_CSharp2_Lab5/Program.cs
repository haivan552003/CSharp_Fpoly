using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab5
{
    class Program
    {
        private class Contact
        {
            internal int fn;

            public int Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }

            internal static object ToLookup(Func<object, object> p)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            var contacts = new List<Contact>
        {
            new Contact
            {
                Age = 20,
                FirstName = "Hai",
                LastName = "Van",
                Address = "Ha Noi"
            },
            new Contact
            {
                Age = 17,
                FirstName = "Anh",
                LastName = "Duy",
                Address = "Can Tho"
            },
            new Contact
            {
                Age = 20,
                FirstName = "Minh",
                LastName = "Phuoc",
                Address = "Ha Noi"
            },
            new Contact
            {
                Age = 16,
                FirstName = "Minh",
                LastName = "Kha",
                Address = "Ca Mau"
            },
            new Contact
            {
                Age = 20,
                FirstName = "Tien",
                LastName = "Dat",
                Address = "Hau Giang"
            },
            new Contact
            {
                Age = 18,
                FirstName = "That",
                LastName = "Huy",
                Address = "Bac Lieu"
            },
            new Contact
            {
                Age = 22,
                FirstName = "Huu",
                LastName = "Hieu",
                Address = "Can Tho"
            },
            new Contact
            {
                Age = 19,
                FirstName = "Minh",
                LastName = "Hieu",
                Address = "Bac Lieu"
            }
        };



            //bai 1
            Console.WriteLine("Bai 1\n");



            // dia chi Ha Noi
            var fromHN = from ct in contacts
                         where ct.Address == "Ha Noi"
                         select new
                         {
                             age = ct.Age,
                             fn = ct.FirstName,
                             ln = ct.LastName,
                             ad = ct.Address
                         };
            foreach (var item in fromHN)
            {
                Console.WriteLine("Nguoi co dia chi Ha Noi\nAge: {0}, First Name: {1}, Last Name: {2}, Address: {3}\n", item.age, item.fn, item.ln, item.ad);
            }



            // tuoi lon nhat
            var maxAge = from ct in contacts
                         where ct.Age == (from age in contacts
                                          select age.Age).Max()
            select new
                         {
                             age = ct.Age,
                             fn = ct.FirstName,
                             ln = ct.LastName,
                             ad = ct.Address
                         };
            foreach (var item in maxAge)
            {
                Console.WriteLine("Max Age\nAge: {0}, First Name: {1}, Last Name: {2}, Address: {3}\n", item.age, item.fn, item.ln, item.ad);
            }



            //tuoi lon nhat cach 2
            var MaxAge = contacts.OrderByDescending(x => x.Age);
            foreach (var item in maxAge)
            {
                Console.WriteLine("Max Age cach 2\nAge: {0}, First Name: {1}, Last Name: {2}, Address: {3}\n", item.age, item.fn, item.ln, item.ad);
            }



            //dem so nguoi trong danh sach
            var countlist = contacts.Count();
            Console.WriteLine("Danh sach co: {0} nguoi", countlist);



            //bai 2
            Console.WriteLine("**************");
            Console.WriteLine("Bai 2\n");



            //sap xep theo do tuoi tang dan
            Console.WriteLine("Xap xep tuoi tang dan\n");

            var sortAge = contacts.OrderBy(x => x.Age);
            foreach (var item in sortAge)
            {
                Console.WriteLine("Age: {0}, First Name: {1}, Last Name: {2}, Address: {3}", item.Age, item.FirstName, item.LastName, item.Address);
            }



            //sap xep theo do tuoi va firstname giam dan
            Console.WriteLine("\nXap xep tuoi va First Name giam dan\n");

            var sortAgeFn = contacts.OrderByDescending(x => x.Age).ThenByDescending(x => x.FirstName); //no sap xep theo bang chu cai
            foreach (var item in sortAgeFn)
            {
                Console.WriteLine("Age: {0}, First Name: {1}, Last Name: {2}, Address: {3}", item.Age, item.FirstName, item.LastName, item.Address);
            }



            // liet ke danh danh nguoi co first name bat dau bang "M"
            Console.WriteLine("\nDanh danh nguoi co First Name bat dau bang 'M'\n");

            IEnumerable<Contact> fnB = contacts.Where(x => x.FirstName.StartsWith("M"));
            foreach (var item in fnB)
            {
                Console.WriteLine("Age: {0}, First Name: {1}, Last Name: {2}, Address: {3}", item.Age, item.FirstName, item.LastName, item.Address);
            }

            //bai 3
            Console.WriteLine("**************");
            Console.WriteLine("Bai 2\n");
            Console.WriteLine("Dung ToLookup chuyen List ve key/value\n");
            var toLook = contacts.ToLookup(x => x.Age);

            foreach (var KeyValuePair in toLook)
            {
                Console.WriteLine("\n" + KeyValuePair.Key);
                foreach (var item in toLook[KeyValuePair.Key])
                {
                    Console.WriteLine("Age: {0}, First Name: {1}, Last Name: {2}, Address: {3}", item.Age, item.FirstName, item.LastName, item.Address);
                }
            }

            
            Console.ReadLine();
        }
    }
}
