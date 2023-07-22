using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 1000000;
            for(int listSize = 1; listSize < 10; listSize++)
            {
                List<String> list = new List<String>();
                HashSet<String> hashset = new HashSet<String>();
                for(int i = 0; i < listSize; i++)
                {
                    list.Add("string" + i.ToString());
                    hashset.Add("string" + i.ToString());
                }

                Stopwatch timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i < times; i++)
                {
                    hashset.Remove("string0");
                    hashset.Add("string0");
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item HASHSET str time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine();
            }

            for (int listSize = 1; listSize < 10; listSize += 3)
            {
                List<object> list = new List<object>();
                HashSet<object> hashset = new HashSet<object>();

                for(int i = 0; i < listSize; i++)
                {
                    list.Add(new object());
                    hashset.Add(new object());
                }
                object objToAddRem = list[0];
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i < times; i++)
                {
                    list.Remove(objToAddRem);
                    list.Add(objToAddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item LIST objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                timer = new Stopwatch();
                timer.Start();
                for (int i = 0; i < times; i++)
                {
                    hashset.Remove(objToAddRem);
                    hashset.Add(objToAddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item HASHSET objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
