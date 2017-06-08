using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // Searching methods.
    public static class Searchers<T> where T : IComparable<T>
    {
        // Return the index of the item or -1 if the item isn't in the list.

        public static int LinearSearch(T[] values, T target)
        {
            for (int i = 0; i < values.Length; i++)
                if (values[i].CompareTo(target) == 0) return i;
            return -1;
        }

        public static int BinarySearch(T[] values, T target)
        {
            int min = 0;
            int max = values.Length - 1;
            while (min <= max)
            {
                int mid = (max + min) / 2;
                int diff = target.CompareTo(values[mid]);
                if (diff == 0) return mid;
                if (diff < 0) max = mid - 1;
                else min = mid + 1;
            }
            return -1;
        }

        // This one requires an arithmetic data type so it's not generic.
        public static int InterpolationSearch(long[] values, long target)
        {
            // Make an initial guess.
            int min = 0;
            int max = values.Length - 1;
            double fraction = (target - values[0]) / (double)(values[max] - values[0]);
            int guess = (int)((max - min) * fraction);
            if (guess < 0) guess = 0;
            else if (guess > max) guess = max;

            // Use an expanding binary search to bound the target.
            if (target == values[guess]) return guess;
            if (target < values[guess])
            {
                // Search down.
                max = guess;
                int offset = 1;
                while (target < values[guess])
                {
                    guess -= offset;
                    if (guess < 0)
                    {
                        guess = 0;
                        break;
                    }
                    offset *= 2;
                }
                min = guess;
            }
            else
            {
                // Search up.
                min = guess;
                int offset = 1;
                while (target > values[guess])
                {
                    guess += offset;
                    if (guess > max)
                    {
                        guess = max;
                        break;
                    }
                    offset *= 2;
                }
                max = guess;
            }

            // Binary search from this point.
            while (min <= max)
            {
                int mid = (max + min) / 2;
                int diff = target.CompareTo(values[mid]);
                if (diff == 0) return mid;
                if (diff < 0) max = mid - 1;
                else min = mid + 1;
            }
            return -1;
        }

        // This one requires an arithmetic data type so it's not generic.
        // Use interpolation to pick an initial guess. Use binary search after that.
        public static int InterpolationSearch2(long[] values, long target)
        {
            // Make an initial guess.
            int min = 0;
            int max = values.Length - 1;
            double fraction = (target - values[0]) / (double)(values[max] - values[0]);
            int guess = (int)((max - min) * fraction);
            if (guess < 0) guess = 0;
            else if (guess > max) guess = max;

            if (target == values[guess]) return guess;
            if (target < values[guess]) max = guess;
            else min = guess;

            // Binary search from this point.
            while (min <= max)
            {
                int mid = (max + min) / 2;
                int diff = target.CompareTo(values[mid]);
                if (diff == 0) return mid;
                if (diff < 0) max = mid - 1;
                else min = mid + 1;
            }
            return -1;
        }
    }
}
