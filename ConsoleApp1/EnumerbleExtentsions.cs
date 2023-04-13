using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class EnumerbleExtentsions
    {
        public static void ForEach<TValue>(this IEnumerable<TValue> values, Action<TValue> action)
        {
            foreach (var value in values)
                action(value);
        }
    }
}
