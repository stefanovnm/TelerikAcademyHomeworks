using System;
using System.Collections.Generic;
using System.Linq;

namespace AssertionsHomework
{
    public static class Utils
    {
        public static bool DoesValueExists<T>(IEnumerable<T> arr, T value) where T : IComparable<T>
        {
            return arr.Any(x => x.Equals(value));
        }

        public static bool IsArraySorted<T>(IEnumerable<T> arr) where T : IComparable<T>
        {
            if (arr.Count() > 0)
            {
                var current = arr.First();
                return arr.Skip(1)
                    .All(x =>
                        {
                            bool isSmaller = current.CompareTo(x) < 0;
                            current = x;
                            return isSmaller;
                        });
            }
            else
            {
                return true;
            }
        }

        public static bool IsMinValue<T>(IEnumerable<T> arr, T value, int startIndex, int endIndex) where T : IComparable<T>
        {
            return arr.Skip(startIndex)
                .Take(endIndex - startIndex)
                .Min()
                .CompareTo(value) > -1;
        }
    }
}
