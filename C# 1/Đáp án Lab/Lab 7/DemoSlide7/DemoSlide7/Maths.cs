using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide7
{
    
    
    public delegate void VDDelegate(int x, int y);
    public class Maths
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("kq: " + (x + y));
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("kq: " + (x - y));
        }
    }
}
