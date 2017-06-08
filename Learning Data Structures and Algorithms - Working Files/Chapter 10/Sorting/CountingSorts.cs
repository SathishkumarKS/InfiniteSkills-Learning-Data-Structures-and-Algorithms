using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // Note that this only works with integer data types so this class isn't generic.
    public static class CountingSorts
    {
        // Countingsort.
        public static void Countingsort(int[] values, int min, int max)
        {
            // Make the counts.
            int[] counts = new int[max - min + 1];
            for (int i = 0; i < values.Length; i++)
                counts[values[i] - min]++;

            // Write the values back into the array.
            int index = 0;
            int nextValue = min;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                    values[index++] = nextValue;
                nextValue++;
            }
        }
    }
}
