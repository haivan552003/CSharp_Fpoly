using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab5
{
    public class cha
    {
        public virtual void show()
        {
            Console.WriteLine("Tao la cha");
        }
    }
    public class con : cha
    {
        public override void show()
        {
            Console.WriteLine("Con");
        }
    }
}
