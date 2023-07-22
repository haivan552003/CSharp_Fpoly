using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vanlthpc07042_CSharp2_Lab8
{
    //bai 1
    class bai1
    {
        static bool running = true;

        //thread 1
        public static void Thread1()
        {
            int sleepfor = 2000;
            for (int i = 0; i < 100; i++)
            {
                int random = new Random().Next(1, 21);
                Console.WriteLine("So ngau nhien " + random);
                Thread.Sleep(sleepfor/1000);
            }
            running = false;
        }

        //thread 2
        public static void Thread2()
        {
            int sleepfor = 1000;
            int random = 0;
            for (int i = 0; i < 100; i++)
            {
                lock (typeof(bai1))
                {
                    random = new Random().Next(1, 21);
                }
                Console.WriteLine("Binh phuong cua " + random + " la: " + (int)Math.Pow(random, 2));
                Thread.Sleep(sleepfor/1000);
            }
        }

        public static void Bai1()
        {
            Thread t1 = new Thread(new ThreadStart(Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread2));
            t1.Start();  
            t2.Start();

            while (running)
            {
                Thread.Sleep(1000);
            }
        }
    }

    //bai 2
    class bai2
    {
        static Object synObj1 = new Object();
        static Object synObj2 = new Object();

        static void Foo()
        {
            Console.WriteLine("Inside Foo Method");
            lock (synObj1)
            {
                Console.WriteLine("Foo: lock(synObj1)");
                Thread.Sleep(100);
                lock (synObj2)
                {
                    Console.WriteLine("Foo: lock(synObj2)");
                }
            }
        }

        static void Bar()
        {
            Console.WriteLine("Inside Foo Method");
            lock (synObj2)
            {
                Console.WriteLine("Bar: lock(synObj2)");
                Thread.Sleep(100);
                if(Monitor.TryEnter(synObj2, 1000))
                {
                    try
                    {
                        Console.WriteLine("Bar: lock(synObj1)");
                    }
                    finally
                    {
                        Monitor.Exit(synObj2);
                    }
                }
            }
        }
        public static void Bai2()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Foo);
            Thread t2 = new Thread(Bar);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Main Thread Completed");
        }
    }
}
