using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private const int NumbersCount = 20;
        private static readonly Random Random = new();
        static void Main(string[] args)
        {
            var arr = Enumerable.Range(0, NumbersCount).Select(_ => Random.Next(10)).ToArray();
            arr = arr.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", arr));

            Console.ReadKey();
        }
    }
}
