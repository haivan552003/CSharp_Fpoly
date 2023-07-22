
using Bai4;

internal class Program
{
    private static void Main(string[] args)
    {
        Tdelegate m = new Tdelegate();
        vdTdelegate<int> dlgt = new vdTdelegate<int>(m.add);
        Console.WriteLine("Add result: " + dlgt(90, 10));
        dlgt = m.sub;
        Console.WriteLine("Sub result: "+dlgt(90, 10));
    }
}