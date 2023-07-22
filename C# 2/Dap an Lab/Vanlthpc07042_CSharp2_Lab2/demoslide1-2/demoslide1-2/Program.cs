using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoslide1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mang = { "a", "b", "c" };
            LinkedList<string> ds = new LinkedList<string>(mang);
            ds.AddLast("5");
            ds.AddFirst("1");
            ds.AddAfter(ds.Find("b"), "d");
            foreach(string item in ds)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
