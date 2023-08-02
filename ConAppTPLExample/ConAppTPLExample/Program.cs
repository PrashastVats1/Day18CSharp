using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTPLExample
{
    internal class Program
    {
        public static async Task<string> DownloadPage(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            };
        }
        public static void ProcessPages(List<string> urls)
        {
            Parallel.ForEach(urls, url =>
            {
                string page = DownloadPage(url).Result;
                Console.WriteLine($"Downloaded {url}. Web Page Length is {page.Length} characters");
            });
        }
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "https://www.thehindu.com/",
                "https://www.espncricinfo.com/",
                "https://www.bbc.com/hindi",
                "https://growth.design/case-studies",
            };
            Console.WriteLine("Download URLs are processing");
            var startTime = DateTime.Now;
            ProcessPages(urls);
            var endTime = DateTime.Now;
            var totalTime = endTime - startTime;
            Console.WriteLine($"Time Taken: Start Time was {startTime} and End Time was {endTime}");
            Console.WriteLine($"Total Time taken for processing is: {totalTime}");
            Console.ReadKey();
        }
    }
}

