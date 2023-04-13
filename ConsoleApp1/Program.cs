using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private const int NumbersCount = 20;
        private const int NumbersStart = 0;
        private const int NumbersEnd = 99;
        private static readonly Random Random = new();

        static void Main(string[] args)
        {
            var arr = Enumerable.Range(NumbersStart, NumbersEnd + 1).Select(_ => Random.Next(10)).ToArray();
            arr = arr.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", arr));

            Console.ReadKey();
        }
    }
}
