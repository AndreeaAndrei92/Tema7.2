using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class IEnumerbleExtensionss
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            foreach (var item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            T min = collection.Last();
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            T max = collection.Last();
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            double result = 0.0;
            result = collection.Aggregate(result, (x, y) => (dynamic)x + y) / collection.Count();
            return result;
        }


    }
}
