internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Thong tin hoc sinh");
        string hoTen;
        int toan, ly, hoa;
        double trungBinh;

        Console.Write("Nhap ho va ten: ");
        hoTen= Console.ReadLine();
        Console.Write("Nhap diem toan: ");
        toan = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap diem ly: ");
        ly = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap diem hoa: ");
        hoa = Convert.ToInt32(Console.ReadLine());

        trungBinh = (double)(toan + ly + hoa) / 3;
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Ho va ten: " + hoTen.ToUpper());
        Console.WriteLine("Diem trung binh: " + Math.Round(trungBinh, 2)); //math.round lam trong so thap phan
    }
}