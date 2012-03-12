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
                int j = k;
                int m = k;
                int minDistance = int.MaxValue;

                while (j < A.Length -1)
                {
                    j++;
                    m--;

                    if (A[j] > A[k])
                    {
                        int currentDistance = Math.Abs(k - j);

                        if (currentDistance < minDistance)
                            minDistance = Math.Abs(k - j);

                        if (j > k)
                            break;
                    }

                    if (m >= 0 && A[m] > A[k])
                    {
                        int currentDistance = Math.Abs(k - m);

                        if (currentDistance < minDistance)
                            minDistance = Math.Abs(k - j);
                    }

                    if (minDistance == 1)
                        break;
                }

                R[k] = (minDistance != int.MaxValue) ? minDistance : 0;
            }

            #region OLD CODE
            //for (int k = 0; k < A.Length; k++)
            //{
            //    int minDistance = int.MaxValue;

            //    for (int j = 0; j < A.Length; j++)
            //    {
            //        if (k != j && A[j] > A[k])
            //        {
            //            int currentDistance = Math.Abs(k - j);
            //            if (currentDistance < minDistance)
            //                minDistance = Math.Abs(k - j);

            //            if (minDistance == 1 || j > k)
            //                break;
            //        }
            //    }

            //    R[k] = (minDistance != int.MaxValue) ? minDistance : 0;
            //}
            #endregion

            return R;
        }
    }
}

    

