using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlide6
{
    public class Tau
    {
        public virtual void LayThongTin()
        {
            Console.WriteLine("Day la tau");
        }
    }
    public class TauChien : Tau
    {
        public override void LayThongTin()
        {
            Console.WriteLine("Day la tau chien");
        }
    }
    public class TauDuLich : Tau
    {
        public override void LayThongTin()
        {
            Console.WriteLine("Day la tau du lich");
        }
    }
}
