//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConAppThreadingEx2
//{
//    internal class Program
//    {
//        private static object lockObject;
//        public static class Counter
//        {
//            public static int CounterValue { get; set; }
//        }
//        public static void IncrementCounter()
//        {
//            for (int i = 0; i < 10000; i++)
//            {
//                lock(lockObject)
//                {
//                    Counter.CounterValue++;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            lockObject = new object();
//            Thread thread1 = new Thread(IncrementCounter);
//            Thread thread2 = new Thread(IncrementCounter);
//            thread1.Start();
//            thread2.Start();
//            thread1.Join();
//            thread2.Join();
//            Console.WriteLine("Final Counter Value: \t"+Counter.CounterValue);
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

namespace ConAppThreadingEx2
{
    internal class Program
    {
        public static void PrintNumbers(int num)
        {
            for (int i = 0; i < num + 1; i++)
            {
                Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}: {i}");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => PrintNumbers(10));
            Thread thread2 = new Thread(() => PrintNumbers(12));
            thread1.Start();
            thread2.Start();
            //thread1.Join();
            //thread2.Join();
            Console.ReadKey();
        }
    }
}