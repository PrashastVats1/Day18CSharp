using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConAppAssignment21_Threading
{
    internal class Program
    {
        static void DisplayDays(List<string> days)
        {
            Console.WriteLine("There are 7 days in a week. They are: ");
            foreach (var day in days)
            {
                Console.Write(day + "  ");
                Thread.Sleep(2000);
            }
        }
        static void DisplayMonths(List<string> months)
        {
            Thread.Sleep(3000);
            Console.WriteLine("There are tweleve months in a year. They are: ");
            foreach(var month in months)
            {
                Console.Write(month + "  ");
                Thread.Sleep(2000);
            }
        }
        static void DisplayFruitsAndWords(List<string> fruits)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Here are some fruits and their meanings: ");
            Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>()
            {
                {"Tomato", "Although eaten as a vegetable, is actually a fruit"},
                {"Strawberry", "A red fruit which is surprisingly not a berry!"},
                {"Banana", "A fruit with yellow skin which is a berry."},
                {"Grapes", "They are considered as true berries as they grow in clusters and are juicy till the inside!"},
                {"Orange", "It is still not know whether the color name came first or the fruit name"}
            };
            foreach(var fruit in fruits)
            {
                Console.WriteLine($"Fruit: \t{fruit}");
                if(wordsAndMeanings.TryGetValue(fruit, out string meaning))
                {
                    Console.WriteLine($"Meaning: {meaning}");
                }
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--- Welcome to Learning ---");
            List<string> fruits = new List<string>
            {
                "Tomato", "Strawberry", "Banana", "Grapes", "Orange", "Mango", "Pineapple", "Watermelon", "Peach"
            };
            List<string> days = new List<string>
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            List<string> months = new List<string>
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
            DisplayDays(days);
            Console.WriteLine("\n");
            DisplayMonths(months);
            Console.WriteLine("\n");
            DisplayFruitsAndWords(fruits);
            Console.WriteLine("Program Terminated!!");
            Console.ReadKey();
        }
    }
}
