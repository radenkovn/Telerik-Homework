namespace IEnumerableExtProg.Extensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public static class IEnumerableExtensions
    {
        public static TSource Sum<TSource>(this IEnumerable<TSource> source)
        {
            TSource result = (dynamic) 0;
            foreach (var item in source)
            {
                result += (dynamic)item; 
            }
            return result;
        }
        public static TSource Product<TSource>(this IEnumerable<TSource> source)
        {
            TSource result = (dynamic)1;
            foreach (var item in source)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static TSource MyMin<TSource>(this IEnumerable<TSource> source)
        {
            return source.Min();
        }
        public static TSource MyMax<TSource>(this IEnumerable<TSource> source)
        {
            return source.Max();
        }
        public static TSource MyAvg<TSource>(this IEnumerable<TSource> source)
        {
            return (dynamic)source.Sum()/source.Count();
        }
    }
}
