using ConsoleApp1.entitis;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private const int NumbersCount = 20;
        private const int VelueLengthStart = 1;
        private const int VelueLengthEnd = 5;
        private static readonly Random Random = new();
        static void Main(string[] args)
        {
            var arr = Enumerable.Range(0, NumbersCount).Select(_ => new Item { Number = Random.Next(10), Value = new string('x', Random.Next(VelueLengthStart, VelueLengthEnd))}) .ToArray();
            arr = arr.OrderBy(x => x.Number).ToArray();

            Console.WriteLine(string.Join(", ", arr.Select(i => $"{i.Number} - {i.Value}")));

            Console.ReadKey();
        }
    }
}
