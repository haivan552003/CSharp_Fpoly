using DemoSlide7;

public delegate void Printdetail();
public class TestEvent
{
    event Printdetail Print;
    public void show()
    {
        Console.WriteLine("In ra mang hinh");
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("VD delegate");
        //Maths m = new Maths();
        //VDDelegate vd = m.Add;
        //vd += m.Subtract;
        //vd(10, 90);
        //Console.WriteLine("------------------");
        //VD(m.Add, 10, 90);
        //VD(m.Subtract, 10, 900);
        //Console.WriteLine("------------------");
        TestEvent test = new TestEvent();
        test.show();
        test.Print += new Printdetail(test.show);
        test.Print();
    }
}
internal class Program
{
    static void VD(VDDelegate dlg, int a,int b)
    {
        dlg(a, b);
    }
    
}