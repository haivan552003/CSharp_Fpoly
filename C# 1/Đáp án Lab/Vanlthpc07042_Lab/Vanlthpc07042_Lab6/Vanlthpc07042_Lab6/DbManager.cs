using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager
{
    interface DbAction
    {
        void Insert();
        void Update();
        void Delete();
        void Select();
    }
    public class Product : DbAction
    {
        public void Delete()
        {
            Console.WriteLine("Delete Product");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Product");
        }

        public void Select()
        {
            Console.WriteLine("Select Product");
        }

        public void Update()
        {
            Console.WriteLine("Update Product");
        }
    }
    public class Order : DbAction
    {
        public void Delete()
        {
            Console.WriteLine("Delete Order");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Order");
        }

        public void Select()
        {
            Console.WriteLine("Select Order");
        }

        public void Update()
        {
            Console.WriteLine("Update Order");
        }
    }
}
