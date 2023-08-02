//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppThreading1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to threads");
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConAppThreading1
//{
//    internal class Program
//    {
//        public static void MethodOne()
//        {
//            Console.WriteLine("Method One: ");
//            for (int i=0; i < 10; i++)
//            {
//                Console.Write(i + "\t");
//                Thread.Sleep(500);
//            }
//            Console.WriteLine("\n");
//        }
//        public static void MethodTwo()
//        {
//            Console.WriteLine("Method Two: ");
//            for (int i = 20; i < 30; i++)
//            {
//                Console.Write(i + "\t");
//                Thread.Sleep(500);
//            }
//            Console.WriteLine("\n");
//        }
//        public static void MethodThree()
//        {
//            Console.WriteLine("Method Three: ");
//            for (int i = 40; i < 50; i++)
//            {
//                Console.Write(i + "\t");
//                Thread.Sleep(500);
//            }
//            Console.WriteLine("\n");
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to threads");
//            MethodOne();
//            MethodTwo();
//            MethodThree();
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConAppThreading1
{
    internal class Program
    {
        public static void MethodOne()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Method One: ");
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            //Console.WriteLine("\n");
        }
        public static void MethodTwo()
        {
            
            for (int i = 20; i < 30; i++)
            {
                Console.Write("Method Two: ");
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            //Console.WriteLine("\n");
        }
        public static void MethodThree()
        {
            
            for (int i = 40; i < 50; i++)
            {
                Console.Write("Method Three: ");
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            //Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to threads");
            Thread thread1 = new Thread(MethodOne);
            Thread thread2 = new Thread(MethodTwo);
            Thread thread3 = new Thread(MethodThree);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();
        }
    }
}
