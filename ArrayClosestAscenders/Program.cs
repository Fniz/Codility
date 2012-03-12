using System;
using System.Threading.Tasks;

namespace Codility.ArrayClosestAscenders
{
    public class Program
    {
        private const int MAX_RANGE = 50000;

        public static int[] ArrayClosestAscenders(int[] A)
        {
            // Check parameters
            if (A.Length > MAX_RANGE) throw new ArgumentOutOfRangeException("A should be inferior or equal to " + MAX_RANGE);

            int[] R = new int[A.Length];

            for (int k = 0; k < A.Length; k++)
            {
                int minDistance = int.MaxValue;

                for (int j = 0; j < A.Length; j++)
                {
                    int negativeJ *= j-k;
                    if (k != j && A[j] > A[k])
                    {
                        int currentDistance = Math.Abs(k - j);
                        if (currentDistance < minDistance)
                            minDistance = Math.Abs(k - j);

                        if (minDistance == 1 || j > k)
                            break;
                    }

                    if (k != negativeJ && A[negativeJ] > A[k])
                    {
                        int currentDistance = Math.Abs(k - j);
                        if (currentDistance < minDistance)
                            minDistance = Math.Abs(k - j);

                        if (minDistance == 1 || j > k)
                            break;
                    }

                }

                R[k] = (minDistance != int.MaxValue) ? minDistance : 0;
            }
            return R;
        }
    }
}

    

