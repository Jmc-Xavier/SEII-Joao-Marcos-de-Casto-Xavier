using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace AsyncAwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string URL = "https://raw.githubusercontent.com/13oxer/Doggo/main/README.md";
            var tasks = new List<Task> { SummonDogLocally(), SummonDogFromURL(URL) };
            await Task.WhenAll(tasks);
        }

        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog Locally ...");
            string dogText = await File.ReadAllTextAsync("dog.txt");
            Console.WriteLine($"2. Dog Summoned locally\n{dogText}");
        }

        static async Task SummonDogFromURL(string URL)
        {
            using (var httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync(URL);
                Console.WriteLine($"2. Dog Summoned from URL\n{result}");
            }
        }
    }
}
