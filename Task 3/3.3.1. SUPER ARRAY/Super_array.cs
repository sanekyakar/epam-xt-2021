using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1.SUPER_ARRAY
{
    public static class Super_array
    {
        public static int[] Extension(this int[] array, Func<int, int> func)
        {
            if (array == null || func == null)
            {
                throw new ArgumentNullException("You've got a null argument");
            }
            else
            {
                return array.Select(item => func(item)).ToArray();
            }
        }

        public static int NewSum(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Entered array is null");
            }
            int sum = 0;
            array.Select(item => sum += item);

            return sum;
        }

        public static double NewAverage(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Entered array is null");
            }
            return array.NewSum() / array.Length;
        }

        public static T FrequentlyUse<T>(this T[] array) where T : struct
        {
            if (array == null)
            {
                throw new ArgumentNullException("Entered array is null");
            }
            return array.OrderBy(item => item).GroupBy(item => item).OrderByDescending(item => item.Count()).FirstOrDefault().Key;
        }
    }
}
