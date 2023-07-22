using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Product
    {
        public string Name;
        public double cost;
        public double giamgia;
        public Product() { }


        public Product(string name, double cost, double giamgia)
        {
            Name = name;
            this.cost = cost;
            this.giamgia = giamgia;
        }
        public void Nhap()
        {
            Console.WriteLine("Ten SP: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Gia: ");
            this.cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Giam gia: ");
            this.giamgia = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten SP: "+this.Name);
            
            Console.WriteLine("Gia: "+this.cost);
            
            Console.WriteLine("Giam gia: "+this.giamgia);
            
        }
        public override string ToString()
        {
            return"Ten: " +this.Name 
                +" \nGia: " +this.cost 
                +" \nGiam Gia: " +this.giamgia;
        }
    }
}
