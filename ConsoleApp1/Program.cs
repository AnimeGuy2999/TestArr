using ConsoleApp1.entitis;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private const int NumbersCount = 20;
        private const int NumbersStart = 0;
        private const int NumbersEnd = 99;
        private const int VelueLengthStart = 1;
        private const int VelueLengthEnd = 5;
        private static readonly Random Random = new();

        static void Main(string[] args)
        {
            var arr = Enumerable
                .Range(0, NumbersCount)
                .Select(_ => new Item { 
                    Number = Random.Next(10), Value = new string('x', Random.Next(VelueLengthStart, VelueLengthEnd))
                })
                .ToArray();
            arr = arr.OrderBy(x => x.Number).ToArray();


            arr.Select((value, index) => $"{index,2}: {value.Number,2} - {value.Value}").ForEach(Console.WriteLine); 

            Console.ReadKey();
        }
    }
}
