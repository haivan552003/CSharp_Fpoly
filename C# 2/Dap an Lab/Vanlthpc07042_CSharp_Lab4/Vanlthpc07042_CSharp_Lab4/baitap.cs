using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp_Lab4
{
    //bai 1
    class bai1
    {
        public static void Bai1()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumber = list.FindAll(x => (x % 2) == 0); 

            evenNumber.ForEach(x =>
                Console.WriteLine(x));
        }
    }

    //bai 2
    class bai2
    {
        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void Bai2()
        {
            List<Dog> dogs = new List<Dog>()
        {
            new Dog { Name = "Kiki", Age = 2 },
            new Dog { Name = "Lulu", Age = 4 },
            new Dog { Name = "Gau", Age = 1 }
        };
            var newListDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var item in dogs) //Select
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
            }
            Console.WriteLine("*****************************");
            foreach (var item in newListDogs) //OrderByDescending
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
            }
        }
    }
    //bai 3
    class bai3
    {
        class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void Bai3()
        {
            IList<student> studentList = new List<student>()
            {
                new student() {Id = 1, Name = "Phuoc", Age = 18},
                new student() {Id = 2, Name = "Minh", Age = 11},
                new student() {Id = 3, Name = "Ta", Age = 18},
                new student() {Id = 4, Name = "Hai", Age = 10},
                new student() {Id = 5, Name = "Van (tac gia)", Age = 19}
            };
            //Query Syntax
            var newStudentList = from st in studentList
                                 where (st.Age > 12 && st.Age < 20)
                                 select new 
                                 { 
                                    id = st.Id,
                                    name = st.Name,
                                    age = st.Age
                                 };

            foreach (var item in newStudentList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Age: {2}", item.id, item.name, item.age);
            }
            Console.WriteLine("*****************************");
            //Method Syntax
            var result = studentList.Where(s => s.Age > 12 && s.Age < 20);
            foreach (var item in result)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Age: {2}", item.Id, item.Name, item.Age);
            }
        }
    }

    //bai 4
    class bai4
    {
        public static void Bai4()
        {
            List<int> intergerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            var MethodSyntax = (from obj in intergerList where obj > 5 select obj).Sum();
            Console.WriteLine("Sum is: " + MethodSyntax);
        }
    }
}
