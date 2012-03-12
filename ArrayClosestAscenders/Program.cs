using System;
using System.Threading.Tasks;

namespace Codility.ArrayClosestAscenders
{
    public class Program
    {
        private const int MAX_RANGE = 50000;

        public static int[] ArrayClosestAscenders(int[] inputArray)
        {
            // Check parameters
            if (inputArray == null) throw new ArgumentNullException("inputArray can't be null");
            if (inputArray.Length > MAX_RANGE) throw new ArgumentOutOfRangeException("inputArray should be inferior or equal to " + MAX_RANGE);

            int[] outputArray = new int[inputArray.Length];

            for (int k = 0; k < inputArray.Length; k++)
            {
                int j = k;  // j is a posivite index which increase to get the next ascender.
                int m = k;  // m is a posivite index which decrease to get the next ascender.
                int minDistance = int.MaxValue;
                int currentDistance = int.MaxValue;

                while (j < inputArray.Length -1)
                {
                    j++;
                    m--;

                    if (m >= 0 && inputArray[m] > inputArray[k])
                    {
                        currentDistance = Math.Abs(k - m);

                        if (currentDistance < minDistance)
                            minDistance = currentDistance;

                        if (minDistance == 1)
                            break;
                    }

                    if (inputArray[j] > inputArray[k])
                    {
                        currentDistance = Math.Abs(k - j);

                        if (currentDistance < minDistance)
                            minDistance = currentDistance;

                        break;
                    }
                }

                outputArray[k] = (minDistance != int.MaxValue) ? minDistance : 0;
            }

            return outputArray;
        }
    }
}

    

