using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Begin of main");
            //Task.Factory.StartNew(() => Metod1());
            Metod1();
            Console.WriteLine("End of program");
            Console.ReadLine();
        }


        public static async Task Metod1()
        {
            Console.WriteLine("Before 1st method");
            var tasks = new[] {Task.Factory.StartNew(() => Sleep(5000)), Task.Factory.StartNew(() => Sleep(500))};
            Console.WriteLine("After 1st method");
            await Task.WhenAll(tasks);
            Console.WriteLine("After waitAll");
        }

        private static void Sleep(int i)
        {
            Console.WriteLine($"In method that sleeps {i}");
            Thread.Sleep(i);
        }
    }
}