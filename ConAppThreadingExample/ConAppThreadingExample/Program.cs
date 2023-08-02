using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConAppThreadingExample
{
    internal class Program
    {
        public static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i < num + 1; i++)
            {
                result *= i;
                Thread.Sleep(100);
            }
            return result;
        }
        public static int SumFactCon(int[] nums)
        {
            List<Task<int>> tasks = new List<Task<int>>();
            foreach (var num in nums)
            {
                tasks.Add(Task.Run(() => Factorial(num)));
            }
            Task.WhenAll(tasks).Wait();
            int totalSum = 0;
            foreach(var task in tasks)
            {
                totalSum += task.Result;
            }
            return totalSum;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 7, 8, 9, 10, 23, 34, 45 };
            Console.WriteLine("Sequential Example");
            var startTime1 = DateTime.Now;
            int seqSum = 0;
            foreach (var number in numbers)
            {
                seqSum += Factorial(number);
            }
            var endTime1 = DateTime.Now;
            var timeTaken1 = endTime1 - startTime1;
            Console.WriteLine("Start Time: \t" + startTime1.ToLongTimeString() + "\nEnd Time: \t" + endTime1.ToLongTimeString() + "\nTime Taken: \t" + timeTaken1);
            Console.WriteLine("Result: \t" + seqSum);

            Console.WriteLine();
            Console.WriteLine("Concurrent Example");
            var startTime = DateTime.Now;
            int cSum = SumFactCon(numbers);
            var endTime = DateTime.Now;
            var timeTaken = endTime - startTime;
            Console.WriteLine("Start Time: \t" + startTime + "\nEnd Time: \t" + endTime + "\nTime Taken: \t" + timeTaken);
            Console.WriteLine("Result: \t" + cSum);
            Console.ReadKey();
        }
    }
}
