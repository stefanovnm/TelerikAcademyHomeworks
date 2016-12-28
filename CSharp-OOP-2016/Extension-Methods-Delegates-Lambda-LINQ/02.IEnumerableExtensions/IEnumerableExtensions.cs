namespace _02.IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            T sum = default(T);

            foreach (var element in list)
            {
                sum += (dynamic)element; //cast to dynamic for this: Error	1	Operator '+=' cannot be applied to operands of type 'T' and 'T'
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            T product = (dynamic)1;

            foreach (var element in list)
            {
                product *= (dynamic)element;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> list)
        {
            T min = list.First();

            foreach (var element in list)
            {
                if (min > (dynamic)element)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
        {
            T max = list.First();

            foreach (var element in list)
            {
                if (max < (dynamic)element)
                {
                    max = element;
                }
            }

            return max;
        }

        public static dynamic Average<T>(this IEnumerable<T> list)
        {
            dynamic average = default(T);
            int counter = 0;

            foreach (var element in list)
            {
                average += (dynamic)element;
                counter++;
            }

            if (counter > 0)
            {
                average = average / counter;
            }

            return average;
        }
    
    
    }
}
